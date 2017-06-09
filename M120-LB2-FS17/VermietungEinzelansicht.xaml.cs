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
    /// Interaktionslogik für VermietungEinzelansicht.xaml
    /// </summary>
    public partial class VermietungEinzelansicht : UserControl
    {
        private dynamic vermietung; //das vermietungs objekt das dargestellt / verändert wird
        private MainWindow main;
        Vermietung v; //TODO 

        public VermietungEinzelansicht()
        {
            // Konstruktor für leere ansicht
            InitializeComponent();
        }

        public VermietungEinzelansicht(dynamic v, MainWindow main)
        {
            // Konstruktor für Ansicht von Element
            //TODO: besserer Code, nur id mitgeben
            InitializeComponent();
            this.vermietung = v;
            this.main = main;
            anzeigen();
        }

        public void anzeigen()
        {
            //TODO: besserer Code, nur id mitgeben, Name direkt anzeigen

            v = Bibliothek.Vermietung_nach_ID(vermietung.ID);
            List<Vermietung> ls = new List<Vermietung>();
            ls.Add(v);

            dg_vermietung.ItemsSource = ls;

            //Kunden
            List<Kunde> kunden = Bibliothek.Kunde_Alle();
            List<String> listeNamen = new List<String>();
            foreach (Kunde k in kunden) {
                listeNamen.Add(k.Name);
            }
            Kunde.ItemsSource = listeNamen;

            //Fahrrad
            List <Fahrrad> fahrradz = Bibliothek.Fahrrad_Alle();
            List<dynamic> listeModell = new List<dynamic>();
            foreach (Fahrrad f in fahrradz)
            {
                listeModell.Add(f.Modell);
            }
            Fahrrad.ItemsSource = listeModell;
        }

        private void neueVermietung(object sender, RoutedEventArgs e)
        {
            //TODO: 
            Console.WriteLine("TODO");
        }

        private void updateVermietung(object sender, DataGridCellEditEndingEventArgs e)
        {
            Console.WriteLine("update");

            var column = e.Column as DataGridBoundColumn;
            if (column != null)
            {
                //TODO: Andere Werte

                Console.WriteLine(column);
                var bindingPath = (column.Binding as Binding).Path.Path;
                int rowIndex = e.Row.GetIndex();
                var el = e.EditingElement as TextBox;

                if (bindingPath.Equals("Start"))
                {
                    DateTime date;
                    if (DateTime.TryParse(el.Text, out date))
                    {
                        //setzte das Datum neu
                        v.Start = date;
                        el.Background = Brushes.LightCyan;
                    }
                    else el.Background = Brushes.IndianRed;
                } if (bindingPath.Equals("Ende"))
                {
                    DateTime date;
                    if (DateTime.TryParse(el.Text, out date))
                    {
                        //setzte das Datum neu
                        v.Ende = date;
                        el.Background = Brushes.LightCyan;
                    }
                    else el.Background = Brushes.IndianRed;
                }
            }
        }

        private void kunde_select(object sender, SelectionChangedEventArgs e)
        {
            //TODO:
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            main.init();
        }
    }
}
