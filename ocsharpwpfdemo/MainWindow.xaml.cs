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

using owncloudsharp;
using owncloudsharp.Types;

namespace ocsharpwpfdemo
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Client ocClient;

        public MainWindow()
        {
            InitializeComponent();
            ocClient = new Client("https://octest.myvpx.de/owncloud91", "admin", "OcTest2017!");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var result = ocClient.List("");

            textBox.Text = "Connected! User has " + result.Count + " files and folders in his home directory";
        }
    }
}
