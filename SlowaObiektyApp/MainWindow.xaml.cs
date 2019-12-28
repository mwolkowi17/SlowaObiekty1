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

           

            gridSlowa.Items.Add(moj.RandomSlowoReturn());
        }

        private void buttonKlienci_Click(object sender, RoutedEventArgs e)
        {
            gridSlowa.Items.Clear();
            gridSlowa.Items.Add(moj.RandomSlowoReturn());
            boxSlowa.Text = "Sukces";
        }

        private void buttonSprawdz_Click(object sender, RoutedEventArgs e)
        {
           // moj.TestSlowoEngCheck(moj.RandomSlowoReturn(), textBoxTlum.Text);
            boxSlowa.Text = moj.TestSlowoEngCheck(moj.RandomSlowoReturn(), textBoxTlum.Text); // tu narazie jest źle bo muszę wziąć słowo z listboxa
        }
    }
}
