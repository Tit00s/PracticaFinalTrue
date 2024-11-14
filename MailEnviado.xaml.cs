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

namespace PracticaFinalTrue
{
    /// <summary>
    /// Lógica de interacción para MailEnviado.xaml
    /// </summary>
    public partial class MailEnviado : Window
    {
        public MailEnviado()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2);  
            timer.Tick += (s, e) =>
            {
                timer.Stop();  
                this.Close();   
            };
            timer.Start(); 
        }
    }
}

