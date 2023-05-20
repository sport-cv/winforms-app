using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCv.Entities
{
    public class Cv
    {
        public Cv()
        {
            History = new List<IExperience>();    
        }

        public string Name { get; set; }
        public string Email { get; set; }

        public IEnumerable<IExperience> History { get; set; }
    }
}
