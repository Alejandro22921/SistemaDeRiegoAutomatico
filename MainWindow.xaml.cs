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
        SerialPort puerto = new SerialPort("COM1", 9600, Parity.None, 8);
        DispatcherTimer tiempo = new DispatcherTimer();                       //TIMER DE TIEMPO HORA Y FECHA DEL SISTEMA.
        Chart figura = new Chart();
        private string datosRecibidos = "";
        int contador = 0;

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

            /* --- CONFIGURACIÓN DE TIMERS --- */
            tiempo.Interval = TimeSpan.FromSeconds(1);  /* --- CADA 1s --- */
            tiempo.Tick += new EventHandler(tiempo_Tick);
            tiempo.Start();
        }

        void tiempo_Tick(object sender, EventArgs e)
        {
            lblHora.Content = DateTime.Now.ToString("h:mm:ss tt");
            lblFecha.Content = DateTime.Now.ToString("ddd dd/MMM/yyyy");
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

        private void rbtnAutomatico_Click(object sender, RoutedEventArgs e)
        {
                MessageBoxResult result = MessageBox.Show("¿Cambiar Al Modo Automático?", "", MessageBoxButton.OKCancel, MessageBoxImage.None);
                if (result == MessageBoxResult.Cancel)
                {
                    rbtnProgramado.IsChecked = true;
                }
        }

        private void rbtnProgramado_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Cambiar Al Modo Programado?", "", MessageBoxButton.OKCancel, MessageBoxImage.None);
            if (result == MessageBoxResult.Cancel)
            {
                rbtnAutomatico.IsChecked = true;
            }
        }
    }
}
