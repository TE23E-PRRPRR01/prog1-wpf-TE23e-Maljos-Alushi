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

namespace JulKlappLista;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    int maxJulklappar = 0;
    List<string> listaJulklappar = [];
    public MainWindow()
    {
        InitializeComponent();

        //lås gränssnit
        stpInmatnig.IsEnabled = false;
        stpListan.IsEnabled = false;

    }

    private void KlickAnge(object sender, RoutedEventArgs e)
    {
        // läs av rutan 
        string antal = txbAntal.Text;
        // första enkel kontroll
        if (antal == "")
        {
            txbStatus.Text = "Vg ange en hel tal";
        }
        else
        {
            bool lyckas = int.TryParse(antal, out int talet);
            if (lyckas)
            {
                maxJulklappar = talet;
                txbStatus.Text = $"Max julklappar är {maxJulklappar}";

                // koppla list till listbox
                lbsJulklappar.ItemSource = listaJulklappar;


                //lås grännsnit
                stpMax.IsEnabled = false;
                stpInmatnig.IsEnabled = true;
                stpListan.IsEnabled = true;
            }
            else
            {
                txbStatus.Text = "ayyyyyyyyyyyy skriv in ett nummer ";
            }
        }
    }

    private void KlickLäggTill(object sender, RoutedEventArgs e)
    {
        // läs av texrutorna
        string julklapp = txbJulklapp.Text;
        string mottagare = txbMottagare.Text;

        listaJulklappar.Add($"{julklapp} til {mottagare}");
        listaJulklappar.Items.Refresh();
    }

    private void KlickBytUt(object sender, RoutedEventArgs e)
    {
        
    }
}