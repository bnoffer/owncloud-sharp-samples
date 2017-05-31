using System.Windows;

using owncloudsharp;

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
            ocClient = new Client("https://octest.myvpx.de/owncloud91", "test1", "8cs!38s");
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var result = ocClient.List("");

            textBox.Text = "Connected! User has " + result.Count + " files and folders in his home directory";
        }
    }
}
