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

        //private void Button_Click2Close ( object sender, RoutedEventArgs e )
        //{

        //}
        private void Button_Click2Close ( object sender, RoutedEventArgs e )
        {
            this.Close ();

            //var ownedWindow = new ClippedWindow1 ();
            //ownedWindow.Owner = this;
            //ownedWindow.Show ();
        }
    }
}
