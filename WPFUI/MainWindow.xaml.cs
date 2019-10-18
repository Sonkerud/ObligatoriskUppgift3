using ShoppingLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddVaraButton_Click(object sender, RoutedEventArgs e)
        {

            bool inmatning = ValidateInputClass.ValidateInput(varansNamnTextBox.Text, varansPrisTextBox.Text);

            if (inmatning)
            {
                VarorProcessor.AddVara(VarorModel.listOfVaror, varansNamnTextBox.Text, varansPrisTextBox.Text);
                DataBinding(VarorModel.listOfVaror);
                ClearTextFields(varansNamnTextBox, varansPrisTextBox);
                var newList = VarorModel.listOfVaror.Where(x => x.Price > 0);
                varorListBox.ItemsSource = newList;
            }
        }

        private void DeleteVara_Click(object sender, RoutedEventArgs e)
        {
            VarorProcessor.DeleteVara(VarorModel.listOfVaror, varorListBox);
            DataBinding(VarorModel.listOfVaror);
            var newList = VarorModel.listOfVaror.Where(x => x.Price > 0);
            varorListBox.ItemsSource = newList;
        }

        private void ClearTextFields(TextBox a, TextBox b)
        {
            a.Text = "";
            b.Text = "";
        }

        private void DataBinding(List<VarorModel> list)
        {
            varorListBox.ItemsSource =list;
            varorListBox.DisplayMemberPath = "Display";

            var mostExpensive = VarorProcessor.MostExpensiveModel(list);
            dyrasteVara.Text = $"{mostExpensive.Name} - Pris: {mostExpensive.Price} kr";
            var cheapest = VarorProcessor.CheapestModel(list);
            billigasteVara.Text = $"{cheapest.Name} - Pris: {cheapest.Price} kr";
            summaTextBox.Text = $"{VarorProcessor.Sum(list).ToString()} kr";
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
