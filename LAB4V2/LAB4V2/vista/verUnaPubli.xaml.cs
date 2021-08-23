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
        private int id;
        public verUnaPubli(int id)
        {
            InitializeComponent();
            rellenarPublicacion(id);
            this.id = id;

        }
        public void rellenarPublicacion(int id)
        {
            string idchar = id.ToString();
            Autor.Text = controlador.GetPubliIndex(id).Autor.Username;
            ID.Text = idchar;
            contenido.Text = controlador.GetPubliIndex(id).Contenido;
            likes.Text = controlador.GetPubliIndex(id).Likes.ToString();
            CajaComentarios.ItemsSource = controlador.GetPubliIndex(id).Comentarios;
        }
        private void Volver_Click(object sender, RoutedEventArgs e)
        {
            VentanaUserRegistrado volver = new VentanaUserRegistrado();
            volver.Show();
            this.Close();
        }

        private void compartir_Click(object sender, RoutedEventArgs e)
        {
            List<string> et = new List<string>();
            controlador.share(controlador.GetPubliIndex(id), et);
            MessageBox.Show("Compartida, esta funcion aun no esta del todo terminada, lo sentimos :c");
            
        }
    }
}
