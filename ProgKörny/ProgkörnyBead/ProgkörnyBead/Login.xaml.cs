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
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Threading;

namespace ProgkörnyBead
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        LogCl account;
        
        public BackgroundWorker bw = new BackgroundWorker();
        public Window1()
        {
            
            InitializeComponent();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
            account = new LogCl();
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                lblfrgtPass.Visibility = Visibility.Visible;
                lblfrgtPass.Content = "Canceled!";
            }

            else if (!(e.Error == null))
            {
                lblfrgtPass.Visibility = Visibility.Visible;
                lblfrgtPass.Content = "Error: " + e.Error.Message;
            }
            else
            {
                lblLoading.Visibility = Visibility.Hidden;
                lblfrgtPass.Visibility = Visibility.Visible;
                lblfrgtPass.Content = "Sikeres Belépés";
                Mouse.OverrideCursor = null;
                txtBxuserName.IsEnabled = true;
                passBxPassword.IsEnabled = true;
                btnLogin.IsEnabled = true;
            }
        }
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(3500);
        }
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
        }
        
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            String userName = txtBxuserName.Text.ToLower();
            string pass = passBxPassword.Password;
            lblfrgtPass.Visibility = Visibility.Hidden;
            lblLoading.Visibility = Visibility.Visible;
            Mouse.OverrideCursor = Cursors.Wait;
            txtBxuserName.IsEnabled = false;
            passBxPassword.IsEnabled = false;
            btnLogin.IsEnabled = false;
            if (account.Username == txtBxuserName.Text && account.Password == passBxPassword.Password)
            {
                
                if (bw.IsBusy == false)
                {
                    bw.RunWorkerAsync();
                }

                MainOperator main = new MainOperator();
                main.Show();
                this.Close();
                
               
            }
            else
            {
                lblLoading.Visibility = Visibility.Hidden;
                lblfrgtPass.Visibility = Visibility.Visible;
                lblfrgtPass.Content = "Hibás kód!";
                txtBxuserName.IsEnabled = true;
                txtBxuserName.BorderBrush = Brushes.Red;
                passBxPassword.IsEnabled = true;
                passBxPassword.BorderBrush = Brushes.Red;
                btnLogin.IsEnabled = true;
                Mouse.OverrideCursor = null;
            }
        }
        private void Window_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void btnLeave_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
        
    }
}
