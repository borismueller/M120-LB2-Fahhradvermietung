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
        private Window main;

        public Kalender()
        {
            InitializeComponent();
        }

        public Kalender(Window main)
        {
            InitializeComponent();
            this.main = main;
            init();
        }

        public void init()
        {
            /*List<Vermietung> vermietugnen = Bibliothek.Vermietung_Alle();
            
            foreach (Vermietung v in vermietugnen) {
                c.BlackoutDates.Add(new CalendarDateRange(
                   v.Start, v.Ende
                   ));
            }*/

            //Hole ersten Wochentag
            DateTime firstDay = DateTime.Now.AddDays(-(DateTime.Now.DayOfWeek - CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek));

            monday.DataContext = firstDay.ToShortDateString();
            tuesday.DataContext = firstDay.AddDays(1).ToShortDateString();
            wednesday.DataContext = firstDay.AddDays(2).ToShortDateString();
            thursday.DataContext = firstDay.AddDays(3).ToShortDateString();
            friday.DataContext = firstDay.AddDays(4).ToShortDateString();
            saturday.DataContext = firstDay.AddDays(5).ToShortDateString();
            sunday.DataContext = firstDay.AddDays(6).ToShortDateString();

            switch (DateTime.Today.DayOfWeek.ToString())
            {
                case "Monday":
                    monday.Background = Brushes.LightGray;
                    break;
                case "Tuesday":
                    tuesday.Background = Brushes.LightGray;
                    break;
                case "Wednesday":
                    wednesday.Background = Brushes.LightGray;
                    break;
                case "Thursday":
                    thursday.Background = Brushes.LightGray;
                    break;
                case "Friday":
                    friday.Background = Brushes.LightGray;
                    break;
                case "Saturday":
                    saturday.Background = Brushes.LightGray;
                    break;
                case "Sunday":
                    sunday.Background = Brushes.LightGray;
                    break;
            }

            //TODO: if (monday.DataContext.Equals(Bibilo.vermietung_an_datum(monday.DataContext.ToDate) {stuff
        }
    }
}
