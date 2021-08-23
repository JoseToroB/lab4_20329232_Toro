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
    /// Lógica de interacción para publicarV.xaml
    /// </summary>
    public partial class publicarV : Window
    {
        
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");
        public publicarV()
        {
            InitializeComponent();
        }

        private void volverVentanaUserRegistrado_Click(object sender, RoutedEventArgs e)
        {
            VentanaUserRegistrado volver = new VentanaUserRegistrado();
            volver.Show();
            this.Close();
        }

        private void publicar_Click(object sender, RoutedEventArgs e)
        {
            string[] et = etiquetados.Text.Split(',');//transformo el string de etiquetados a un List<string>
            List<string> list = new List<string>(et);
            if (controlador.post(contenido.Text,list,tipoPubli.Text ))
            {
                MessageBox.Show("Publicado");
            }
            else
            {
                MessageBox.Show("Un error acaba de ocurrir :O, porfavor contacta con el soporte cuanto antes");
            }
        }
    }
}
