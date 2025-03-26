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
using System.Net.Http;
using System.Net.Http.Json;

namespace Chat_AI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    // redskap för att kommunisera över http
    HttpClient klient = new HttpClient();
    string url = "http://10-151-168.5:11434/api/generate";

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSkika(object sender, RoutedEventArgs e)
    {
        // läsa av promt texten i ruten 
        string promt = txbPrompt.Text;

        // skapap ett jeson-objekt som 
        object data = new
        {
            model = "phi4:latest",
            promt = promt,
            max_tokens = 50

        };

        // skicka till ollama-ai-servern
        SkickaTillOllama(data);
    }

    private void SkickaTillOllama(object data)
    {
        try
        {
            // skicka dara till ollama-ai-servern
            HttpResponseMessage svar = klient.PostAsJsonAsync(url, data).Result;

            // kontrollera att "request" gick bra
            svar.EnsureSuccessStatusCode();

            // läsa av svaret från ollama-ai-servern
            string råtext = svar.Content.ReadAsStringAsync().Result;

            // skriv ut i svars rutan
            txbSvar.Text = råtext;

            // dela upp texten 
            string[] rader = råtext.Split("\n");

            // gå igenom alla rader
            foreach (string rad in rader)
            {
                //finns respons 
                if (rad.Contains("response"))
                {
                    txbSvar.Text += PLockaUtToken(rad);
                }
            }
        }
        catch (HttpRequestException e)
        {
            txbSvar.Text = $"Fel: {e.Message}";
        }
    }

    private string PLockaUtToken(string rad)
    {
        int start = rad.IndexOf("response") + 11;
        int slut = rad.IndexOf("\"", start);

        // plocka ut tokern
        return rad.Substring(start, slut - start);
    }
}
