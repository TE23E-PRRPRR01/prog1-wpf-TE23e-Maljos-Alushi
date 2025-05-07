using System.Net.Http;
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

namespace kontaktlista;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickVisa(object sender, RoutedEventArgs e)
    {
        string kön = txbTitel.Text;
        string namn1 = txbFornamn.Text;
        string namn2 = txbEfternamn.Text;
        
         if (kön == "Herr" || kön == "Fru")
         {
            bool ålderOk =int.TryParse(txbÅlder.Text, out int ålder);

            if (ålderOk)
            {
            txbResultat.Text = "";
            txbResultat.Text += $" Titel: {kön}\n Förnamn: {namn1}\n Efternamn: {namn2}\n Ålder: {ålder}";
            } 
            else
            {
                txbResultat.Text = "Ålder saknas!";
            }

         } else
         {
             txbResultat.Text = "Felaktig titel! Vänligen ange Herr eller Fru";
         }
        
    }

    private void klickRensa(object sender, RoutedEventArgs e)
    {   
           txbTitel.Text = "";
           txbFornamn.Text = "";
           txbEfternamn.Text = "";
           txbÅlder.Text = "";
           txbResultat.Text = "";
    }



}