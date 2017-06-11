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
            List<Kunde> kunden = Bibliothek.Kunde_Alle();
            dg_liste.ItemsSource = kunden;
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            //setzte Kunden neu
            Kunde kunde = (Kunde)dg_liste.SelectedItem;
            vermietung.Kunde = kunde;
            this.Visibility = Visibility.Hidden;
            einzelansicht.anzeigen();
        }

        public void setVermietung(int ID)
        {
            this.vermietung = Bibliothek.Vermietung_nach_ID(ID);
        }

        public void setEinzelansicht(VermietungEinzelansicht einzelansicht)
        {
            this.einzelansicht = einzelansicht;
        }
    }
}
