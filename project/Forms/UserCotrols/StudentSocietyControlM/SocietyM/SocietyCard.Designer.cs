namespace project.Forms.StudentSocietyControlM
{
    partial class SocietyCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSocietyTitle = new System.Windows.Forms.Label();
            this.pictBoxSocietyLogo = new System.Windows.Forms.PictureBox();
            this.lblNoOfMember = new System.Windows.Forms.Label();
            this.lblMentorName = new System.Windows.Forms.Label();
            this.lblPresidentname = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLeaveSociety = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxSocietyLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(116, 220);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description ";
            // 
            // lblSocietyTitle
            // 
            this.lblSocietyTitle.AutoSize = true;
            this.lblSocietyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocietyTitle.Location = new System.Drawing.Point(113, 178);
            this.lblSocietyTitle.Name = "lblSocietyTitle";
            this.lblSocietyTitle.Size = new System.Drawing.Size(146, 29);
            this.lblSocietyTitle.TabIndex = 7;
            this.lblSocietyTitle.Text = "Society Title";
            // 
            // pictBoxSocietyLogo
            // 
            this.pictBoxSocietyLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictBoxSocietyLogo.Image = global::project.Properties.Resources._20944371;
            this.pictBoxSocietyLogo.Location = new System.Drawing.Point(0, 0);
            this.pictBoxSocietyLogo.Name = "pictBoxSocietyLogo";
            this.pictBoxSocietyLogo.Size = new System.Drawing.Size(355, 165);
            this.pictBoxSocietyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBoxSocietyLogo.TabIndex = 6;
            this.pictBoxSocietyLogo.TabStop = false;
            // 

            // lblNoOfMember
            // 
            this.lblNoOfMember.AutoSize = true;
            this.lblNoOfMember.Location = new System.Drawing.Point(114, 258);
            this.lblNoOfMember.Name = "lblNoOfMember";
            this.lblNoOfMember.Size = new System.Drawing.Size(129, 20);
            this.lblNoOfMember.TabIndex = 10;
            this.lblNoOfMember.Text = "No of Members : ";
            // 
            // lblMentorName
            // 
            this.lblMentorName.AutoSize = true;
            this.lblMentorName.Location = new System.Drawing.Point(114, 288);
            this.lblMentorName.Name = "lblMentorName";
            this.lblMentorName.Size = new System.Drawing.Size(71, 20);
            this.lblMentorName.TabIndex = 11;
            this.lblMentorName.Text = "Mentor : ";
            // 
            // lblPresidentname
            // 
            this.lblPresidentname.AutoSize = true;
            this.lblPresidentname.Location = new System.Drawing.Point(114, 319);
            this.lblPresidentname.Name = "lblPresidentname";
            this.lblPresidentname.Size = new System.Drawing.Size(88, 20);
            this.lblPresidentname.TabIndex = 12;
            this.lblPresidentname.Text = "President : ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 422);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 256);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btnLeaveSociety
            // 
            this.btnLeaveSociety.ForeColor = System.Drawing.Color.Red;
            this.btnLeaveSociety.Location = new System.Drawing.Point(249, 346);
            this.btnLeaveSociety.Name = "btnLeaveSociety";
            this.btnLeaveSociety.Size = new System.Drawing.Size(100, 35);
            this.btnLeaveSociety.TabIndex = 15;
            this.btnLeaveSociety.Text = "Leave";
            this.btnLeaveSociety.UseVisualStyleBackColor = true;
            this.btnLeaveSociety.Click += new System.EventHandler(this.btnLeaveSociety_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 34);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Events";
            // 
            // SocietyCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLeaveSociety);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblPresidentname);
            this.Controls.Add(this.lblMentorName);
            this.Controls.Add(this.lblNoOfMember);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblSocietyTitle);
            this.Controls.Add(this.pictBoxSocietyLogo);
            this.Name = "SocietyCard";
            this.Size = new System.Drawing.Size(355, 678);
            this.Load += new System.EventHandler(this.SocietyCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxSocietyLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSocietyTitle;
        private System.Windows.Forms.PictureBox pictBoxSocietyLogo;
        private System.Windows.Forms.Label lblNoOfMember;
        private System.Windows.Forms.Label lblMentorName;
        private System.Windows.Forms.Label lblPresidentname;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnLeaveSociety;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
