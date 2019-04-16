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
    /// Lógica de interacción para wpfLisCli.xaml
    /// </summary>
    public partial class wpfLisCli : Window
    {
        wpfContrato con;

        public wpfLisCli()
        {
            InitializeComponent();
        }

        public wpfLisCli(MainWindow ma)
        {
            InitializeComponent();
        }

        //public wpfLisCli(wpfLisCli lci)
        //{
        //    InitializeComponent();
        //}

        public wpfLisCli(wpfContrato ct)
        {
            InitializeComponent();
            con = ct;
        }

        private void btnVolver_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnPasar_Click(object sender, RoutedEventArgs e)
        {
            con.txtRut.Text = "12123123-3";
        }
    }
}
