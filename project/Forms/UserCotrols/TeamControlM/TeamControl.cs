using project.DataHandlers;
using project.DataHandlers.ViewModel;
using project.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace project.Forms.UserCotrols.TeamControlM
{
    public partial class TeamControl : UserControl
    {
        public TeamControl()
        {
            InitializeComponent();
        }

        Student s;
        List<TeamMembership> teamPreviewList = new List<TeamMembership>();
        TeamViewModel teamVM = new TeamViewModel();
        TeamMembershipViewModel membershipVM = new TeamMembershipViewModel();

        public TeamControl(Student s)
        {
            InitializeComponent();
            this.s = s;
        }

        private void TeamControl_Load(object sender, EventArgs e)
        {
            LoadSocities(s.AridNo);
            LoadStudents();
        }

        public void LoadSocities(string aridNo)
        {
            List<Society> societies = SocietyViewModel.GetSocietiesJoinedByStudent(aridNo);
            cmbSociety.DataSource = societies;
            cmbSociety.ValueMember = "SocietyID";
            cmbSociety.DisplayMember = "Name";
        }

        private void cmbSociety_SelectedIndexChanged(object sender, EventArgs e)
        {
            Society selectedSociety = (Society)cmbSociety.SelectedItem;
            if (selectedSociety != null)
            {
                LoadEvents(selectedSociety.SocietyID);
            }
        }

        public void LoadEvents(int societyId)
        {
            cmbEvents.DataSource = null;
            List<Event> events = EventViewModel.GetUpcomingEventsBySocietyRequireTeam(societyId);
            cmbEvents.DataSource = events;
            cmbEvents.DisplayMember = "Title";
            cmbEvents.ValueMember = "EventID";
        }

        public void LoadStudents()
        {
            List<Student> students = StudentViewModel.GetAllStudents();
            cmbMember.DataSource = students;
            cmbMember.DisplayMember = "Name";
            cmbMember.ValueMember = "AridNo";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aridNo = cmbMember.SelectedValue?.ToString();
            string role = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(aridNo) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select a student and enter a role.");
                return;
            }

            if (role.ToLower() == "leader" && teamPreviewList.Any(m => m.Role.ToLower() == "leader"))
            {
                MessageBox.Show("Only one leader is allowed per team.");
                return;
            }

            if (teamPreviewList.Any(m => m.AridNo == aridNo))
            {
                MessageBox.Show("This student is already added to the team.");
                return;
            }

            teamPreviewList.Add(new TeamMembership
            {
                AridNo = aridNo,
                Role = role
            });

            DisplayTeamPreview();
        }

        private void DisplayTeamPreview()
        {
            string teamName = string.IsNullOrEmpty(textBox1.Text.Trim()) ? "Team Preview" : textBox1.Text.Trim();
            groupBox1.Text = $"Team: {teamName}";
            label6.Text = textBox1.Text;
            flowLayoutPanel1.Controls.Clear();

            foreach (var member in teamPreviewList)
            {
                Student stu = StudentViewModel.GetByAridNo(member.AridNo);

                Label lbl = new Label
                {
                    Location = new Point(54, 111),
                    AutoSize = false,
                    Width = 300,
                    Height = 25,
                    Font = new Font("Segoe UI", 9, FontStyle.Regular),
                    Text = $"{stu.Name} ({member.AridNo}) - {member.Role}",
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(5),
                    Margin = new Padding(3)
                };

                flowLayoutPanel1.Controls.Add(lbl);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (teamPreviewList.Count == 0)
            {
                MessageBox.Show("Team must have members.");
                return;
            }

            if (!teamPreviewList.Any(m => m.Role.ToLower() == "leader"))
            {
                MessageBox.Show("Team must have a leader.");
                return;
            }

            if (cmbEvents.SelectedItem == null)
            {
                MessageBox.Show("Please select an event.");
                return;
            }

            int eventId = ((Event)cmbEvents.SelectedItem).EventID;
            string teamName = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(teamName))
            {
                MessageBox.Show("Please enter a team name.");
                return;
            }

            // Check if any member is already in a team for this event
            foreach (var member in teamPreviewList)
            {
                var existingTeams = TeamViewModel.GetTeamsByEvent(eventId);
                foreach (var team in existingTeams)
                {
                    var existingMembers = membershipVM.GetMembersByTeam(team.TeamID);
                    if (existingMembers.Any(m => m.AridNo == member.AridNo))
                    {
                        MessageBox.Show($"{member.AridNo} is already in a team for this event.");
                        return;
                    }
                }
            }

            // Insert Team
            Team newTeam = new Team
            {
                TeamName = teamName,
                EventID = eventId
            };

            bool added = TeamViewModel.AddTeam(newTeam);
            if (!added)
            {
                MessageBox.Show("Failed to add team.");
                return;
            }

            // Get newly added team
            var createdTeam = TeamViewModel.GetTeamsByEvent(eventId)
                .FirstOrDefault(t => t.TeamName == teamName);

            if (createdTeam == null)
            {
                MessageBox.Show("Error retrieving the newly created team.");
                return;
            }

            // Add members to the team
            foreach (var m in teamPreviewList)
            {
                membershipVM.AddMemberToTeam(new TeamMembership
                {
                    AridNo = m.AridNo,
                    Role = m.Role,
                    TeamID = createdTeam.TeamID
                });
            }

            // Add Event Participation for the Leader
            var leader = teamPreviewList.First(m => m.Role.ToLower() == "leader");
            EventParticipationViewModel.AddParticipation(new EventParticipation
            {
                AridNo = leader.AridNo,
                EventID = eventId,
                Role = "Leader",
                FeePaid = false,
                PaymentDate = DateTime.Now,
                IsDeleted = false
            });

            MessageBox.Show("Team successfully created !\n You can Now Navigate to Event Screen To Particpate in Event With you Team.");

            teamPreviewList.Clear();
            textBox1.Clear();
            textBox2.Clear();
            DisplayTeamPreview();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                if (cmbMember.SelectedItem is Student selectedStudent)
                {
                    var memberToRemove = teamPreviewList.FirstOrDefault(m => m.AridNo == selectedStudent.AridNo);
                    if (memberToRemove != null)
                    {
                        teamPreviewList.Remove(memberToRemove);
                        MessageBox.Show($"Removed {selectedStudent.Name} from team.");
                        DisplayTeamPreview(); // refresh groupbox and flow layout
                    }
                    else
                    {
                        MessageBox.Show("Selected student is not in the team.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a valid student from the dropdown.");
                }
            

        }
    }
}
