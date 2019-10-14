using ShoppingLibrary;
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

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<VarorModel> varorList = new List<VarorModel>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddVaraButton_Click(object sender, RoutedEventArgs e)
        {
            dyrasteVara.Text = "Dyrt";
        }

        private void deleteVara_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
