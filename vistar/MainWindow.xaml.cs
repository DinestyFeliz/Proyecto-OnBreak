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

using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace vistar
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        //para volver a MainWindow
        public MainWindow(wpfContrato ct)
        {
            InitializeComponent();
        }

        public MainWindow(wpfListarContrato lc)
        {
            InitializeComponent();
        }

        public MainWindow(wpfCliente clien)
        {
            InitializeComponent();
        }

        public MainWindow(wpfListarClientes lcl)
        {
            InitializeComponent();
        }

        private void btnAdminCli_Click(object sender, RoutedEventArgs e)
        {
            wpfCliente cli = new wpfCliente(this);
            cli.Show();
            this.Close();
        }

        private void btnListarCli_Click(object sender, RoutedEventArgs e)
        {
            wpfListarClientes lcli = new wpfListarClientes(this);
            lcli.Show();
            Close();
        }

        private void btnAdminCon_Click(object sender, RoutedEventArgs e)
        {
            wpfContrato con = new wpfContrato(this);
            con.Show();
            this.Close();
        }

        private void btnListarCon_Click(object sender, RoutedEventArgs e)
        {
            wpfListarContrato liscon = new wpfListarContrato(this);
            liscon.Show();
            Close();
        }
    }
}
