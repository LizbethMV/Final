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
    /// Interaction logic for compras.xaml
    /// </summary>
    public partial class compras : Window
    {
        public compras()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
                proyecto.New_bd.bdPrincipal db = new proyecto.New_bd.bdPrincipal();
            var registros = from s in db.compra 
                select s;
            dbgrid.ItemsSource= registros.ToList();


            }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Regex.IsMatch(txtpro.Text, @"^\d+$") && (Regex.IsMatch(txtduc.Text, @"^\d+$")
                && (Regex.IsMatch(txtnombre.Text, "^[a-zA-Z]+$") && (Regex.IsMatch(txtcan.Text, @"^\d+$")))))
            {
                bdPrincipal bd = new bdPrincipal();
                proyecto.New_bd.Compras rt= new proyecto.New_bd.Compras();
                rt.Idproveedor = int.Parse(txtpro.Text);
                rt.IdProducto = int.Parse(txtduc.Text);
                rt.Nombre = txtnombre.Text;
                rt.Cantidad = int.Parse(txtcan.Text);
                bd.compra.Add(rt);
                bd.SaveChanges();
                MessageBox.Show("Datos guardados exitosamente");
            }
            else
            {
                MessageBox.Show("Datos no validos");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Productos ca = new Productos();
            ca.Show();
            this.Close();
        }
        }
    }

