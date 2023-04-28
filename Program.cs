using SportCv.Controller;
using SportCv.Models;
using SportCv.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCv
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainView = new MainView();

            var cvModel = new CvModel();
            var fileModel = new FileModel(cvModel);

            var mainController = new MainController(mainView, fileModel, cvModel);
            var cvController = new CvController(mainView);

            mainController.Execute();

            Application.Run(mainView);
        }
    }
}
