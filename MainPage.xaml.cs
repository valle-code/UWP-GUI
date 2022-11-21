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
// Import vistas folder
using ProyectoUWPEV1.Vistas;

namespace ProyectoUWPEV1
{
    public sealed partial class MainPage : Page
    {
        private static int setting = 0;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {

        }
        
        private void setSettingsVisible(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            Home.Visibility = Visibility.Collapsed;
            Login.Visibility = Visibility.Collapsed; 
            Compra.Visibility = Visibility.Collapsed;
            Registro.Visibility = Visibility.Collapsed;
            right.Visibility = Visibility.Visible;
            left.Visibility = Visibility.Visible;
            up.Visibility = Visibility.Visible;
            down.Visibility = Visibility.Visible;
        }

        private void setNavigationVisible(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            Home.Visibility = Visibility.Visible;
            Login.Visibility = Visibility.Visible;
            Compra.Visibility = Visibility.Visible;
            Registro.Visibility = Visibility.Visible;
            right.Visibility = Visibility.Collapsed;
            left.Visibility = Visibility.Collapsed;
            up.Visibility = Visibility.Collapsed;
            down.Visibility = Visibility.Collapsed;
        }

        // Acción de cada botón
        private void NavigationViewControl_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            // settings
            var itemInvoked = args.InvokedItemContainer as NavigationViewItem;
            if (args.IsSettingsInvoked)
            {
                setting++;
            }

            
            if (setting % 2 == 0)
            {
                setNavigationVisible(sender, args);
            }
            else
            {
                setSettingsVisible(sender, args);
            }

            switch (itemInvoked.Tag)
            {
                case "home":
                    ContentFrame.Navigate(typeof(Home));
                    break;

                case "login":
                    ContentFrame.Navigate(typeof(Login));
                    break;

                case "registro":
                    ContentFrame.Navigate(typeof(Registro));
                    break;

                case "compra":
                    ContentFrame.Navigate(typeof(Compra));
                    break;
                    
                case "up":
                    NavigationViewControl.FlowDirection = FlowDirection.LeftToRight;
                    NavigationViewControl.PaneDisplayMode = NavigationViewPaneDisplayMode.Top;
                    break;
                    
                case "down":
                    NavigationViewControl.FlowDirection = FlowDirection.RightToLeft;
                    NavigationViewControl.VerticalAlignment = VerticalAlignment.Bottom;
                    break;

                case "left":
                    NavigationViewControl.FlowDirection = FlowDirection.LeftToRight;
                    NavigationViewControl.PaneDisplayMode = NavigationViewPaneDisplayMode.Left;
                    break;

                case "right":
                    NavigationViewControl.FlowDirection = FlowDirection.RightToLeft;
                    NavigationViewControl.PaneDisplayMode = NavigationViewPaneDisplayMode.Left;
                    break;

            }
            
        }

        // Los elementos de que se cargan 
        public void NavigationViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            Home.Visibility = Visibility.Visible;
            Login.Visibility = Visibility.Visible;
            Compra.Visibility = Visibility.Visible;
            Registro.Visibility = Visibility.Visible;
            right.Visibility = Visibility.Collapsed;
            left.Visibility = Visibility.Collapsed;
            up.Visibility = Visibility.Collapsed;
            down.Visibility = Visibility.Collapsed;
            ContentFrame.Navigate(typeof(Home));
        }

        private void NavigationViewControl_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {

        }

        // Button to go back to the last view visited
        private void NavigationViewControl_BackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (ContentFrame.CanGoBack) 
            {
                
                ContentFrame.GoBack();
            }
        }
    }
}
