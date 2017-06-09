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
        Vermietung v; //TODO 

        public VermietungEinzelansicht()
        {
            // Konstruktor für leere ansicht
            InitializeComponent();
        }

        public VermietungEinzelansicht(dynamic v)
        {
            // Konstruktor für Ansicht von Element
            //TODO: besserer Code, nur id mitgeben
            InitializeComponent();
            this.vermietung = v;
            anzeigen();
        }

        public void anzeigen()
        {
            //TODO: besserer Code, nur id mitgeben
            Console.WriteLine("\n\n\n " + vermietung.Kunde.Name);

            v = Bibliothek.Vermietung_nach_ID(vermietung.ID);
            List<Vermietung> ls = new List<Vermietung>();
            ls.Add(v);

            dg_vermietung.ItemsSource = ls;
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
                    }
                } if (bindingPath.Equals("Ende"))
                {
                    DateTime date;
                    if (DateTime.TryParse(el.Text, out date))
                    {
                        //setzte das Datum neu
                        v.Ende = date;
                    }
                }

                Console.WriteLine(el);
            }
        }
    }
}
