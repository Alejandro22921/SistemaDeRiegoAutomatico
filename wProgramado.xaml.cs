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

namespace SistemaDeRiegoAutomatico
{
    /// <summary>
    /// Interaction logic for wProgramado.xaml
    /// </summary>
    public partial class wProgramado : Window
    {
        private List<ConfiguracionProgramado> listaProgramadoRiegoAux = new List<ConfiguracionProgramado>();
        private List<ConfiguracionProgramado> listaProgramadoIluminacionAux = new List<ConfiguracionProgramado>();

        public wProgramado()
        {
            InitializeComponent();
        }

        private void txtHoras_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt16(txtHorasR_A.Text) > 23)
                    txtHorasR_A.Text = "23";
            }
            catch (Exception) { }
        }

        private void txtSegundos_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt16(txtSegundosR_A.Text) > 59)
                    txtSegundosR_A.Text = "59";
            }
            catch (Exception) { }
        }

        private void txtMinutosR_A_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt16(txtMinutosR_A.Text) > 59)
                    txtMinutosR_A.Text = "59";
            }
            catch (Exception) { }
        }


        private void txtSegundosR_D_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt16(txtSegundosR_D.Text) > 59)
                    txtSegundosR_D.Text = "59";
            }
            catch (Exception) { }
        }

        private void txtMinutosR_D_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt16(txtMinutosR_D.Text) > 59)
                    txtMinutosR_D.Text = "59";
            }
            catch (Exception) { }
        }

        private void txtHorasR_D_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt16(txtHorasR_D.Text) > 23)
                    txtHorasR_D.Text = "23";
            }
            catch (Exception) { }
        }

        private void txtHorasR_A_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void txtSegundosR_A_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void txtMinutosR_A_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void txtHorasR_D_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void txtMinutosR_D_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void txtSegundosR_D_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;

            else
                e.Handled = true;
        }

        private void txtHorasR_A_LostFocus(object sender, RoutedEventArgs e)
        {
            txtHorasR_A.Text = verificarHora2(txtHorasR_A.Text);
        }

        private void txtMinutosR_A_LostFocus(object sender, RoutedEventArgs e)
        {
            txtMinutosR_A.Text = verificarHora2(txtMinutosR_A.Text);
        }

        private void txtSegundosR_A_LostFocus(object sender, RoutedEventArgs e)
        {
            txtSegundosR_A.Text = verificarHora2(txtSegundosR_A.Text);
        }

        private void txtHorasR_D_LostFocus(object sender, RoutedEventArgs e)
        {
            txtHorasR_D.Text = verificarHora2(txtHorasR_D.Text);
        }

        private void txtMinutosR_D_LostFocus(object sender, RoutedEventArgs e)
        {
            txtMinutosR_D.Text = verificarHora2(txtMinutosR_D.Text);
        }

        private void txtSegundosR_D_LostFocus(object sender, RoutedEventArgs e)
        {
            txtSegundosR_D.Text = verificarHora2(txtSegundosR_D.Text);
        }

        // SE ELIMINAN LOS ELEMENTOS DE LAS LISTAS.

        private string verificarHora2(string x)
        {
            if (x == "")
                return "00";
            if (Convert.ToInt16(x) < 10 && x.Length == 1)
                return "0" + x;
            return x;
        }


        private void listViewProgramado_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string s1 = listaProgramadoRiegoAux.ElementAt(listViewProgramado.SelectedIndex).HActivar, s2 = listaProgramadoRiegoAux.ElementAt(listViewProgramado.SelectedIndex).HDesactivar;
            txtHorasR_A.Text = s1.Substring(0,2);
            txtMinutosR_A.Text = s1.Substring(3,2);
            txtSegundosR_A.Text = s1.Substring(6,2);

            txtHorasR_D.Text = s2.Substring(0,2);
            txtMinutosR_D.Text = s2.Substring(3,2);
            txtSegundosR_D.Text = s2.Substring(6,2);
        }

        private void imagenEliminar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                if (listViewProgramado.SelectedItems.Count == 1)
                {
                    listaProgramadoRiegoAux.RemoveAt(listViewProgramado.SelectedIndex);
                    listViewProgramado.ItemsSource = listaProgramadoRiegoAux;
                    listViewProgramado.Items.Refresh();
                }
            }
            catch (Exception) { }
        }

        private void imagenAñadir_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            listaProgramadoRiegoAux.Add(new ConfiguracionProgramado(0, txtHorasR_A.Text + ":" + txtMinutosR_A.Text + ":" + txtSegundosR_A.Text, txtHorasR_D.Text + ":" + txtMinutosR_D.Text + ":" + txtSegundosR_D.Text));
            listViewProgramado.ItemsSource = listaProgramadoRiegoAux;
            listViewProgramado.Items.Refresh();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Guardar La Nueva Configuración?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                MainWindow.listaProgramadoRiego = listaProgramadoRiegoAux;
                MainWindow.listaProgramadoIluminacion = listaProgramadoIluminacionAux;
                DBRiegoAutomatizado.GuardarConfiguracionRiego();
                //DBRiegoAutomatizado.GuardarConfiguracionIluminacion();
            }
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listaProgramadoRiegoAux = MainWindow.listaProgramadoRiego;
            listaProgramadoIluminacionAux = MainWindow.listaProgramadoIluminacion;
            listViewProgramado.ItemsSource = listaProgramadoRiegoAux;
            listViewProgramado.Items.Refresh();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            listaProgramadoRiegoAux = null;
            listaProgramadoIluminacionAux = null;
        }
    }
}
