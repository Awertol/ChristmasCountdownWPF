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

namespace ChristmasCountdown
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        DateOnly datum;
        DateOnly datumVanoc;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            datum = DateOnly.FromDateTime(DateTime.Now);
            datumVanoc = new DateOnly(datum.Year, 12, 24);

            lbDnesniDatum.Content = $"{datum.Day}. {datum.Month}. {datum.Year}";

            int dniDoVanoc = datumVanoc.DayNumber - datum.DayNumber;
            lbDniDoVanoc.Content = $"Do Vánoc zbývá: {dniDoVanoc}";
        }
    }
}
