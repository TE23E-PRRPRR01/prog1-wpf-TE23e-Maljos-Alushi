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

namespace AreaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


    private void KlickRäkna(object sender, RoutedEventArgs e)
    {
        // läsa av textrutorna
        //int bredd = int.Parse(txbBredd.Text);
        //int höjd = int.Parse(txbHöjd.Text);

        //kolla om det är text eller tal 
        if (!int.TryParse(txbBredd.Text, out int bredd))
        {
              txbResultat.Text ="Fel på bredd, du måste ange en heltal";
        }
        if (!int.TryParse(txbHöjd.Text, out int höjd))
        {
              txbResultat.Text ="Fel på höjd , du måste ange en heltal";
        }
        //Areaberäkning
        //int area = bredd * höjd;
        //txbResultat.Text = area.ToString();
        
    }
    private void KlickRensa (object sender, RoutedEventArgs e)
    {
        //rensa textrutorna
        txbBredd.Clear();
        txbHöjd.Clear();
        txbResultat.Clear();
    }
}