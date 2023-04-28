using Newtonsoft.Json;
using SportCv.Enitities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SportCv.Models
{
    public class FileModel
    {
        private readonly CvModel _cvModel;

        public event Action FileLoaded;

        public FileModel(CvModel cvModel)
        {
            _cvModel = cvModel;
        }

        public void ReadFile(string filePath)
        {
            var jsonText = File.ReadAllText(filePath);
            
            if(_cvModel.LoadCvData(jsonText))
            {
                FileLoaded();
            }
        }
    }
}
