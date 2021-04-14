using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimManagementForm_301178688
{
    /// <summary>
    /// Kelvin Ong -301178688
    /// Raghav Thakkar 301150074
    /// Neha Fatima- 301179066
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSwimManagement());
        }
    }
}
