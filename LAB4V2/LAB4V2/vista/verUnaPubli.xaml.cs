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
using controlador;

namespace LAB4V2.vista
{
    /// <summary>
    /// Lógica de interacción para verUnaPubli.xaml
    /// </summary>
    public partial class verUnaPubli : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");
        public verUnaPubli(int id)
        {
            InitializeComponent();
            rellenarPublicacion(id);
        }
        public void rellenarPublicacion(int id)
        {
            string idchar = id.ToString();
            Autor.Text = controlador.GetPubliIndex(id).Autor.Username;
            ID.Text = idchar;
            contenido.Text = controlador.GetPubliIndex(id).Contenido;
            likes.Text = controlador.GetPubliIndex(id).Likes.ToString();
        }
        private void Volver_Click(object sender, RoutedEventArgs e)
        {
            VentanaUserRegistrado volver = new VentanaUserRegistrado();
            volver.Show();
            this.Close();
        }
    }
}
