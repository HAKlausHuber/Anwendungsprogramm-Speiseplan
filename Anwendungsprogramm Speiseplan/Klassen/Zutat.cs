using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anwendungsprogramm_Speiseplan.Klassen
{
    public class Zutat
    {
        private string bezeichnung;
        private string einheit;

        public Zutat()
        {

        }

        public Zutat(string bezeichnung, string einheit)
        {
            this.bezeichnung = bezeichnung;
            this.einheit = einheit;
        }

        public string Bezeichnung { get; set; }

        public string Beschreibung { get; set; }

        public string Einheit { get; set; }
    }
}
