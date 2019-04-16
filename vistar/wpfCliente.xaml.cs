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
    /// Lógica de interacción para wpfCliente.xaml
    /// </summary>
    public partial class wpfCliente : Window
    {
        MainWindow ma;

        public wpfCliente()
        {
            InitializeComponent();
        }

        public wpfCliente(MainWindow mw)
        {
            InitializeComponent();
            ma = mw;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnListarCli_Click(object sender, RoutedEventArgs e)
        {
            wpfListarClientes lc = new wpfListarClientes(this);
            lc.ShowDialog();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow maw = new MainWindow(this);
            maw.Show();
            Close();
        }

        public void Buscar()
        {
            //try
            //{
            //    Persona p = new DaoPersona().
            //        Buscar(txtRut.Text);
            //    if (p != null)
            //    {
            //        txtApellido.Text = p.Apellido;
            //        txtEdad.Text = p.Edad.ToString();
            //        txtNombre.Text = p.Nombre;
            //        cboSexo.Text = p.Sexo.ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("no ta");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("error buscar");
            //    Logger.Mensaje(ex.Message);

            //}
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    Persona p = new DaoPersona().
            //        Buscar(txtRut.Text);
            //    if (p != null)
            //    {
            //        txtApellido.Text = p.Apellido;
            //        txtEdad.Text = p.Edad.ToString();
            //        txtNombre.Text = p.Nombre;
            //        cboSexo.Text = p.Sexo.ToString();
            //    }
            //    else
            //    {
            //        MessageBox.Show("no ta");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("error buscar");
            //    Logger.Mensaje(ex.Message);

            //}
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtRut.Focus();
            txtRazon.Clear();
            txtNombre.Clear();
            txtFono.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            cboActividad.SelectedIndex = 0;
            cboTipoEmp.SelectedIndex = 0;
        }
    }
}
