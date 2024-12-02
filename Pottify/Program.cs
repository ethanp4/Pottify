using System.Runtime.CompilerServices;

namespace Pottify {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var loadingForm = new LoadingForm();
            var mainForm = new Form1();
            mainForm.Load += (object sender, EventArgs e) => { loadingForm.Dispose(); };
            loadingForm.Show();
            Application.Run(mainForm);
        }
    }
}