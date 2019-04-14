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
    /// Lógica de interacción para wpfContrato.xaml
    /// </summary>
    public partial class wpfContrato : Window
    {
        MainWindow ma;

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

        }
    }
}
