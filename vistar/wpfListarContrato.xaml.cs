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
    /// Lógica de interacción para wpfListarContrato.xaml
    /// </summary>
    public partial class wpfListarContrato : Window
    {
        MainWindow ma;

        public wpfListarContrato()
        {
            InitializeComponent();
        }

        public wpfListarContrato(MainWindow mw)
        {
            InitializeComponent();
            ma = mw;
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow(this);
            mw.Show();
            Close();
        }
    }
}
