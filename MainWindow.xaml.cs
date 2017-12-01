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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO.Ports;
using System.Windows.Threading;
using System.Windows.Forms.DataVisualization.Charting;


namespace SistemaDeRiegoAutomatico
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            try
            {
                DBRiegoAutomatizado.DBConectar();
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE PUDO CONECTAR A LA BASE DE DATOS", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void menuSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void menuAutomatico_Click(object sender, RoutedEventArgs e)
        {
            (new wAutomatico()).Show();
        }

        private void menuProgramado_Click(object sender, RoutedEventArgs e)
        {
            (new wProgramado()).Show();
        }

        private void menuEstadisticas_Click(object sender, RoutedEventArgs e)
        {
            (new wEstadisticas()).Show();
        }

        private void rbtnAutomatico_Checked(object sender, RoutedEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("¿Cambiar Al Modo Automático?", "", MessageBoxButton.OKCancel, MessageBoxImage.None);
        }



    }
}
