using System;
using System.Collections.Generic;
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
using LAB4V2.vista;

namespace LAB4V2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void irAregister_Click(object sender, RoutedEventArgs e)
        {
            registerV registerVentana = new registerV();
            registerVentana.Show();
            this.Close();
        }

        private void irALogin_click(object sender, RoutedEventArgs e)
        {
            loginV loginventana = new loginV();
            loginventana.Show();
            this.Close();
        }
    }
}
