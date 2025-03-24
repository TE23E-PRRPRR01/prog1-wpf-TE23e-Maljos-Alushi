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

namespace Aritmetiken;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
private void KlickBeräkna(object sender, RoutedEventArgs e)
{
   // läs av rutorna
   string tal1String = txbTal1.Text();
   string tal2String = txbTal2.Text();
   string Operator = txbOperator.Text();

   
    // konvertera till heltal
    int.TryParse(tal1String, out int tal1);
    int.TryParse(tal2String, out int tal2);
        
    // beräkna
    if (Operator == "+")
    {
        int resultat = tal1 + tal2;
        lblResultat.Content = $"{resultat}";
    }
    else if (Operator == "-")
    {
        int resultat = tal1 - tal2;
        lblResultat.Content = $"{resultat}";
    }
    else if (Operator == "*")
    {
        int resultat = tal1 * tal2;
        lblResultat.Content = $"{resultat}";
    }
    else if (Operator == "/")
    {
        int resultat = tal1 / tal2;
        lblResultat.Content = $"{resultat}";
    }
    else
    {
        lblResultat.Content = "Felaktig operator";
    }
   
}      
}
