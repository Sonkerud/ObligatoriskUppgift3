using ShoppingLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private static ObservableCollection<VarorModel> obsList = new ObservableCollection<VarorModel>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddVaraButton_Click(object sender, RoutedEventArgs e)
        {

            bool inmatning = ValidateInputClass.ValidateInput(varansNamnTextBox.Text, varansPrisTextBox.Text);

            if (inmatning) 
            { 
                var model = VarorProcessor.AddVara(obsList, varansNamnTextBox.Text, varansPrisTextBox.Text);
                DataBinding();
                ClearTextFields(varansNamnTextBox, varansPrisTextBox);
            }
        }

        private void DeleteVara_Click(object sender, RoutedEventArgs e)
        {
            VarorProcessor.DeleteVara(obsList, varorListBox);
            DataBinding();
        }

        public void ClearTextFields(TextBox a, TextBox b)
        {
            a.Text = "";
            b.Text = "";
        }

        public void DataBinding()
        {
            varorListBox.ItemsSource = obsList;
            varorListBox.DisplayMemberPath = "Display";

            var mostExpensive = VarorProcessor.MostExpensive(obsList);
            dyrasteVara.Text = $"{mostExpensive.Name} {mostExpensive.Price} kr";
            var cheapest = VarorProcessor.Cheapest(obsList);
            billigasteVara.Text = $"{cheapest.Name} {cheapest.Price} kr";
            summaTextBox.Text = $"{obsList.Sum(x => x.Price).ToString()} kr";
                                 
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
