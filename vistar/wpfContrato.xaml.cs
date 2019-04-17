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
    /// Lógica de interacción para wpfContrato.xaml
    /// </summary>
    public partial class wpfContrato : Window
    {
        MainWindow ma;
        DaoContrato Daocon;
        DaoEvento Daoeve;

        public wpfContrato()
        {
            InitializeComponent();
        }

        public wpfContrato(MainWindow mw)
        {
            InitializeComponent();
            ma = mw;
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(this);
            main.Show();
            Close();
        }

        private void btnListarA_Click(object sender, RoutedEventArgs e)
        {
            wpfLisCli licli = new wpfLisCli(this);   //el (this) soluciona el error en wpfLisCli, del boton pasar
            licli.ShowDialog();

        }

        private void btnListarConA_Click(object sender, RoutedEventArgs e)
        {
            wpfListarContrato lcon = new wpfListarContrato(this);
            lcon.ShowDialog();
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String numeroContrato = txtNumCon.Text; // aqui se rescata el valor, en realidad deberia darse solo, en ese caso recurda bloquear el txt y desbloquearlo cuando se aprete el boton buscar o actualizar, ya que el numero del contrato en el momento de la creacion, se hace solo segun el formato de la guia.
                DateTime creacion = DateTime.Now;
                DateTime termino = DateTime.Today;
                string horaInicio = txtInicio.Text;
                string horaTermino = txtTermino.Text;
                String direccion = txtDireccion.Text;
                //String vigencia = "Vigente";
                String rutCliente = txtRut.Text;
                //String idEvento = txtNumCom.Text; -- el id del evento al igual que el numero del contrato debe ser generado del mismo modo
                string NombreEvento = txtNombreEvento.Text;
                //int valorBase = calcular
                int asistentes = int.Parse(txtAsistente.Text);
                //int valorAgregado = Calcular
                int personalExtra =int.Parse(txtExtra.Text);

                Evento eve = new Evento()
                {
                    //IdTipo = idEvento,
                    Nombre = NombreEvento,
                    //ValorBase = ValorBase,
                    PersonalBase = asistentes,
                    //ValorAgregado = valorAgregado,
                    PersonalExtra = personalExtra
                };

                Contrato co = new Contrato()
                {
                    NumeroContrato = numeroContrato,
                    Creacion = creacion,
                    Termino = termino,
                    Inicio = horaInicio,
                    Fin = horaTermino,
                    Direccion = direccion,
                    //_vigente = vigencia,
                    Rut = rutCliente
                    //_idEvento = idEvento
                };

                bool respEve = Daoeve.Crear(eve);
                bool respCon = Daocon.Crear(co);

                if (respEve == true && respCon == true)
                {
                    bool resp = true;
                    MessageBox.Show(resp ? "Grabo" : "No Grabo");
                }
                else
                {
                    bool resp = false;
                    MessageBox.Show(resp ? "Grabo" : "No Grabo");
                }

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

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Contrato con = new DaoContrato().Buscar(txtNumCon.Text);

                //if (con != null)
                //{
                //    con.Inicio = txtInicio.Text;
                //    con.Fin = txtTermino.Text;
                //    con.Direccion = txtDireccion.Text;
                //    String vigencia = "Vigente";
                //    con._rutCliente = txtRut.Text;
                //    //String idEvento = txtNumCom.Text; -- el id del evento al igual que el numero del contrato debe ser generado del mismo modo
                //    string NombreEvento = txtNombreEvento.Text;
                //    //int valorBase = calcular
                //    int asistentes = int.Parse(txtAsistente.Text);
                //    //int valorAgregado = Calcular
                //    int personalExtra = int.Parse(txtExtra.Text);

                //    Evento eve = new Evento()
                //    {
                //        //IdTipo = idEvento,
                //        Nombre = NombreEvento,
                //        //ValorBase = ValorBase,
                //        PersonalBase = asistentes,
                //        //ValorAgregado = valorAgregado,
                //        PersonalExtra = personalExtra
                //    };


                //}
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

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            txtAsistente.Clear();
            txtDireccion.Clear();
            txtExtra.Clear();
            txtInicio.Clear();
            txtNombre.Clear();
            txtNombreEvento.Clear();
            txtNumCon.Clear();
            txtObservacion.Clear();
            txtRut.Clear();
            txtTelefono.Clear();
            txtTermino.Clear();
        }
    }
}
