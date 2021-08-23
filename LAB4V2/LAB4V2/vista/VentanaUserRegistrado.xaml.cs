using controlador;
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
using System.Windows.Shapes;

namespace LAB4V2.vista
{
    /// <summary>
    /// Lógica de interacción para VentanaUserRegistrado.xaml
    /// </summary>
    public partial class VentanaUserRegistrado : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");
        public VentanaUserRegistrado()
        {
            InitializeComponent();
            nombrePibeOnline.Content = controlador.getUsernameOnline();
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow menu = new MainWindow();
            menu.Show();
            this.Close();
        }

        private void Publicar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void seguirUser_Click(object sender, RoutedEventArgs e)
        {
            seguirUser seguir = new seguirUser();
            seguir.Show();
            this.Close();
        }

        private void comentar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
