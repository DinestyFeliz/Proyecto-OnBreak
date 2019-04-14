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

        public wpfListarClientes()
        {
            InitializeComponent();
        }

        public wpfListarClientes(MainWindow mawin)
        {
            InitializeComponent();
            ma = mawin;
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow(this);
            main.Show();
            Close();
        }
    }
}
