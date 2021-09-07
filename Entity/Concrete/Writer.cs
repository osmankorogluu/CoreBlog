using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Writer
    {
        public int WriteID { get; set; }
        public string WriteName { get; set; }
        public string WriteAbout { get; set; }
        public string WriteImage { get; set; }
        public string WriteMail { get; set; }
        public string WritePassword { get; set; }
        public bool WriteStatus { get; set; }
    }
}
