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
    /// Lógica de interacción para wpfListarClientes.xaml
    /// </summary>
    public partial class wpfListarClientes : Window
    {
        MainWindow ma;
        wpfCliente cl;
        wpfContrato co;

        public wpfListarClientes()
        {
            InitializeComponent();
        }

        public wpfListarClientes(MainWindow mawin)
        {
            InitializeComponent();
            ma = mawin;
            DaoCliente dao = new DaoCliente();
            dgvListar.ItemsSource = dao.Listar();
            btnPasar.IsEnabled = false;
            cboActividad.ItemsSource = Enum.GetValues(typeof(ActividadEmpresa));
            cboActividad.SelectedIndex = 0;
            cboTipoEmp.ItemsSource = Enum.GetValues(typeof(TipoEmpresa));
            cboTipoEmp.SelectedIndex = 0;
        }

        public wpfListarClientes(wpfCliente cli)
        {
            InitializeComponent();
            cl = cli;
            DaoCliente dao = new DaoCliente();
            dgvListar.ItemsSource = dao.Listar();
            cboActividad.ItemsSource = Enum.GetValues(typeof(ActividadEmpresa));
            cboActividad.SelectedIndex = 0;
            cboTipoEmp.ItemsSource = Enum.GetValues(typeof(TipoEmpresa));
            cboTipoEmp.SelectedIndex = 0;
        }

        //public wpfListarClientes(wpfContrato con)
        //{
        //   InitializeComponent();
        //    co = con;
        //    DaoCliente dao = new DaoCliente();
        //    dgvListar.ItemsSource = dao.Listar();
        //}

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
            Cliente cli = (Cliente)dgvListar.SelectedItem;
            cl.txtRut.Text = cli.Rut;
            cl.Buscar();
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

        private void btnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //   TipoEmpresa tipo = (TipoEmpresa)cboTipoEmp.SelectedItem;
            //   List<TipoEmpresa> tp = new DaoCliente().FiltroEmpresa(tipo);
            //   dgvListar.ItemsSource = tp;

            //   ActividadEmpresa Actividad = (ActividadEmpresa)cboActividad.SelectedItem;
            //   List<ActividadEmpresa> ap = new DaoCliente().FiltroActividad(Actividad);
            //   dgvListar.ItemsSource = ap;
            //}
            //catch (Exception)
            //{
            //
            //}
        }
    }
}
