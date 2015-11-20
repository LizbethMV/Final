using proyecto.New_bd;
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
using System.Text.RegularExpressions;

namespace proyecto
{
    /// <summary>
    /// Interaction logic for Productos.xaml
    /// </summary>
    public partial class Productos : Window
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(txtnombre.Text, "^[a-zA-Z]+$") && (Regex.IsMatch(txtca.Text, "^[a-zA-Z]+$") && (Regex.IsMatch(txtpre.Text, @"^\d+$"))))
            {
                bdPrincipal db = new bdPrincipal();
                proyecto.New_bd.inven od = new proyecto.New_bd.inven();
                od.NombreProducto = txtnombre.Text;
                od.Categoria = txtca.Text;
                od.precio = int.Parse(txtpre.Text);
                db.invens.Add(od);
                db.SaveChanges();
            }
            else { MessageBox.Show("Datos correctamente"); }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            compras ras = new compras();
            ras.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Productos rt = new Productos();
            rt.Show();
            this.Close();
        }
    }
}
