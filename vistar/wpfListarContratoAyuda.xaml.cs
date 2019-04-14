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
    /// Lógica de interacción para wpfListarContratoAyuda.xaml
    /// </summary>
    public partial class wpfListarContratoAyuda : Window
    {
        wpfContrato cont;

        public wpfListarContratoAyuda()
        {
            InitializeComponent();
        }

        public wpfListarContratoAyuda(wpfContrato ct)
        {
            InitializeComponent();
            ct = cont;
        }

        private void btnPasar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
