using System.Reflection.Metadata.Ecma335;
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

namespace FoodApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    List<string> receptLista = []; 
    private void KlickVisa(object sender, RoutedEventArgs e)
    {
        // skapar variabler 
        string matNamn = txbNamn.Text;
        string ingredens = txbIngrediens.Text;
        string tid = txbTid.Text;
        
          
        // if sats för olika händelser
        if (matNamn == "" || ingredens == "")
        {
            txbResultat.Text = "Fyll i både namn och tid.";
        }
        else
        {
            if (int.TryParse(tid, out int tidtal))
            {
                string resultat = "Namn: " + matNamn + "\nIngrediens: " + ingredens + "\nTid: " + tid + "min";
              
                if (tidtal < 15)
                {
                    resultat += "\nKommentar: Snabbt recept!";
                }
                else if (tidtal > 45)
                {
                    resultat += "\nKommentar: Lång tillagningstid.";
                }
                if (ingredens != "Kött" && ingredens != "Fisk")
                {
                   resultat += "\nOBS! Ovanlig ingrediens";
                }
                
                else
                { 
                    txbResultat.Text = "Felaktig Tid! Ange ett heltal";
                }
            } 
        }
    }

    private void KlickRensa(object sender, RoutedEventArgs e)
    {
        txbNamn.Text = "";
        txbIngrediens.Text = "";
        txbTid.Text = "";
        txbResultat.Text = "";
    }

    private void KlickVisaLista(object sender, RoutedEventArgs e)
    {
       foreach (var recept in receptLista)
       {
         txbLista.Text += recept + "\n\n";
       }
    }

}