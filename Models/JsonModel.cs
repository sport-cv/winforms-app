using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    Converters = new List<JsonConverter> { new ExperienceConverter() }
                };
                var list = JsonConvert.DeserializeObject<IEnumerable<Cv>>(jsonText, settings);
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


    private class ExperienceConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return typeof(IExperience).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);
            string role = jsonObject["Role"]?.ToString();

            switch (role)
            {
                case "Jogador":
                    return JsonConvert.DeserializeObject<PlayerExperience>(jsonObject.ToString());
                case "Treinador":
                    return JsonConvert.DeserializeObject<CoachExperience>(jsonObject.ToString());
                case "Diretor":
                    return JsonConvert.DeserializeObject<StaffExperience>(jsonObject.ToString());
                default:
                    throw new NotSupportedException($"Não é possível converter experiência para {role}");
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
    }
}
