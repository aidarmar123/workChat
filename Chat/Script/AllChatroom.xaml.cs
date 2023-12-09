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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chat.Script
{
    /// <summary>
    /// Interaction logic for AllChatroom.xaml
    /// </summary>
    public partial class AllChatroom : Page
    {
     
        public AllChatroom(Models.Employee user)
        {
            InitializeComponent();
            
            List<int> idChats= new List<int> ();
            if (App.userNow == null)
            {
                App.MainWindowComponent.Close();
            }
            else
            {
                DGChats.ItemsSource = App.DB.EmployeeChatroom.Where(x => x.EmployeeId == App.userNow.Id).ToList();

                TBHello.Text = "Hello " + user.Name;
                DataContext = user;

                App.MainWindowComponent.Title = "ChitChat";
            }
               
         
           

          

        }

        private void BEmployeeFinder_Click(object sender, RoutedEventArgs e)
        {
       
            NavigationService.Navigate(new Employee(null));
        }

        private void BClose_Click(object sender, RoutedEventArgs e)
        {
            App.MainWindowComponent.Close();
        }

       

        private void DGChats_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DGChats.SelectedItem is EmployeeChatroom chatMessage)
            {
                var thisChat = App.DB.Chatroom.FirstOrDefault (x => x.Id== chatMessage.ChatroomId); 
                NavigationService.Navigate(new Chatroom(thisChat.Id));
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.MainWindowComponent.BBack.Visibility = Visibility.Collapsed;
        }
    }
}
