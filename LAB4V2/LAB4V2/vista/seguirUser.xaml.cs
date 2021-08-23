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
    /// Lógica de interacción para seguirUser.xaml
    /// </summary>
    public partial class seguirUser : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");
        public seguirUser()
        {
            InitializeComponent();
        }

        private void seguirUsuario_Click(object sender, RoutedEventArgs e)
        {
            if(userAseguir.Text == "")
            {
                MessageBox.Show("Porfavor ingrese un nombre");
            }
            else
            {
                if (controlador.follow(userAseguir.Text))
                {
                    MessageBox.Show("Ahora sigues a este Usuario");
                }
                else
                {
                    MessageBox.Show("Porfavor revise que el nombre este escrito correctamente, recuerda que no puedes seguirte a ti mismo");
                }
                
            }
        }

        private void volverVentanaUserRegistrado_Click(object sender, RoutedEventArgs e)
        {
            VentanaUserRegistrado volver = new VentanaUserRegistrado();
            volver.Show();
            this.Close();
        }

        
    }
}
