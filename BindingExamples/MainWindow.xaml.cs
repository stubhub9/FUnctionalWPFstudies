using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BindingExamples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent ();

            //  Error, can't be first window shown.
            //var ownedWindow = new EmployeeView ();
            //ownedWindow.Owner = this;
            //ownedWindow.Show ();
        }

        private void Button_Click ( object sender, RoutedEventArgs e )
        {

            var ownedWindow = new EmployeeView ();
            ownedWindow.Owner = this;
            ownedWindow.Show ();
        }


        private void Button_Click2 ( object sender, RoutedEventArgs e )
        {

            var ownedWindow = new ClippedWindow1 ();
            ownedWindow.Owner = this;
            ownedWindow.Show ();
        }

        private void Button_Click3 ( object sender, RoutedEventArgs e )
        {

            var ownedWindow = new DrawingWindow ();
            ownedWindow.Owner = this;
            ownedWindow.Show ();
        }

        private void Button_Click4 ( object sender, RoutedEventArgs e )
        {

            var ownedWindow = new SplashXamlWindow ();
            ownedWindow.Owner = this;
            ownedWindow.Show ();
        }

        private void Button_Click5 ( object sender, RoutedEventArgs e )
        {

            var ownedWindow = new PathAnimations ();
            ownedWindow.Owner = this;
            ownedWindow.Show ();
        }



    }
}