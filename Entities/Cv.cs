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
            History = new List<IExperience>()
            {
                new PlayerExperience(new Season { StartYear = 1999, EndYear =2000}, "FCF", 10, 30),
                new PlayerExperience(new Season { StartYear = 2001, EndYear =2002}, "FCF", 17, 25),
            };    
        }

        public string Name { get; set; }
        public string Email { get; set; }

        public IEnumerable<IExperience> History { get; set; }
    }
}
