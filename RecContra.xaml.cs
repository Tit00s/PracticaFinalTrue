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

namespace PracticaFinalTrue
{
    /// <summary>
    /// Lógica de interacción para RecContra.xaml
    /// </summary>
    public partial class RecContra : Window
    {
        public RecContra()
        {
            InitializeComponent();

            this.Closing += ReClosing;
        }

        private void ReClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                double Top = this.Top;
                double Left = this.Left;
                MainWindow m = new MainWindow
                {
                    Top = Top,
                    Left = Left,
                };
                m.Show();  
            }));
        }

        private void enviarBtn_Click(object sender, RoutedEventArgs e)
        {

            
            MailEnviado m = new MailEnviado
            {
               Owner= this,

            };
            m.Show();
            
           
        }

        private void volverBtn_Click(object sender, RoutedEventArgs e)
        {
            
                double Top = this.Top;
                double Left = this.Left;
                MainWindow m = new MainWindow
                {
                    Top = Top,
                    Left = Left,
                };
                this.Hide();
                m.Show();
            
        }
    }
}
