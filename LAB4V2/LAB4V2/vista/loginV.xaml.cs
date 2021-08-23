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
    /// Lógica de interacción para loginV.xaml
    /// </summary>
    public partial class loginV : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");
        public loginV()
        {
            InitializeComponent();
        }

        private void logearse_Click(object sender, RoutedEventArgs e)
        {
            if(controlador.Login(nick.Text, pass.Text))
            {
                MessageBox.Show("Sesion iniciada");
                VentanaUserRegistrado logeado = new VentanaUserRegistrado();
                logeado.Show();
                this.Close();
            }
        }

        private void Atras_Click(object sender, RoutedEventArgs e)
        {
            MainWindow volver = new MainWindow();
            volver.Show();
            this.Close();
        }
    }
}
