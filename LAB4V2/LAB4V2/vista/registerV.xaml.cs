using System;
using controlador;
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
    /// Lógica de interacción para registerV.xaml
    /// </summary>
    public partial class registerV : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");
        public registerV()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if ((nick.Text == "") || (pass.Text == ""))
            {
                MessageBox.Show("Nombre o contrasenia vacios");
            }
            else
            {
                if (controlador.Register(nick.Text, pass.Text))
                {
                    MessageBox.Show("Registrado");
                    controlador.Login(nick.Text, pass.Text);
                    VentanaUserRegistrado logeado = new VentanaUserRegistrado();
                    logeado.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nombre ocupado");
                    nick.Clear();
                }
            }
        }

        private void salir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow volver = new MainWindow();
            volver.Show();
            this.Close();
        }
    }
}
