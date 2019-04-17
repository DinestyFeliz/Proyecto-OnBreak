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
using BibliotecaClases;
using BibliotecaControlador;

namespace vistar
{
    /// <summary>
    /// Lógica de interacción para wpfLisCli.xaml
    /// </summary>
    public partial class wpfLisCli : Window
    {
        wpfContrato co;

        public wpfLisCli()
        {
            InitializeComponent();
        }

        public wpfLisCli(wpfLisCli lci)
        {
            InitializeComponent();
        }

        public wpfLisCli(wpfContrato con)
        {
            InitializeComponent();
            con = co;
            DaoCliente dao = new DaoCliente();
            dgvListar.ItemsSource = dao.Listar();
            
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnPasar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cli = (Cliente)dgvListar.SelectedItem;
            co.txtRut.Text = cli.Rut;
            co.txtNombre.Text = cli.NombreContrato;
            co.txtTelefono.Text = cli.Telefono.ToString();
        }

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
