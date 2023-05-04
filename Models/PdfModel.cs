using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SportCv.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SportCv.Models
{
    public class PdfModel
    {
        public event Action OnPdfSaved;

        private CvModel _cvModel;
        public PdfModel(CvModel cvModel)
        {
            _cvModel = cvModel;
        }
        public void ExportCvToPdf(IEnumerable<string> idsToExport, Header header, string path)
        {
            
            foreach (var id in idsToExport)
            {
                var cv = _cvModel.GetCv(id);
                var document = CreatePdfFromCv(cv, header);
                var fileName = path.EndsWith(".pdf") ? path : $"{path}\\{cv.Name}.pdf";
                document.Save(fileName);
            }

            OnPdfSaved();
        }

        private PdfDocument CreatePdfFromCv(Cv cv, Header header)
        {
            
            var document = new PdfDocument();
            var page = document.AddPage();
            var gfx = XGraphics.FromPdfPage(page);
            var font = new XFont("Verdana", 20, XFontStyle.Bold);

            gfx.DrawString(header.ClubName, font, XBrushes.Black, new XRect(100, 100, 500, 50), XStringFormat.Center);
            gfx.DrawString(cv.Name, font, XBrushes.Black, new XRect(100, 200, 500, 50), XStringFormat.Center);
            gfx.DrawString(cv.Email, font, XBrushes.Black, new XRect(100, 300, 500, 50), XStringFormat.Center);

            return document;
        }
    }
}
