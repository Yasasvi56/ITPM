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
            Application.Run(new AddLecturer());
            //Application.Run(new AddSubject());
            //Application.Run(new AddSession());
            //Application.Run(new ManageLecturers());
            //Application.Run(new ManageSubjects());
            //Application.Run(new ManageSessions());
            //Application.Run(new UpdateSession());
            //Application.Run(new View());
        }
    }
}
