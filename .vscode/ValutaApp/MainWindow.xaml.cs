using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ValutaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    double Usd = (10.5);
    double Eur = (11.2);
    double Gbp = (13.5);

    public MainWindow()
    {
        InitializeComponent();
    }


    private void KlickUsd(object sender, RoutedEventArgs e)
    {
        if(double.TryParse(txbBelopp.Text, out double belopp))
          {
            txbResultat.Text = (belopp / Usd).ToString("0.00");
          }
          else
          {
              txbResultat.Text = "Ange giltig belopp";
          }
    }
    
    private void KlickEur(object sender, RoutedEventArgs e)
    {
    if(double.TryParse(txbBelopp.Text, out double belopp))
          {
            txbResultat.Text = (belopp / Eur).ToString("0.00");
          }
          else{
              txbResultat.Text = "Ange giltig belopp"; 
              }
    }
    
    private void KlickGbp(object sender, RoutedEventArgs e)
    {
       if(double.TryParse(txbBelopp.Text, out double belopp))
          {
           txbResultat.Text = (belopp / Gbp).ToString("0.00");
          }
          else
          {
              txbResultat.Text = "Ange giltig belopp"; 
          }
    }
}