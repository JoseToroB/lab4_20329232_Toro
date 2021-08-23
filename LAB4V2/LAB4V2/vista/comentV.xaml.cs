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
    /// Lógica de interacción para comentV.xaml
    /// </summary>
    public partial class comentV : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");
        public comentV()
        {
            InitializeComponent();
        }

        private void volver_Click(object sender, RoutedEventArgs e)
        {
            VentanaUserRegistrado volver = new VentanaUserRegistrado();
            volver.Show();
            this.Close();
        }

        private void comentar_Click(object sender, RoutedEventArgs e)
        {
            
            if (id.Text == ""|| contenido.Text == "")
            {
                //si no hay id o no hay contenido
                MessageBox.Show("Porfavor rellene todos los espacios requeridos");
            }
            else
            {
                int idCoso = Int32.Parse(id.Text);//paso la id a int
                if (aPubli.IsChecked == true)//si esta chekada entonces es un comentario a publicacion
                {
                    //comentario a publi
                   
                    if(controlador.comentarPubli(controlador.GetPubliIndex(idCoso), contenido.Text,controlador.GetUserOnCompleto()))
                    {
                        MessageBox.Show("Comentado");
                    }
                    else
                    {
                        MessageBox.Show("Un error acaba de suceder :O, porfavor contacta con el soporte");
                    }
                }
                else
                {
                    //comentario a comentario
                    if (controlador.comentarComentario(contenido.Text,controlador.GetComentarioIndex(idCoso),controlador.GetUserOnCompleto()))
                    {
                        MessageBox.Show("Comentado");
                    }
                    else
                    {
                        MessageBox.Show("Un error acaba de suceder :O, porfavor contacta con el soporte");
                    }
                }
            }
            
        }
    }
}
