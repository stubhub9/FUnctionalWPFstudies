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

namespace BindingExamples
{
    /// <summary>
    /// Interaction logic for ClippedWindow1.xaml
    /// </summary>
    public partial class ClippedWindow1 : Window
    {
        public ClippedWindow1()
        {
            InitializeComponent();
        }


        private void Button_Click2Close ( object sender, RoutedEventArgs e )
        {
            this.Close ();

            //var ownedWindow = new ClippedWindow1 ();
            //ownedWindow.Owner = this;
            //ownedWindow.Show ();
        }


        //private void Button_Click3OnHover ( object sender, RoutedEventArgs e )
        //{
        //    var _button = sender;

        //    SolidColorBrush _hoverBrush = new SolidColorBrush
        //        ( Color.FromArgb ( 120, 255, 0, 0 ) );



        //    //          _button.
        //}

        //private void IsMouseDirectlyOverChanged ( object sender, DependencyPropertyChangedEventArgs e )
        //{
        //    //  Generated from XAML Event toolbox

        //    //Button closeButton = e.Source as Button;
        //    Button closeButton = sender as Button;

        //    closeButton.Background = 
        //        new SolidColorBrush ( Color.FromArgb ( 120, 255, 0, 0 ) );


        //}

        private void Button_Click3OnHover ( object sender, DependencyPropertyChangedEventArgs e )
        {
            var _button = (Button)  sender;
            _button.Background =
                new SolidColorBrush ( Color.FromArgb ( 120, 255, 0, 0 ) );



        }

        private void MouseEnterCloseButton ( object sender, MouseEventArgs e )
        {
            var _button = (Button)sender;
            _button.Background =
                new SolidColorBrush ( Color.FromArgb ( 120, 255, 0, 0 ) );


        }
    }
}
