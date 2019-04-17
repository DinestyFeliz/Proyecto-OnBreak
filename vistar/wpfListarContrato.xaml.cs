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
    /// Lógica de interacción para wpfListarContrato.xaml
    /// </summary>
    public partial class wpfListarContrato : Window
    {
        //MainWindow ma;
        wpfContrato con;

        public wpfListarContrato()
        {
            InitializeComponent();
        }

        public wpfListarContrato(MainWindow mw)
        {
            InitializeComponent();
            btnPasar.IsEnabled = false;
            //ma = mw;
            DaoContrato daocon = new DaoContrato();
            dgvListarC.ItemsSource = daocon.Listar();

        }

        public wpfListarContrato(wpfContrato cn)
        {
            InitializeComponent();
            con = cn;
            DaoContrato daocon = new DaoContrato();
            dgvListarC.ItemsSource = daocon.Listar();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            if (btnPasar.IsEnabled == false){
                MainWindow mw = new MainWindow(this);
                mw.Show();
                Close();
            }else{
                Close();
            }
            
        }

        private void btnPasar_Click(object sender, RoutedEventArgs e)
        {
            con.txtNumCon.Text = "201915041158";
            con.txtDireccion.Text = "Enrique Segoviano";
            //con.txtVigente.Text = "Si";
            //con.txtTotal.Text = "999999";
        }

        private void menuFRut_Click(object sender, RoutedEventArgs e)
        {
            wpfFiltroRut fr = new wpfFiltroRut();
            fr.ShowDialog();

            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
