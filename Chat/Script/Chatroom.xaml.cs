using Chat.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chat.Script
{
    /// <summary>
    /// Interaction logic for Chatroom.xaml
    /// </summary>
    public partial class Chatroom : Page
    {

        int chatId;
        Models.ChatMessage contextChatMessage = new Models.ChatMessage();
        public Chatroom(int i)
        {
            InitializeComponent();
           
            DataContext = contextChatMessage;
            chatId = i;
            DGMessage.ItemsSource = App.DB.ChatMessage.Where(x=>x.ChatroomId == chatId).ToList();
            List<EmployeeChatroom> list=App.DB.EmployeeChatroom.Where(x=> x.ChatroomId == chatId).ToList();
            DGUsers.ItemsSource = list;
            App.MainWindowComponent.Title = App.DB.Chatroom.FirstOrDefault(x => x.Id == chatId).Topic;
            
           
        }

        private void BSend_Click(object sender, RoutedEventArgs e)
        {
            var message = TBSendMessage.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                contextChatMessage.ChatroomId = chatId;
                contextChatMessage.Message = message;
                contextChatMessage.Date = DateTime.Now;
                contextChatMessage.SenderId = App.userNow.Id;
                App.DB.ChatMessage.Add(contextChatMessage);
                try
                {
                    App.DB.SaveChanges();
                    RefrreshMessage();
                    contextChatMessage = new ChatMessage();
                    TBSendMessage.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }else if (contextChatMessage.Image != null)
            {
                contextChatMessage.ChatroomId = chatId;
                contextChatMessage.Message = "";
                contextChatMessage.Date = DateTime.Now;
                contextChatMessage.SenderId = App.userNow.Id;
                App.DB.ChatMessage.Add(contextChatMessage);
                try
                {
                    App.DB.SaveChanges();
                    RefrreshMessage();
                    contextChatMessage = new ChatMessage();
                    DataContext = contextChatMessage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void RefrreshMessage()
        {
            DGMessage.ItemsSource = App.DB.ChatMessage.Where(x => x.ChatroomId == chatId).ToList();
        }

        private void BAddUser_Click(object sender, RoutedEventArgs e)
        {
            var thisChat=App.DB.Chatroom.FirstOrDefault(x=>x.Id == chatId);
            NavigationService.Navigate(new Employee(thisChat));
        }

        private void BChangeTopic_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AllChatroom(App.userNow));
            
        }

        private void BLeaveChartroom_Click(object sender, RoutedEventArgs e)
        {
            App.DB.EmployeeChatroom.Remove(App.DB.EmployeeChatroom.FirstOrDefault(x=>x.EmployeeId==App.userNow.Id));
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            App.MainWindowComponent.BBack.Visibility = Visibility.Visible;
        }

        private void BAddImage_Click(object sender, RoutedEventArgs e)
        {
            var diaolg = new OpenFileDialog() { Filter = ".png, .jpg, .jpeg | *.png; *.jpg; *.jpeg" };
            if(diaolg.ShowDialog().GetValueOrDefault())
            {
                
                contextChatMessage.Image=File.ReadAllBytes(diaolg.FileName);
                DataContext = contextChatMessage;
            }
        }
    }
}
