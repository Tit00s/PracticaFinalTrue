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

namespace PracticaFinalTrue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Contra_Click(object sender, RoutedEventArgs e)
        {
            double Top = this.Top;
            double Left = this.Left;
            this.Hide();
            RecContra recContra = new RecContra
            {
                Top = Top,
                Left = Left,
            };
            recContra.Show();
        }
        public void Mostrar()
        {
            this.Show();
        }
    }
}