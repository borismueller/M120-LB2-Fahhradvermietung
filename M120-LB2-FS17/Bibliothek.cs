using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M120_LB2_FS17
{
    static class Bibliothek
    {
        private static List<Fahrrad> Fahrrad { get; set; }
        private static List<Kunde> Kunde { get; set; }
        private static List<Vermietung> Vermietungen { get; set; }
        private static Int32 IDFahrrad = 1;
        private static Int32 IDKunden = 1;
        private static Int32 IDVermietungen = 1;
        #region Fahrrad
        public static void Fahrrad_Neu(Fahrrad fahrrad)
        {
            if (Fahrrad == null)
            {
                Fahrrad = new List<Fahrrad>();
            }
            if (fahrrad.ID == 0)
            {
                fahrrad.ID = IDFahrrad;
                IDFahrrad++;
            }
            Fahrrad.Add(fahrrad);
        }
        public static List<Fahrrad> Fahrrad_Alle()
        {
            return Fahrrad;
        }
        public static Fahrrad Fahrrad_nach_ID(Int32 id)
        {
            return (from element in Fahrrad where element.ID == id select element).FirstOrDefault();
        }
        #endregion
        #region Kunde
        public static void Kunde_Neu(Kunde kunde)
        {
            if (Kunde == null)
            {
                Kunde = new List<Kunde>();
            }
            if (kunde.ID == 0)
            {
                kunde.ID = IDKunden;
                IDKunden++;
            }
            Kunde.Add(kunde);
        }
        public static List<Kunde> Kunde_Alle()
        {
            return Kunde;
        }
        public static Kunde Kunde_nach_ID(Int32 id)
        {
            return (from element in Kunde where element.ID == id select element).FirstOrDefault();
        }
        #endregion
        #region Vermietung
        public static void Vermietung_Neu(Vermietung vermietung)
        {
            if (Vermietungen == null)
            {
                Vermietungen = new List<Vermietung>();
            }
            if (vermietung.ID == 0)
            {
                vermietung.ID = IDVermietungen;
                IDVermietungen++;
            }
            Vermietungen.Add(vermietung);
            // Anzahl nachtragen
            vermietung.Kunde.AnzahlVermietungen++;
            // Total Stunden nachtragen
            vermietung.Kunde.TotalStundenVermietungen = vermietung.Kunde.TotalStundenVermietungen + vermietung.Ende.Subtract(vermietung.Start).TotalHours;
            // Liste Vermietungen nachtragen
            Kunde_nach_ID(vermietung.Kunde.ID).Vermietungen.Add(vermietung);
        }
        public static List<Vermietung> Vermietung_Alle()
        {
            return Vermietungen;
        }
        public static Vermietung Vermietung_nach_ID(Int32 id)
        {
            return (from element in Vermietungen where element.ID == id select element).FirstOrDefault();
        }
        public static List<Vermietung> Vermietung_an_Datum(DateTime tag)
        {
            return (from element in Vermietungen where element.Start > tag.AddDays(-1) && element.Start < tag.AddDays(1) select element).ToList();
        }
        #endregion
    }
}
