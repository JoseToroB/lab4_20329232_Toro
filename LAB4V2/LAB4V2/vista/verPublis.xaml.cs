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
    /// Lógica de interacción para verPublis.xaml
    /// </summary>
    public partial class verPublis : Window
    {
        Controlador controlador = (Controlador)Application.Current.FindResource("controlador");
        public verPublis()
        {
            InitializeComponent();
            llenar();
        }
        public void llenar()
        {
            mostrarPublis.ItemsSource = controlador.GetPublis();
        }

        private void Volver_Click(object sender, RoutedEventArgs e)
        {
            VentanaUserRegistrado volver = new VentanaUserRegistrado();
            volver.Show();
            this.Close();
        }


        private void dobleClickCaja(object sender, MouseButtonEventArgs e)
        {
            int n = mostrarPublis.Items.IndexOf(mostrarPublis.SelectedItem);
            n = n + 1;
            verUnaPubli verunaPublicacion = new verUnaPubli(n);
            verunaPublicacion.Show();
            this.Close();
        }
    }

}
