using FunctionalLib;
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

namespace PR8WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Text data = new Text { TextData = Text.Text };

            Class1.Serialize(data, "data.json");

            MessageBox.Show("Данные сериализованы в файл data.json");
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            Text data = Class1.Deserialize<Text>("data.json");
            Text.Text = "";
            Text.Text = data.TextData;
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            if (App.Theme == "BlueDictionary")
            {
                App.Theme = "GreenDictionary";
            }
            else if (App.Theme == "GreenDictionary")
            {
                App.Theme = "BlueDictionary";
            }
        }
    }

    public class Text
    {
        public string TextData { get; set; }
    }
}
