using library.application.daos;
using library.application.forms;
using System;
using System.Windows.Forms;

namespace library {
    static class Program {

        public static BaseDAO dao = new BaseDAO();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LandingForm());
        }

    }
    
}
