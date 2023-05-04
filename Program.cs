using SportCv.Controllers;
using SportCv.Models;
using SportCv.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCv
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var cvModel = new CvModel();
            var fileModel = new JsonModel(cvModel);
            var pdfModel = new PdfModel(cvModel);

            var mainView = new MainView(cvModel);
            var cvView = new CvView(cvModel);
            var pdfView = new PdfView();


            var mainController = new MainController(mainView, fileModel);
            _ = new CvController(cvView, cvModel, mainView);
            _ = new PdfController(pdfView, pdfModel, mainView, cvView);

            mainController.Execute();

            Application.Run(mainView);
        }
    }
}
