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
using SlowaObiekty1;

namespace SlowaObiektyApp
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Slownik moj = new Slownik();
        public MainWindow()
        {
            InitializeComponent();
            OdswiezSlownik();
        }

        private void OdswiezSlownik()

        {

            listBoxSlowa.Items.Clear();

            foreach(var n in moj.slownik)

            {

                listBoxSlowa.Items.Add(n);

            }

        }
    }
}
