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
using BibliotecaControlador;
using BibliotecaClases;

namespace vistar
{
    /// <summary>
    /// Lógica de interacción para wpfCliente.xaml
    /// </summary>
    public partial class wpfCliente : Window
    {
        DaoCliente DaoCli;
        MainWindow ma;

        public wpfCliente()
        {
            InitializeComponent();
        }

        public wpfCliente(MainWindow mw)
        {
            InitializeComponent();
            ma = mw;
            cboActividad.ItemsSource = Enum.GetValues(typeof(ActividadEmpresa));
            cboActividad.SelectedIndex = 0;
            cboTipoEmp.ItemsSource = Enum.GetValues(typeof(TipoEmpresa));
            cboTipoEmp.SelectedIndex = 0;
            DaoCli = new DaoCliente();
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String rut = txtRut.Text;
                String razonSocial = txtRazon.Text;
                String nombreContrato = txtNombre.Text;
                String mailContacto = txtCorreo.Text;
                int telefono = int.Parse(txtFono.Text);
                String direccion = txtDireccion.Text;
                ActividadEmpresa actividad = (ActividadEmpresa)cboActividad.SelectedItem;
                TipoEmpresa tipo = (TipoEmpresa)cboTipoEmp.SelectedItem;

                Cliente c = new Cliente()
                {
                    Rut = rut,
                    RazonSocial = razonSocial,
                    NombreContrato = nombreContrato,
                    MailContacto = mailContacto,
                    Direccion = direccion,
                    Telefono = telefono,
                    Actividad = actividad,
                    Tipo = tipo
                };

                bool resp = DaoCli.Crear(c);

                MessageBox.Show(resp ? "Grabo" : "No Grabo");
            }
            catch (ArgumentException exa)
            {
                MessageBox.Show(exa.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error de ingreso de datos");
                Logger.Mensaje(ex.Message);
            }
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
            try
            {
                Cliente c = new DaoCliente().Buscar(txtRut.Text);

                if (c != null)
                {
                    txtCorreo.Text = c.MailContacto;
                    txtDireccion.Text = c.Direccion;
                    txtNombre.Text = c.NombreContrato;
                    txtFono.Text = c.Telefono.ToString();
                    txtRazon.Text = c.RazonSocial;
                    cboActividad.Text = c.Actividad.ToString();
                    cboTipoEmp.Text = c.Tipo.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontro al cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error buscar");
                Logger.Mensaje(ex.Message);

            }
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente c = new DaoCliente().Buscar(txtRut.Text);

                if (c != null)
                {
                    txtCorreo.Text = c.MailContacto;
                    txtDireccion.Text = c.Direccion;
                    txtNombre.Text = c.NombreContrato;
                    txtFono.Text = c.Telefono.ToString();
                    txtRazon.Text = c.RazonSocial;
                    cboActividad.Text = c.Actividad.ToString();
                    cboTipoEmp.Text = c.Tipo.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontro al cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error buscar");
                Logger.Mensaje(ex.Message);

            }
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtRut.Clear();
            txtRazon.Clear();
            txtNombre.Clear();
            txtFono.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            cboActividad.SelectedIndex = 0;
            cboTipoEmp.SelectedIndex = 0;
            txtRut.Focus();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Contrato con = new Contrato();
                Cliente cli = new Cliente();
                    MessageBoxResult respuesta = MessageBox.Show("Desea eliminar?","Eliminar",MessageBoxButton.YesNo,MessageBoxImage.Warning);

                if (respuesta == MessageBoxResult.Yes && cli.Rut != con._rutCliente)
                {
                    bool resp = new DaoCliente().Eliminar(cli.Rut);
                    if (resp)
                    {
                        MessageBox.Show("elimino");
                    }
                    else
                    {
                        MessageBox.Show("no elimino");
                    }
                }
                else
                {
                    MessageBox.Show("cancelo operacion");
                }
            }
            catch
            {

            }
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Cliente c = new DaoCliente().Buscar(txtRut.Text);

                if (c != null)
                {
                    c.RazonSocial = txtRazon.Text;
                    c.NombreContrato = txtNombre.Text;
                    c.MailContacto = txtCorreo.Text;
                    c.Direccion = txtDireccion.Text;
                    c.Telefono = int.Parse(txtFono.Text);
                    //c.Actividad = cboActividad.SelectedIndex;
                    //c.Tipo = cboTipoEmp.SelectedIndex;
                }
                else
                {
                    MessageBox.Show("No se encontro al cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error buscar");
                Logger.Mensaje(ex.Message);

            }
        }

        private void cboActividad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
