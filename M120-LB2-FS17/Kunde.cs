using System;
using System.Collections.Generic;
using System.Windows.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120_LB2_FS17
{
    class Kunde
    {
        public Int32 ID { get; set; }
        public String Name { get; set; }
        public String Vorname { get; set; }
        public DateTime KundeSeit { get; set; }
        public Double AnzahlVermietungen { get; set; }
        public Double TotalStundenVermietungen { get; set; }
        public Boolean IstAktiv { get; set; }
        public Color Farbe { get; set; } //nice
        public List<Vermietung> Vermietungen { get; set; }

        public Kunde()
        {
            Vermietungen = new List<Vermietung>();
        }
        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
