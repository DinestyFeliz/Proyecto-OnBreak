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
using BibliotecaClases;
using BibliotecaControlador;

namespace vista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DaoPersona dao;
        public MainWindow()
        {
            InitializeComponent();
            cboSexo.ItemsSource = Enum.GetValues(typeof(TipoSexo));
            cboSexo.SelectedIndex = 0;
            dao = new DaoPersona();
        }

        private void btnGrabar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String rut = txtRut.Text;
                String nombre = txtNombre.Text;
                String apellido = txtApellido.Text;
                int edad = int.Parse(txtEdad.Text);
                TipoSexo sexo = (TipoSexo)cboSexo.SelectedItem;
                Persona p = new Persona()
                {
                    Rut = rut, Nombre = nombre, Apellido = apellido, Edad = edad, Sexo = sexo
                };
                bool resp=dao.Agregar(p);
                MessageBox.Show(resp ? "Grabo" : "No Grabo");
            }
            catch(ArgumentException exa)
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
            txtApellido.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtRut.Clear();
            cboSexo.SelectedIndex = 0;
            txtRut.Focus(); //Mover el cursor
        }
    }
}
