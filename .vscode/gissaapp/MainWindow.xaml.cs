using System.Diagnostics;
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

namespace gissaapp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // slumpa fram ett tal 1-1000
    int slumptal = Random.Shared.Next(1, 1001);
    List<int> listaGissningar = [];


    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickGissa(object sender, RoutedEventArgs e)
    {
        // läs av ruta gissning 
        string input = txbGissning.Text;

        // konvertera till ett heltal
        bool lyckades = int.TryParse(input, out int gissning);


        // gämföra gissning med slumptal
        if (lyckades)
        {
            if (gissning == slumptal)
            {
                txbResultat.Text = $"Ditt gisning var rätt. Nummret är {gissning}";
            }
            else if (gissning > slumptal)
            {
                txbResultat.Text = $"{gissning} är för långt borta ";
            }
            else if (gissning < slumptal)
            {
                txbResultat.Text = $"{gissning} har träffat lågt ";

            }

        }
        else
        {
            txbResultat.Text = "Ogiltig inmattning!";
        }

    }
    private void KlickFacit(object sender, RoutedEventArgs e)
    {
        txbResultat.Text = $"Rätt svar är {slumptal}";

    }
    private void KlickHistorik(object sender, RoutedEventArgs e)
    {
        // skriv ut all gissningar som finns i lista
        // i stora rutan 
        foreach (var tal in listaGissningar)
        {
            txbGissningar.Text += $"{tal}\n";
        }
    }

    private void SpelaIgen(object sender, RoutedEventArgs e)
    {
        slumptal = Random.Shared.Next(1,1001);

              listaGissningar = [];

        // ränsa gränssnitet 
        txbGissningar.Text = "";
        txbHistorik.Text = "";
        txbResultat.Text = "";
    }
}
