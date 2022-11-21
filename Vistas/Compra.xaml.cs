using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace ProyectoUWPEV1.Vistas
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Compra : Page
    {
        private int cantidad = 0;
        
        public Compra()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {
            
        }
        
        // Incrementar contador al añadir al carrito
        private void btnAñadir1_Click(object sender, RoutedEventArgs e)
        {
            cantidad++;
            
            bckCircle.Visibility = Visibility.Visible;
            txtCantidad.Text = cantidad.ToString();
            txtCantidad.Visibility = Visibility.Visible;
            
        }

        private void btnAñadir2_Click(object sender, RoutedEventArgs e)
        {
            cantidad++;
           
            bckCircle.Visibility = Visibility.Visible;
            txtCantidad.Text = cantidad.ToString();
            txtCantidad.Visibility = Visibility.Visible;
            
        }

        private void btnAñadir3_Click(object sender, RoutedEventArgs e)
        {
            cantidad++;
           
            bckCircle.Visibility = Visibility.Visible;
            txtCantidad.Text = cantidad.ToString();
            txtCantidad.Visibility = Visibility.Visible;
           
        }
    }
}
