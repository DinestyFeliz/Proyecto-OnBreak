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
            wpfListarClienteAyuda lc = new wpfListarClienteAyuda(this);
            lc.Show();
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow maw = new MainWindow(this);
            maw.Show();
            Close();
        }
    }
}
