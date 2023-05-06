using Newtonsoft.Json;
using SportCv.Entities;
using SportCv.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SportCv.Models
{
    public class JsonModel
    {
        private readonly CvModel _cvModel;

        public event Action OnFileLoaded;
        public event Action OnFileSaved;

        public JsonModel(CvModel cvModel)
        {
            _cvModel = cvModel;
        }

        public void ReadFile(string filePath)
        {
            var jsonText = File.ReadAllText(filePath);
            var list = JsonConvert.DeserializeObject<IEnumerable<Cv>>(jsonText);

            if (list.Count() == 0)
            {
                throw new EmptyListException("Não foram carregados Cvs.");
            }

            _cvModel.ResetList(list);                
            OnFileLoaded();
        }

        public void WriteFile(string fileName)
        {
            var list = _cvModel.GetAllCvs();
            var json = JsonConvert.SerializeObject(list);

            File.WriteAllText(fileName, json);

            OnFileSaved();
        }
    }
}
