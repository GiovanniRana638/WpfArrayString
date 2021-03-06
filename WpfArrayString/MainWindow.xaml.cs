﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfArrayString
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtStringa.Focus();
        }
        string[] array = new string[5];
        int c;

        private void btnInserisci_Click(object sender, RoutedEventArgs e)
        {
            array[c] = txtStringa.Text;
            c++;
            txtStringa.Clear();
            txtStringa.Focus();
            if (c >= 5)
            {
                btnInserisci.IsEnabled = false;
                btnPubblica.IsEnabled = true;
                btnStampa.IsEnabled = true;
            }
        }

        private void btnStampa_Click(object sender, RoutedEventArgs e)
        {
            btnStampa.IsEnabled = false;
            for (c = 0;c < array.Length;c++)
            {
                LblRi.Content += $"Posizione {c} : {array[c]} \n";
            } 
                
        }

        private void btnPubblica_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("pubbica.txt", false, Encoding.UTF8);
            for (c = 0; c < array.Length; c++)
            {
                sw.WriteLine($"Posizione {c} : {array[c]} \n");
            }
            sw.Flush();
            sw.Close();
        }
    }
}
