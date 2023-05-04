using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SportCv.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCv.Models
{
    public class PdfModel
    {
        private CvModel _cvModel;
        public PdfModel(CvModel cvModel)
        {
            _cvModel = cvModel;
        }
        public void Export(string filePath, string clubName)
        {
            var list = _cvModel.GetCvList();
            foreach (var item in list)
            {
                SavePdf(item, filePath, clubName);  
            }

            MessageBox.Show("Ficheiros exportados com sucesso");
        }

        private void SavePdf(Cv item, string filePath, string clubName)
        {
            var document = new PdfDocument();
            var page = document.AddPage();
            var gfx = XGraphics.FromPdfPage(page);
            var font = new XFont("Verdana", 20, XFontStyle.Bold);
            var fileName = filePath + "\\" + item.Name + ".pdf";

            gfx.DrawString(clubName, font, XBrushes.Black, new XRect(100, 100, 500, 50), XStringFormat.Center);
            gfx.DrawString(item.Name, font, XBrushes.Black, new XRect(100, 200, 500, 50), XStringFormat.Center);
            gfx.DrawString(item.Email, font, XBrushes.Black, new XRect(100, 300, 500, 50), XStringFormat.Center);

            document.Save(fileName);
        }
    }
}
