using System;
using System.Windows.Media;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120_LB2_FS17
{
    class Vermietung
    {
        public Int32 ID { get; set; }
        public DateTime Start { get; set; }
        public DateTime Ende { get; set; }
        public Fahrrad Fahrrad { get; set; }
        public Kunde Kunde { get; set; }
        public Color Farbe { get; set; }
        public Vermietung()
        {

        }

        public TimeSpan getDauer()
        {
            return Ende.Subtract(Start);
        }
        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
