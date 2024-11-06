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
using System.Windows.Threading;

namespace BindingExamples
{
    /// <summary>
    /// Interaction logic for SplashXamlWindow.xaml
    /// </summary>
    public partial class SplashXamlWindow : Window
    {
        public SplashXamlWindow ()
        {
            InitializeComponent ();
        }

        private void CreateAndShowMainWindow ()
        {
            Window mainWindow = this;
            // Create the application's main window
            //mainWindow = new Window ();

            // Create a canvas sized to fill the window
            Canvas myCanvas = new Canvas ();
            myCanvas.Background = Brushes.LightSteelBlue;

            // Add a "Hello World!" text element to the Canvas
            TextBlock txt1 = new TextBlock ();
            txt1.FontSize = 14;
            txt1.Text = "Hello World!";
            Canvas.SetTop ( txt1, 100 );
            Canvas.SetLeft ( txt1, 10 );
            myCanvas.Children.Add ( txt1 );

            // Add a second text element to show how absolute positioning works in a Canvas
            TextBlock txt2 = new TextBlock ();
            txt2.FontSize = 22;
            txt2.Text = "Isn't absolute positioning handy?";
            Canvas.SetTop ( txt2, 200 );
            Canvas.SetLeft ( txt2, 75 );
            myCanvas.Children.Add ( txt2 );
            mainWindow.Content = myCanvas;
            mainWindow.Title = "Canvas Sample";
            //mainWindow.Show ();


            Task.Delay ( 4000 ).ContinueWith ( _ =>
            {

                /*      Causes error ?? Task is async and error is about changing the title of an object on a different thread??
                 * 
                                Window mainWindow = this;

                                mainWindow.Title = "and now done";



                ********************
                *
                *Method 3: The .NET 4.5 way, use async/await

        // we need to add the async keyword to the method signature
        public async void TheEnclosingMethod()
        {
            tbkLabel.Text = "two seconds delay";

           await Task.Delay(2000);
           var page = new Page2();
          page.Show();
            }

                */


            } );

            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds ( 3 )
            };
            timer.Start ();
            timer.Tick += ( sender, args ) =>
            {
                timer.Stop ();

                mainWindow.Title = "and now done";
                mainWindow.Height = 200;
                mainWindow.Background = new SolidColorBrush ( Colors.Red );
                //  BG is buried by child content of canvas..
                Grid myGrid = new Grid ();
                mainWindow.Content = myGrid;
            };


        }




        private void Window_Loaded ( object sender, RoutedEventArgs e )
        {
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds ( 2 )
            };
            timer.Start ();
            timer.Tick += ( sender, args ) =>
            {
                timer.Stop ();

                CreateAndShowMainWindow ();
            };

        }
    }
}
