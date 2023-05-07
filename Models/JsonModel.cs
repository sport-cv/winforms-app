using Newtonsoft.Json;
using SportCv.Entities;
using SportCv.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            // Tenta desserializar a string em uma lista de objetos Cv
            try
            {
                var list = JsonConvert.DeserializeObject<IEnumerable<Cv>>(jsonText);
                // Se chegou aqui sem gerar exceção, a estrutura do JSON é compatível com a lista de objetos Cv

                if (list.Count() == 0)
                {
                    throw new EmptyListException("Não foram carregados Cvs.");
                }

                _cvModel.ResetList(list);
                OnFileLoaded();
            }
            catch (JsonException ex)
            {
                // Se gerou exceção, a estrutura do JSON não é compatível com a lista de objetos Cv
                MessageBox.Show("Erro ao desserializar JSON: " + ex.Message);
            }

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
