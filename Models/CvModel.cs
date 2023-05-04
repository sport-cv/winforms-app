using Newtonsoft.Json;
using SportCv.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCv.Models
{
    public class CvModel
    {
        private List<Cv> _cvList;
        private Cv _cvToEdit;

        public event Action CvWasSavedWithSuccess;
        public event Action CvToEditLoaded;

        public CvModel()
        {
            _cvList = new List<Cv>();
        }

        public bool LoadCvData(string data)
        {
            _cvList = JsonConvert.DeserializeObject<List<Cv>>(data);

            return _cvList.Count > 0;
        }

        public IEnumerable<Cv> GetCvList()
        {
            return _cvList.ToList();
        }

        public Cv GetCvToEdit()
        {
            return _cvToEdit;
        }

        public void SaveCv(Cv cv)
        {
            _cvList.Add(cv);
            CvWasSavedWithSuccess();
        }

        public void LoadCvToEdit(string name)
        {
            _cvToEdit = _cvList.FirstOrDefault(cv => cv.Name == name);

            if(_cvToEdit == null)
            {
                throw new Exception("CV to Edit not found");
            }

            CvToEditLoaded();
        }
    }
}
