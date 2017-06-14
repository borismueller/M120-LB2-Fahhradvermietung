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
    /// Interaktionslogik für selectKunden.xaml
    /// </summary>
    public partial class selectKunden : UserControl
    {
        private Vermietung vermietung;
        private VermietungEinzelansicht einzelansicht;

        public selectKunden()
        {
            InitializeComponent();
            listeKunden();
        }

        public void listeKunden()
        {
            dg_liste.ItemsSource = Bibliothek.Kunde_Alle();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            //setzte Kunden neu
            vermietung.Kunde = (Kunde)dg_liste.SelectedItem;
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
