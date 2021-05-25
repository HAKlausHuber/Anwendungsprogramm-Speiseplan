using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anwendungsprogramm_Speiseplan.Properties
{
    class Zutat
    {
        private int zid;
        private string bezeichnung;
        private string beschreibung;
        private string einheit;

        public Zutat(int zid, string bezeichnung, string beschreibung, string einheit)
        {

            this.bezeichnung = bezeichnung;
            this.beschreibung = beschreibung;
            this.einheit = einheit;
        }

        public string Bezeichnung { get; set; }

        public string Beschreibung { get; set; }

        public string Einheit { get; set; }

    }
}
