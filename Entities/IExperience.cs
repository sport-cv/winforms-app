using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportCv.Entities
{
    public interface IExperience
    {
        Season Season { get; set; }
        String Club { get; set; }
        String Role { get; set; }
        String ShortDescription();
        String FullDescription();
        ListViewItem ToListViewItem();
    }
}
