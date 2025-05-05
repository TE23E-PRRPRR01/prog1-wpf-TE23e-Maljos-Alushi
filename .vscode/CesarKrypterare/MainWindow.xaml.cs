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

namespace CesarKrypterare;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickKryptera(object sender, RoutedEventArgs e)
    {
        // Läs av text rutorna 
        string inputText = txbInput.Text;
        string keyText = txbKey.Text;

        // konvertera keytext till key(int)
        int.TryParse(keyText, out int key );

        // Rensa txbOutput
            txbOutput.Clear();

         
         //Gå igenom imputtext bokstav för bokstav
         //loopa bokstav för bokstav
        foreach (var bokstav in inputText)
        {
            // hitta ASCII värde
            int ascii = (int)bokstav;

            // kryptera, dsv skifta framåt 
            int asciiKrypterad = ascii + key; 
            char bokstavKrypterad = (char)asciiKrypterad;

             txbOutput.Text += $"{bokstavKrypterad}";

        }


        // skriv ut resultatet 
        // txbOutput.Text = $"Du skrev : {inputText}";
    }

    private void KlickClear(object sender, RoutedEventArgs e)
    {
        txbOutput.Text = "";
        txbKey.Text = "";
        txbInput.Text = "";
    }
}