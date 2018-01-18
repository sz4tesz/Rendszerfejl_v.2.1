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

namespace ProgkörnyBead
{
    /// <summary>
    /// Interaction logic for MainOperator.xaml
    /// </summary>
    public partial class MainOperator : Window
    {
        LogCl account;
        
        public MainOperator()
        {
            InitializeComponent();
            account = new LogCl();
            
        }

        private void btnMegr_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void btnlog_Click(object sender, RoutedEventArgs e)
        {
            Window1 main = new Window1();
            main.Show();
            this.Close();
        }

        private void btnugy_Click(object sender, RoutedEventArgs e)
        {
            Customer m = new Customer();
            m.Show();
            this.Close();
        }

        private void btnOpt_Click(object sender, RoutedEventArgs e)
        {
            BtnBack.Visibility = System.Windows.Visibility.Visible;
            btnHelp.Visibility = System.Windows.Visibility.Visible;
            btnUser.Visibility = System.Windows.Visibility.Visible;
            btnPass.Visibility = System.Windows.Visibility.Visible;
            btnlog.Visibility = System.Windows.Visibility.Hidden;
            btnOpt.Visibility = System.Windows.Visibility.Hidden;
            btnugy.Visibility = System.Windows.Visibility.Hidden;
            btnMegr.Visibility = System.Windows.Visibility.Hidden;
            
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            lbuser.Visibility = System.Windows.Visibility.Hidden;
            lbpassw.Visibility = System.Windows.Visibility.Hidden;
            TbUser.Visibility = System.Windows.Visibility.Hidden;
            TbPassW.Visibility = System.Windows.Visibility.Hidden;

            BtnBack.Visibility = System.Windows.Visibility.Hidden;
            btnHelp.Visibility = System.Windows.Visibility.Hidden;
            btnUser.Visibility = System.Windows.Visibility.Hidden;
            btnPass.Visibility = System.Windows.Visibility.Hidden;
            btnlog.Visibility = System.Windows.Visibility.Visible;
            btnOpt.Visibility = System.Windows.Visibility.Visible;
            btnugy.Visibility = System.Windows.Visibility.Visible;
            btnMegr.Visibility = System.Windows.Visibility.Visible;
        }
        //jelszó / username csere
        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            lbuser.Visibility = System.Windows.Visibility.Visible;
            lbpassw.Visibility = System.Windows.Visibility.Hidden;
            TbUser.Visibility = System.Windows.Visibility.Visible;
            TbPassW.Visibility = System.Windows.Visibility.Hidden;
            btnHelp.Visibility = System.Windows.Visibility.Hidden;
            btnUser.Visibility = System.Windows.Visibility.Hidden;
            btnPass.Visibility = System.Windows.Visibility.Hidden;
            btnlog.Visibility = System.Windows.Visibility.Hidden;
            btnOpt.Visibility = System.Windows.Visibility.Hidden;
            btnugy.Visibility = System.Windows.Visibility.Hidden;
            btnMegr.Visibility = System.Windows.Visibility.Hidden;
            BtnBack.Visibility = System.Windows.Visibility.Visible;
            btnUserGo.Visibility = System.Windows.Visibility.Visible;
           
        }

        private void btnPass_Click(object sender, RoutedEventArgs e)
        {
            lbuser.Visibility = System.Windows.Visibility.Hidden;
            lbpassw.Visibility = System.Windows.Visibility.Visible;
            TbUser.Visibility = System.Windows.Visibility.Hidden;
            TbPassW.Visibility = System.Windows.Visibility.Visible;
            btnHelp.Visibility = System.Windows.Visibility.Hidden;
            btnUser.Visibility = System.Windows.Visibility.Hidden;
            btnPass.Visibility = System.Windows.Visibility.Hidden;
            btnlog.Visibility = System.Windows.Visibility.Hidden;
            btnOpt.Visibility = System.Windows.Visibility.Hidden;
            btnugy.Visibility = System.Windows.Visibility.Hidden;
            btnMegr.Visibility = System.Windows.Visibility.Hidden;
            BtnBack.Visibility = System.Windows.Visibility.Visible;
           
            btnPassGo.Visibility = System.Windows.Visibility.Visible;
            
        }

        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.sqlite.org/about.html");
        }

        private void btnUserGo_Click(object sender, RoutedEventArgs e)
        {
            string temp = TbUser.Text;
            account.ChangeUserName(temp);
            MessageBox.Show("A Változtatás megtörtént");
        }

        private void btnPassGo_Click(object sender, RoutedEventArgs e)
        {
            string temp = TbPassW.Text;
            account.ChangePassWd(temp);
            MessageBox.Show("A Változtatás megtörtént");
        }
       
    }
}
