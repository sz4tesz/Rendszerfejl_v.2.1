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
using System.Data.SQLite;

namespace ProgkörnyBead
{
    /// <summary>
    /// Interaction logic for Customer.xaml
    /// </summary>
    public partial class Customer : Window
    {
        public Customer()
        {
            InitializeComponent();
        }
        String dbConnection = @"Data Source=C:\Új mappa\Megrend.db;Version=3;";
        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            MainOperator main = new MainOperator();
            main.Show();
            this.Close();
        }
        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnsave_Click_1(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnection);
            try
            {
                sqliteCon.Open();
                string Query = "insert into Ügyfél (id,név,Azonosító,Telefon,Email) values('" + this.txtId.Text + "','" + this.txtName.Text + "','" + this.txtazon.Text + "','" + this.txtphone.Text + "','" + this.txtEmail.Text + "')";
                SQLiteCommand creatcommand = new SQLiteCommand(Query, sqliteCon);
                creatcommand.ExecuteNonQuery();
                MessageBox.Show("Saved");
                sqliteCon.Close();
            }
            catch (Exception ex)
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
                string Query = "update Ügyfél set id='" + this.txtId.Text + "',név='" + this.txtName.Text + "',Azonosító='" + this.txtazon.Text + "',Telefon='" + this.txtphone.Text + "',Email='" + this.txtEmail.Text + "' where id='" + this.txtId.Text + "'";
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
                string Query = "delete from Ügyfél where id='" + this.txtId.Text + "'";
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
