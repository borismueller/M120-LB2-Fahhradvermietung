﻿using System;
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
        private bool fehler;
        Vermietung vermietung;

        public VermietungEinzelansicht()
        {
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

            dg_vermietung.ItemsSource = ls;
            dg_vermietung.Visibility = Visibility.Visible;
            if (fehler) dg_vermietung.Background = Brushes.Salmon;
            else dg_vermietung.Background = Brushes.White;
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
            foreach (Vermietung v in Bibliothek.Vermietung_Alle()) {
                if (v.Start.DayOfYear != vermietung.Start.DayOfYear)
                {
                    break; //Nicht am selben Tag
                } else
                {
                    int start = v.Start.Hour;
                    int ende = v.Ende.Hour;
                    if (start <= vermietung.Ende.Hour && ende >= vermietung.Start.Hour )
                    {
                        fehler = true;
                    }
                }
            }
            if (!fehler) Bibliothek.Vermietung_Neu(vermietung);
            anzeigen();
        }

        private void updateVermietung(object sender, DataGridCellEditEndingEventArgs e)
        {
            Console.WriteLine("update");

            var column = e.Column as DataGridBoundColumn;
            if (column != null)
            {
                var bindingPath = (column.Binding as Binding).Path.Path;
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
                    else
                    {
                        el.Background = Brushes.IndianRed;
                        fehler = true;
                    }
                }
                if (bindingPath.Equals("Ende"))
                {
                    DateTime date;
                    if (DateTime.TryParse(el.Text, out date))
                    {
                        //setzte das Datum neu
                        vermietung.Ende = date;
                        el.Background = Brushes.LightCyan;
                    }
                    else
                    {
                        el.Background = Brushes.IndianRed;
                        fehler = true;
                    }
                }
            }
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
