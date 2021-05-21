using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new WorkingDateAndTimeForm());
            //Application.Run(new UpdateWorkingDateAndTimeForm());
            //Application.Run(new AddLocation());
            //Application.Run(new AddWorkingWeek());
            //Application.Run(new ListWorkingWeek());
            //Application.Run(new AddStudent());
            //Application.Run(new AddTag());
            //Application.Run(new ManageStudent());
            //Application.Run(new ManageTag());
            Application.Run(new Consecutive());
        }
    }
}
