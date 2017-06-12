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
        private MainWindow main;
        Vermietung vermietung;

        public VermietungEinzelansicht()
        {
            // Konstruktor für leere ansicht
            InitializeComponent();
        }

        public VermietungEinzelansicht(int vermietungID, MainWindow main)
        {
            // Konstruktor für Ansicht von Element
            InitializeComponent();
            this.vermietung = Bibliothek.Vermietung_nach_ID(vermietungID);
            this.main = main;
            anzeigen();
        }

        public void anzeigen()
        {
            List<Vermietung> ls = new List<Vermietung>();
            ls.Add(vermietung);

            Console.WriteLine("vermietung: " + vermietung.Kunde);

            dg_vermietung.ItemsSource = ls;
            dg_vermietung.Visibility = Visibility.Visible;
        }

        private void neueVermietung(object sender, RoutedEventArgs e)
        {
            btn_neu.Visibility = Visibility.Hidden;
            btn_save.Visibility = Visibility.Visible;

            this.vermietung = new Vermietung();
            anzeigen();
        }

        private void speichernVermietung(object sender, RoutedEventArgs e)
        {
            Bibliothek.Vermietung_Neu(vermietung);
        }

        private void updateVermietung(object sender, DataGridCellEditEndingEventArgs e)
        {
            Console.WriteLine("update");

            var column = e.Column as DataGridBoundColumn;
            if (column != null)
            {
                //Kunde und Fahrrad können nicht falsch sein und werden nicht überprüft

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
                        vermietung.Start = date;
                        el.Background = Brushes.LightCyan;
                    }
                    else el.Background = Brushes.IndianRed;
                } if (bindingPath.Equals("Ende"))
                {
                    DateTime date;
                    if (DateTime.TryParse(el.Text, out date))
                    {
                        //setzte das Datum neu
                        vermietung.Ende = date;
                        el.Background = Brushes.LightCyan;
                    }
                    else el.Background = Brushes.IndianRed;
                }
            }
        }

        private void kunde_select(object sender, SelectionChangedEventArgs e)
        {
            //TODO:
            Console.WriteLine("yo");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            main.init();
        }

        private void btn_kunde(object sender, RoutedEventArgs e)
        {
            uc_selectKunden.Visibility = Visibility.Visible;
            dg_vermietung.Visibility = Visibility.Hidden;
            uc_selectKunden.setVermietung(vermietung);
            uc_selectKunden.setEinzelansicht(this);
        }

        private void btn_fahrrad(object sender, RoutedEventArgs e)
        {
            uc_selectFahrrad.Visibility = Visibility.Visible;
            dg_vermietung.Visibility = Visibility.Hidden;
            uc_selectFahrrad.setVermietung(vermietung);
            uc_selectFahrrad.setEinzelansicht(this);
        }
    }
}
