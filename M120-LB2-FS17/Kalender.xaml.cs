using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaktionslogik für Kalender.xaml
    /// </summary>
    public partial class Kalender : UserControl
    {
        private MainWindow main;
        private DateTime ersterTag; //montag der angzeigte woche

        public Kalender()
        {
            InitializeComponent();
        }

        public Kalender(MainWindow main)
        {
            InitializeComponent();
            this.main = main;
            this.ersterTag = DateTime.Now.AddDays(-(DateTime.Now.DayOfWeek - CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek));
            init();
        }

        public void init()
        {
            //TODO: besserer Code, weniger switch-shit

            TextBlock[] wochentage = { monday, tuesday, wednesday, thursday, friday, saturday, sunday };
            Button[] wochenButtons = { btn_monday, btn_tuesday, btn_wednesday, btn_thursday, btn_friday, btn_saturday, btn_sunday };

            for (int i=0; i<wochentage.Length; i++)
            {
                //Daten anzeigen & Tage zurücksetzten
                wochentage[i].DataContext = ersterTag.AddDays(i).ToShortDateString();
                wochentage[i].Background = Brushes.White;
            }

            for (int i=0; i<wochenButtons.Length; i++)
            {
                //reset
                wochenButtons[i].Visibility = Visibility.Hidden;
            }

            for (int i = 0; i < wochentage.Length; i++)
            {
                List<Vermietung> vermietungen = Bibliothek.Vermietung_an_Datum(ersterTag.AddDays(i));
                if (vermietungen.Count != 0)
                {
                    //an wochentage[i] gibt es eine Vermietung
                    wochentage[i].Background = Brushes.DarkCyan;
                    Button btn;
                    switch (i)
                    {
                        case 0:
                            btn = btn_monday;
                            break;
                        case 1:
                            btn = btn_tuesday;
                            break;
                        case 2:
                            btn = btn_wednesday;
                            break;
                        case 3:
                            btn = btn_thursday;
                            break;
                        case 4:
                            btn = btn_friday;
                            break;
                        case 5:
                            btn = btn_saturday;
                            break;
                        case 6:
                            btn = btn_sunday;
                            break;
                        default:
                            //sollte eigentlich nie passieren, der Compiler ist aber nicht schlau genug das zu merken
                            btn = null;
                            break;
                    }
                    btn.Visibility = Visibility.Visible;
                    btn.Content = vermietungen[0].ID;
                }
            }

            //heutiger Tag markieren
            for (int i = 0; i < wochentage.Length; i++)
            {
                if (DateTime.Today.ToShortDateString().Equals(wochentage[i].DataContext))
                {
                    wochentage[i].Background = Brushes.Honeydew;
                }
            }

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int id = int.Parse(btn.Content.ToString());
            VermietungEinzelansicht einzelansicht = new VermietungEinzelansicht(id, main);
            main.mainContentControl.Content = einzelansicht;
            einzelansicht.anzeigen();
        }

        private void vor(object sender, RoutedEventArgs e)
        {
            //woche vor
            this.ersterTag = ersterTag.AddDays(7);
            init();
        }

        private void zurueck(object sender, RoutedEventArgs e)
        {
            //woche zurück
            this.ersterTag = ersterTag.AddDays(-7);
            init();
        }
    }
}
