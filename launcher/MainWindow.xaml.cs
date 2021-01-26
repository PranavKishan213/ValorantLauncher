using System;
using System.Windows;
using System.Windows.Input;
using System.IO;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace launcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool detect = false;
        string filem = "D:\\txtjson.json";
        public MainWindow()
        {
            InitializeComponent();
            if (File.Exists(filem)){
                StreamReader file = File.OpenText(filem);
                JsonSerializer jsSer = new JsonSerializer();
                datanum dm = (datanum)jsSer.Deserialize(file, typeof(datanum));
                username.Text = dm.usernamecs;
                password.Password = dm.passwordcs;
                path.Text = dm.pathcs;
                detect = true;
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void SignIn(object sender, RoutedEventArgs e)
        {
            if (detect == true)
            {
                datanum dn = new datanum();
                AppMain ap = new AppMain();
                dn.usernamecs = username.Text;
                dn.passwordcs = password.Password.ToString();
                dn.pathcs = path.Text;
                this.Close();
                ap.DataReceive(dn.usernamecs, dn.passwordcs, dn.pathcs, dn.regioncs);

            }
            else
            {
                datanum dn = new datanum();
                dn.usernamecs = username.Text;
                dn.passwordcs = password.Password.ToString();
                dn.pathcs = path.Text + "\\VALORANT.lnk";
                AppMain ap = new AppMain();
                this.Close();
                ap.DataReceive(dn.usernamecs, dn.passwordcs, dn.pathcs, dn.regioncs);
                string output = JsonConvert.SerializeObject(dn, Formatting.Indented);
                Console.WriteLine(output);
                System.IO.File.WriteAllText(filem, output);
            }


        }
    }

    public class datanum
    {
        public string usernamecs { get; set; }
        public string passwordcs { get; set; }
        public string pathcs { get; set; }
        public string regioncs { get; set; }
    }
}
