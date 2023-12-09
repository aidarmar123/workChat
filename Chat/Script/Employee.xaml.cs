using Chat.Models;
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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chat.Script
{
    /// <summary>
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : Page
    {
        int chatId;
        public Employee(Models.Chatroom chatroom)
        {

            InitializeComponent();
            CheckBoxAdmin.Content = App.DB.Department.ToList()[0].Name;
            CheckBoxItHelp.Content = App.DB.Department.ToList()[3].Name;
            CheckBoxMarketing.Content = App.DB.Department.ToList()[2].Name;
            CheckBoxSoles.Content = App.DB.Department.ToList()[1].Name;
            App.MainWindowComponent.Title = "ChitChat";
            if (chatroom != null)
            {
                chatId = chatroom.Id;
            }


        }
        private void TBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            RefreshTable();
        }
        private void RefreshTable()
        {
            var filtredList = App.DB.Employee.ToList();
            var textSearch = TBSearch.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(textSearch))
                filtredList = filtredList.Where(x => x.Name.ToLower().Contains(textSearch)).ToList();
            if (CheckBoxAdmin.IsChecked.Value)
                filtredList=filtredList.Where(x => x.DepartmentId == 1).ToList();
            if (CheckBoxSoles.IsChecked.Value)
                filtredList = filtredList.Where(x => x.DepartmentId == 2).ToList();
            if (CheckBoxItHelp.IsChecked.Value)
                filtredList = filtredList.Where(x => x.DepartmentId == 4).ToList();
            if (CheckBoxMarketing.IsChecked.Value)
                filtredList = filtredList.Where(x => x.DepartmentId == 3).ToList();

            DGemployee.ItemsSource = filtredList.ToList();

        }
        //Selection by departments
        private void CheckBoxAdmin_Click(object sender, RoutedEventArgs e)
        {
            RefreshTable();
        }



        private void CheckBoxItHelp_Click(object sender, RoutedEventArgs e)
        {
            RefreshTable();

        }

        private void CheckBoxSoles_Click(object sender, RoutedEventArgs e)
        {
            RefreshTable();

        }

        private void CheckBoxMarketing_Click(object sender, RoutedEventArgs e)
        {
            RefreshTable();

        }

       

        private void DGemployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DGemployee.SelectedItem is Models.Employee user)
            {
                var userToChat = App.DB.EmployeeChatroom.FirstOrDefault(x => x.EmployeeId == user.Id && x.ChatroomId == chatId);
                if (chatId != 0 && userToChat == null) // нечитаемый код
                {
                    EmployeeChatroom chatroom = new EmployeeChatroom();
                    chatroom.EmployeeId = user.Id;
                    chatroom.ChatroomId = chatId;

                    App.DB.EmployeeChatroom.Add(chatroom);
                    App.DB.SaveChanges();
                    NavigationService.Navigate(new Chatroom(chatId));


                }
                else
                {
                    int chatroomId = App.DB.EmployeeChatroom.FirstOrDefault(x => x.EmployeeId == user.Id).ChatroomId;
                    NavigationService.Navigate(new Chatroom(chatroomId));
                }

            }

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.MainWindowComponent.BBack.Visibility = Visibility.Visible;
        }
    }
}


