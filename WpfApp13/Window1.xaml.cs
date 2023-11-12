using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp13
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

       
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string programName = textboxx.Text;

            

            try
            {
                Process.Start(programName);
 
                await Task.Delay(3000);

          
                Process[] processes = Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(programName));
                foreach (var process in processes)
                {
                   
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex.Message}");
            }
        }
    }
}
