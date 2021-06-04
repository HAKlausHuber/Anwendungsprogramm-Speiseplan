using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anwendungsprogramm_Speiseplan.Klassen;

namespace Anwendungsprogramm_Speiseplan.Klassen
{
    public class Speise
    {
        private string bezeichnung;
        private string beschreibung;
        private string einheit;
        private List<Zutat> zutaten;
        private List<Allergene> allergene;

        //private int stern5;
        //private int stern4;
        //private int stern3;
        //private int stern2;
        //private int stern1;

        public Speise()
        {

        }

        public Speise(int sid, string bezeichnung, string beschreibung, string einheit)
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
