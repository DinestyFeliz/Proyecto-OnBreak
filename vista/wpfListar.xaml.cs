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
using BibliotecaControlador;

namespace vista
{
    /// <summary>
    /// Lógica de interacción para wpfListar.xaml
    /// </summary>
    public partial class wpfListar : Window
    {
        public wpfListar()
        {
            InitializeComponent();
            try
            {
                DaoPersona dao = new DaoPersona();
                dgvListar.ItemsSource = dao.Lista();
                dgvListar.Items.Refresh();
            }
            catch (Exception ex)
            {

                Logger.Mensaje(ex.Message);
            }
        }
    }
}
