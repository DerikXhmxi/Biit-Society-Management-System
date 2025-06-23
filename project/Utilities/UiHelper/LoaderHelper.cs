using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.Utilities.UiHelper
{
        public static class LoaderHelper
        {
            public static async Task RunWithLoader(Form parent, Func<Task> taskToRun)
            {
                using (var loader = new LoadingForm())
                {
                    var loaderShown = Task.Run(() => loader.ShowDialog(parent));

                         await taskToRun();

                      if (loader.InvokeRequired)
                    {
                        loader.Invoke(new Action(() => loader.Close()));
                    }
                    else
                    {
                        loader.Close();
                    }

                    await loaderShown; 
                }
            }
        }
}
