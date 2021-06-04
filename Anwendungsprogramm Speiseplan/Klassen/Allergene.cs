using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anwendungsprogramm_Speiseplan.Klassen
{
    public class Allergene
    {
        private string bezeichnung;
       
        public Allergene()
        {

        }

        public Allergene(string bezeichnung)
        {
            this.bezeichnung = bezeichnung;            
        }

        public string Bezeichnung { get; set; }
    }
}
