﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PortoApp;

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

        // Konvertera texten i textrutan till ett heltal
        if (int.TryParse(txbVikt.Text, out int vikt))
        {
            if (vikt <= 50)
            {
                lblResultat.Content = "22kr";
            }
            else if (vikt <= 100 )
            {
                lblResultat.Content = "44kr";
                
            }
        }
        else
        {
            lblResultat.Content = "Ogiltig vikt.";
        }


    }
}