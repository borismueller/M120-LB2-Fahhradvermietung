using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120_LB2_FS17
{
    class Fahrrad
    {
        public Int32 ID { get; set; }
        public String Hersteller { get; set; }
        public String Modell { get; set; }
        public Boolean IstAktiv { get; set; }
        public Image Bild { get; set; }
        public Color Farbe { get; set; }
        public Fahrrad()
        {

        }
        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
