using Newtonsoft.Json;
using SportCv.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportCv.Models
{
    public class CvModel
    {
        private List<Cv> _cvList;

        public event Action OnSaveSuccess;

        public CvModel()
        {
            _cvList = new List<Cv>();
        }

        public IEnumerable<Cv> GetAllCvs()
        {
            return _cvList.ToList();
        }

        public Cv GetCv(string cvId)
        {
            var cv = _cvList.FirstOrDefault(c => c.Name == cvId);

            if (cv == null)
            {
                throw new Exception("CV to Edit not found");
            }

            return cv;
        }

        public void SaveCv(Cv cvToSave)
        {
            var cv = _cvList.FirstOrDefault(c => c.Name == cvToSave.Name);

            if (cv != null)
            {
                _cvList.Remove(cv);
            }

            _cvList.Add(cvToSave);

            OnSaveSuccess();
        }

        public void ResetList(IEnumerable<Cv> cvList)
        {
            _cvList = cvList.ToList();
        }
    }
}
