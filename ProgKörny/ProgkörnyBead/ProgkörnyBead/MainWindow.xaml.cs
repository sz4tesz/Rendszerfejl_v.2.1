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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;

namespace ProgkörnyBead
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String dbConnection = @"Data Source=C:\Új mappa\Megrend.db;Version=3;";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            MainOperator main = new MainOperator();
            main.Show();
            this.Close();
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnection);
            try 
            {
                sqliteCon.Open();
                string Query = "insert into Megrendelés (id,Termék,VevőAzon,Darabszám,Összeg) values('" + this.txtId.Text + "','" + this.txtTerm.Text + "','" + this.txtVeaz.Text + "','" + this.txtnumb.Text + "','" + this.txtossz.Text + "')";
                SQLiteCommand creatcommand = new SQLiteCommand(Query,sqliteCon);
                creatcommand.ExecuteNonQuery();
                MessageBox.Show("Saved");
                sqliteCon.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnupd_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnection);
            try
            {
                sqliteCon.Open();
                string Query = "update Megrendelés set id='" + this.txtId.Text + "',Termék='" + this.txtTerm.Text + "',VevőAzon='" + this.txtVeaz.Text + "',Darabszám='" + this.txtnumb.Text + "',Összeg='" + this.txtossz.Text + "' where id='" + this.txtId.Text + "'";
                SQLiteCommand creatcommand = new SQLiteCommand(Query, sqliteCon);
                creatcommand.ExecuteNonQuery();
                MessageBox.Show("Updated");
                sqliteCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btndel_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnection);
            try
            {
                sqliteCon.Open();
                string Query = "delete from Megrendelés where id='" + this.txtId.Text + "'";
                SQLiteCommand creatcommand = new SQLiteCommand(Query, sqliteCon);
                creatcommand.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                sqliteCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
