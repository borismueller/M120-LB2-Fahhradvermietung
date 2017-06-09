using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M120_LB2_FS17
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            datenBereitstellen();
            listenansicht();
        }

        #region Testdaten
        private void datenBereitstellen()
        {
            demoDatenFahrrad();
            demoDatenKunde();
            demoDatenVermietungen();
        }
        private void demoDatenFahrrad()
        {
            Fahrrad fr1 = new Fahrrad();
            fr1.Hersteller = "Scott";
            fr1.Modell = "MZ10";
            fr1.IstAktiv = true;
            fr1.Farbe = Colors.Aqua;
            Bibliothek.Fahrrad_Neu(fr1);

            Fahrrad fr2 = new Fahrrad();
            fr2.Hersteller = "Tour de Suisse";
            fr2.Modell = "Elektro City";
            fr2.IstAktiv = true;
            fr2.Farbe = Colors.BlanchedAlmond;
            Bibliothek.Fahrrad_Neu(fr2);
        }
        private void demoDatenKunde()
        {
            Kunde k1 = new Kunde();
            k1.Name = "Antener";
            k1.Vorname = "Alfons";
            k1.IstAktiv = true;
            k1.KundeSeit = new DateTime(2016, 3, 1);
            k1.TotalStundenVermietungen = 0;
            k1.AnzahlVermietungen = 0;
            k1.Farbe = Colors.Violet;
            Bibliothek.Kunde_Neu(k1);

            Kunde k2 = new Kunde();
            k2.Name = "Bieri";
            k2.Vorname = "Boris";
            k2.IstAktiv = true;
            k2.KundeSeit = new DateTime(2016, 4, 2);
            k2.TotalStundenVermietungen = 0;
            k2.AnzahlVermietungen = 0;
            k2.Farbe = Colors.Yellow;
            Bibliothek.Kunde_Neu(k2);
        }
        private void demoDatenVermietungen()
        {
            Vermietung v1 = new Vermietung();
            v1.Fahrrad = Bibliothek.Fahrrad_nach_ID(1);
            v1.Kunde = Bibliothek.Kunde_nach_ID(1);
            v1.Start = new DateTime(2017, 6, 7, 8, 0, 0);
            v1.Ende = new DateTime(2017, 6, 7, 15, 0, 0);
            Bibliothek.Vermietung_Neu(v1);

            Vermietung v2 = new Vermietung();
            v2.Fahrrad = Bibliothek.Fahrrad_nach_ID(1);
            v2.Kunde = Bibliothek.Kunde_nach_ID(2);
            v2.Start = new DateTime(2017, 6, 10, 11, 0, 0);
            v2.Ende = new DateTime(2017, 6, 10, 18, 0, 0);
            Bibliothek.Vermietung_Neu(v2);

            Vermietung v3 = new Vermietung();
            v3.Fahrrad = Bibliothek.Fahrrad_nach_ID(2);
            v3.Kunde = Bibliothek.Kunde_nach_ID(1);
            v3.Start = new DateTime(2017, 6, 14, 10, 0, 0);
            v3.Ende = new DateTime(2017, 6, 14, 14, 0, 0);
            Bibliothek.Vermietung_Neu(v3);

            Vermietung v4 = new Vermietung();
            v4.Fahrrad = Bibliothek.Fahrrad_nach_ID(2);
            v4.Kunde = Bibliothek.Kunde_nach_ID(1);
            v4.Start = new DateTime(2017, 6, 15, 10, 0, 0);
            v4.Ende = new DateTime(2017, 6, 15, 14, 0, 0);
            Bibliothek.Vermietung_Neu(v4);
        }

        #endregion

        private void listenansicht()
        {
            List<Vermietung> vermietungen = Bibliothek.Vermietung_Alle();

            List<dynamic> listeVermietung = new List<dynamic>();

            foreach (Vermietung v in vermietungen)
            {
                //dynamisches Objekt das alle Daten der Vermietung + Dauer speichert
                dynamic vm = new System.Dynamic.ExpandoObject();
                vm.ID = v.ID;
                vm.Start = v.Start;
                vm.Ende = v.Ende;
                vm.Kunde = v.Kunde;
                vm.Fahrrad = v.Fahrrad;
                vm.Dauer = v.getDauer();
                listeVermietung.Add(vm);
                Console.WriteLine("Vermietung: " + v);
                Console.WriteLine("Von: " + v.Start);
                Console.WriteLine("Bis: " + v.Ende);
                Console.WriteLine("Kunde: " + v.Kunde.Name);
                Console.WriteLine("Fahrrad: " + v.Fahrrad.Modell);
                Console.WriteLine("Dauer: " + v.getDauer());
            }

            lb_vermietung.ItemsSource = listeVermietung;
        }

        private void lb_vermietung_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine("yo " + sender + e);
            dynamic d = lb_vermietung.SelectedItem;
            Console.WriteLine("d: "+d.Kunde.Name);

            UserControl vermietungEinzelansicht = new VermietungEinzelansicht(d);
            //container = null;
            this.Content = vermietungEinzelansicht;
        }
    }
}
