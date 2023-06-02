using PdfSharp.Charting;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SportCv.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SportCv.Models
{
    public class PdfModel
    {
        private const int PAGE_WIDTH = 611;
        private const int MARGIN = 10;
        private const int FIELD_HEIGHT = 16;
        private const int FONT_SIZE = 12;


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

            RenderHeader(gfx, header);
            RenderPersonalData(gfx, cv);
            RenderHistory(gfx, cv.History);

            return document;
        }

        private void RenderHeader(XGraphics gfx, Header header)
        {
            XImage image = XImage.FromFile("FPF_HEADER.png");
            gfx.DrawImage(image, 0, 0, PAGE_WIDTH, 120);

            DrawField(gfx, "ENTIDADE", header.ClubName, new XPoint(MARGIN, 130));
            DrawField(gfx, "ÉPOCA", header.Season, new XPoint(MARGIN, 130 + FIELD_HEIGHT * 1.5));
        }

        private void RenderPersonalData(XGraphics gfx, Cv cv)
        {
            var fields = new Dictionary<string, string>();
            fields.Add("NOME", cv.Name);
            fields.Add("EMAIL", cv.Email);

            DrawSection(gfx, "DADOS PESSOAIS", fields, new XPoint(MARGIN, 200));
        }

        private void RenderHistory(XGraphics gfx, IEnumerable<IExperience> history)
        {
            var fields = new Dictionary<string, string>();
            foreach (var experience in history)
            {
                fields.Add($"{experience.Season.StartYear}/{experience.Season.EndYear.ToString().Substring(2)}", experience.FullDescription());
            }

            DrawSection(gfx, "PERCURSO DESPORTIVO", fields, new XPoint(MARGIN, 325));
        }

        private void DrawSection(XGraphics gfx, string sectionLabel, Dictionary<string,string> fields, XPoint point)
        {
            var labelRectangle = new XRect(point.X + MARGIN, point.Y, sectionLabel.Length * FONT_SIZE, FIELD_HEIGHT);
            gfx.DrawRectangle(XPens.Black, XBrushes.Transparent, new XRect(point.X, point.Y + FIELD_HEIGHT / 2, PAGE_WIDTH - point.X - MARGIN, (fields.Count + 1) * FIELD_HEIGHT * 1.5));
            gfx.DrawRectangle(XBrushes.Black, labelRectangle);
            gfx.DrawString(sectionLabel, new XFont("Impact", FONT_SIZE, XFontStyle.Regular), XBrushes.White, labelRectangle, XStringFormat.Center);

            var y = point.Y + FIELD_HEIGHT * 2;
            foreach(var kv in fields) 
            {
                DrawField(gfx, kv.Key, kv.Value, new XPoint(point.X, y));
                y += FIELD_HEIGHT + FIELD_HEIGHT / 2;
            }
        }

        private void DrawField(XGraphics gfx, string fieldLabel, string fieldValue, XPoint point)
        {
            var labelWidth = 100; //fieldLabel.Length * FONT_SIZE;
            var labelRectangle = new XRect(point.X + MARGIN, point.Y, labelWidth , FIELD_HEIGHT);
            var valueRectangle = new XRect(point.X + labelWidth + MARGIN * 2, point.Y, PAGE_WIDTH - (point.X + labelWidth + MARGIN) - MARGIN * 3, FIELD_HEIGHT);

            gfx.DrawRectangle(XBrushes.Black, labelRectangle);
            gfx.DrawString(fieldLabel, new XFont("Impact", FONT_SIZE, XFontStyle.Regular), XBrushes.White, labelRectangle, XStringFormat.Center);
            gfx.DrawRectangle(XPens.Black, XBrushes.Transparent, valueRectangle);
            gfx.DrawString(fieldValue, new XFont("Verdana", FONT_SIZE, XFontStyle.Regular), XBrushes.Black, valueRectangle, XStringFormat.TopLeft);
        }
    }
}
