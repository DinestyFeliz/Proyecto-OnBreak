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

namespace vista
{
    /// <summary>
    /// Lógica de interacción para wpfMenu.xaml
    /// </summary>
    public partial class wpfMenu : Window
    {
        public wpfMenu()
        {
            InitializeComponent();
        }

        private void mnuGrabar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow grabar = new MainWindow();
            grabar.Show();
        }

        private void mnuListar_Click(object sender, RoutedEventArgs e)
        {
            wpfListar Lista = new wpfListar();
            Lista.Show();
        }

        private void mnuSalir_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
