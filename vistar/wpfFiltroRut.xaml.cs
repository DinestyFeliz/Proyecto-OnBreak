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
    /// Lógica de interacción para wpfFiltroRut.xaml
    /// </summary>
    public partial class wpfFiltroRut : Window
    {
        public wpfFiltroRut()
        {
            InitializeComponent();
        }

        public wpfFiltroRut(wpfListarClientes lic)
        {
            InitializeComponent();
        }

        public wpfFiltroRut(wpfListarContrato licon)
        {
            InitializeComponent();
        }
    }
}
