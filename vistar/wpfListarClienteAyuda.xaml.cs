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
    /// Lógica de interacción para wpfListarClienteAyuda.xaml
    /// </summary>
    public partial class wpfListarClienteAyuda : Window
    {

        wpfCliente cl; //no se porqué me da error si antes funcionaba (AAahhhh)

        public wpfListarClienteAyuda()
        {
            InitializeComponent();
        }

        public wpfListarClienteAyuda(wpfCliente clien)
        {
            InitializeComponent();
            clien = cl;
        }

        private void btnPasar_Click(object sender, RoutedEventArgs e)
        {
            cl.txtRut.Text = "12122122";
        }
    }
}
