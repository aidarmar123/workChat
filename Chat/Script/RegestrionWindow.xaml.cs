using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Chat.Script
{
    /// <summary>
    /// Interaction logic for RegestrionWindow.xaml
    /// </summary>
    public partial class RegestrionWindow : Window
    {
        Models.Employee contextUser=new Models.Employee();
        public RegestrionWindow()
        {
            InitializeComponent();
            CBDepartment.ItemsSource=App.DB.Department.ToList();
            DataContext = contextUser;

        }

        private void BAddImage_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog() { Filter = ".png, .jpg, .jpeg | *.png; *.jpg; *.jpeg" };
            if (dialog.ShowDialog().GetValueOrDefault())
            {
                contextUser.Photo = File.ReadAllBytes(dialog.FileName);
                DataContext = contextUser;
            }
        }

        private void BOk_Click(object sender, RoutedEventArgs e)
        {
           if(Validation().Length>0)
            {
                MessageBox.Show(Validation().ToString());
            }
            else
            {
                App.DB.Employee.Add(contextUser);
                App.DB.SaveChanges();
                this.DialogResult = false;
            }
        }

        private StringBuilder Validation()
        {
            StringBuilder error = new StringBuilder();
            if (contextUser.Photo == null)
                error.AppendLine("Photo is null");
            if (contextUser.Name == null)
                error.AppendLine("Name is null");
            if (contextUser.Username == null)
                error.AppendLine("Username is null");
            if (contextUser.Password == null)
                error.AppendLine("Password is null");
            if (contextUser.DepartmentId == 0)
                error.AppendLine("Department is null");

            return error;
        }
    }
}
