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

namespace BranbollApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // skapa variabel för lagen 
    int poängInne = 0;
    int poängUte = 0;
    public MainWindow()
    {
        InitializeComponent();
    }
    private void ClickFrivarv(object sender, RoutedEventArgs e)
    {

        // lägg till poäng
        poängInne += 5;

        // skriv ut poängen 
        txbInne.Text = $"{poängInne}";

        //vad är klockan nu ?
        DateTime nu = DateTime.Now;

        //lägg in i historiken 
        txbHistorik.Text += $"{nu.ToString("HH:mm:ss")} Lag Inne +5, total: {poängInne}\n";
    }
    private void ClickBränning(object sender, RoutedEventArgs e)
    {


        // lägg till poäng
        poängUte += 2;

        // skriv ut poängen 
        txbUte.Text = $"{poängUte}";
        txbHistorik.Text += $"{nu.ToString("HH:mm:ss")} Lag Ute +2, total: {poängUte}\n";
    }
    private void ClickLyra(object sender, RoutedEventArgs e)
    {


        // lägg till poäng
        poängUte += 3;

        // skriv ut poängen 
        txbUte.Text = $"{poängUte}";
        txbHistorik.Text += $"{nu.ToString("HH:mm:ss")}  Lag Ute +3, total: {poängUte}\n";
    }
    private void ClickVarv(object sender, RoutedEventArgs e)
    {

        // lägg till poäng
        poängInne += 1;

        // skriv ut poängen 
        txbInne.Text = $"{poängInne}";
        txbHistorik.Text += $"\n Lag Inne +5, total: {poängInne}";
    }

    
}