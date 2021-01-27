using System;
using System.Collections.Generic;
using System.Diagnostics;
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
/// <summary>
/// Interaction logic for Window1.xaml
/// </summary>
/// 
using System.Windows.Navigation;

namespace launcher
{
    public partial class AppMain : Window
    {
        string mainUser, mainPass;
        public AppMain()
        {
            InitializeComponent();
        }
        public void DataReceive(string user, string pass)
        {
            mainUser = user;
            mainPass = pass;
            Console.WriteLine("The username, password and path entered is: " + mainUser + ", " + mainPass);
        }

        public void StartGame(object sender, RoutedEventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.FileName = "C:\\ProgramData\\Microsoft\\Windows\\Start Menu\\Programs\\Riot Games\\VALORANT.lnk";
            proc.Start();
            this.WindowState = WindowState.Minimized;

        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        private void News_Loaded(object sender, RoutedEventArgs e)
        {
            Browser.Load("https://runitback.gg/");

        }

        private void Leaderboard(object sender, RoutedEventArgs e)
        {
            Browser.Load("https://blitz.gg/valorant/leaderboards/general");
        }

        private void guides(object sender, RoutedEventArgs e)
        {
            Browser.Load("https://blitz.gg/valorant/guides");
        }

        private void valtrack(object sender, RoutedEventArgs e)
        {
            Browser.Load("https://blitz.gg/valorant");        
        }

        private void abt(object sender, RoutedEventArgs e)
        {
            Browser.Load("https://about.bss.design/");
        }

        private void ex(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
