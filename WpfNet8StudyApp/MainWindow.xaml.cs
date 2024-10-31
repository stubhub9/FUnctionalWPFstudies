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

namespace WpfNet8StudyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent ();
        }

        private void ButtonAddName_Click ( object sender, RoutedEventArgs e )
        {
            //  Validator:  textbox contains an original name
            //              Add name to listbox

            //  x:Name txtName is a XAML textbox
            //          lstNames is a XAML listbox
            //          
            if (!string.IsNullOrWhiteSpace (txtName.Text)
                && !lstNames.Items.Contains ( txtName.Text ))
            {
                lstNames.Items.Add ( txtName.Text );
                txtName.Clear ();
            }

        }
    }
}