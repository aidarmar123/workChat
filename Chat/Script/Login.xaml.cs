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
using Chat.Models;

namespace Chat.Script
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>

    public partial class Login : Window
    {
        bool remeberMe = false;
        public Login()
        {
            if (remeberMe)
            {
                new MainWindow().ShowDialog();
                this.DialogResult = false;
            }
            InitializeComponent();
            
        }

        private void BOk_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();

            if (TBUsername.Text == "" && PBPassword.Text == "")
            {
                error.Append("Line are empty");
            }
            else if (App.DB.Employee.FirstOrDefault(x => x.Username == TBUsername.Text && x.Password == PBPassword.Text) != null)
            {
                Models.Employee user = App.DB.Employee.FirstOrDefault(x => x.Username == TBUsername.Text && x.Password == PBPassword.Text);
                App.userNow = user;
                this.DialogResult = false;
                
                
            }
            else
            {
                error.Append("User is not found");
            };
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString());
            }
        }
        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            remeberMe = !remeberMe;
        }

        

        private void BRegestration_Click(object sender, RoutedEventArgs e)
        {
            new RegestrionWindow().ShowDialog();
        }
    }
}
