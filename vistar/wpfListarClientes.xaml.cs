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

namespace vistar
{
    /// <summary>
    /// Lógica de interacción para wpfListarClientes.xaml
    /// </summary>
    public partial class wpfListarClientes : Window
    {
        MainWindow ma;
        wpfCliente cl;

        public wpfListarClientes()
        {
            InitializeComponent();
        }

        public wpfListarClientes(MainWindow mawin)
        {
            InitializeComponent();
            ma = mawin;
            btnPasar.IsEnabled = false;
        }

        public wpfListarClientes(wpfCliente cli)
        {
            InitializeComponent();
            cl = cli;
        }

        public wpfListarClientes(wpfContrato con)
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            if (btnPasar.IsEnabled == false)
            {
                MainWindow mw = new MainWindow(this);
                mw.Show();
                Close();
            }
            else
            {
                Close();
            }
        }

        private void btnPasar_Click(object sender, RoutedEventArgs e)
        {
            cl.txtRut.Text = "12123123-3";
            cl.txtNombre.Text = "Pepsi";
            cl.txtRazon.Text = "Pepsi Co.";
            cl.txtFono.Text = "8009001000";
        }

        private void menuRut_Click(object sender, RoutedEventArgs e)
        {
            wpfFiltroRut filrut = new wpfFiltroRut();
            filrut.ShowDialog();
            
            try
            {

            }
            catch (Exception)
            {

            }
        }
    }
}
