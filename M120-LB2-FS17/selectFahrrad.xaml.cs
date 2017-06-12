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
    /// Interaktionslogik für selectFahrrad.xaml
    /// </summary>
    public partial class selectFahrrad : UserControl
    {
        private Vermietung vermietung;
        private VermietungEinzelansicht einzelansicht;

        public selectFahrrad()
        {
            InitializeComponent();
            listeFahrrad();
        }

        public void listeFahrrad()
        {
            dg_liste.ItemsSource = Bibliothek.Fahrrad_Alle();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            //setzte Fahrrad neu
            vermietung.Fahrrad = (Fahrrad)dg_liste.SelectedItem;
            this.Visibility = Visibility.Hidden;
            einzelansicht.anzeigen();
        }

        public void setVermietung(Object v)
        {
            this.vermietung = (Vermietung)v;
        }

        public void setEinzelansicht(VermietungEinzelansicht einzelansicht)
        {
            this.einzelansicht = einzelansicht;
        }
    }
}
