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
        private static ObservableCollection<VarorModel> obsList = new ObservableCollection<VarorModel>();
        private static BindingList<VarorModel> bindingList = new BindingList<VarorModel>();

        public MainWindow()
        {
            InitializeComponent();
            varorListBox.ItemsSource = bindingList;
        }

        private void AddVaraButton_Click(object sender, RoutedEventArgs e)
        {

            bool inmatning = ValidateInputClass.ValidateInput(varansNamnTextBox.Text, varansPrisTextBox.Text);

            if (inmatning)
            {
                var model = VarorProcessor.AddVara(bindingList, varansNamnTextBox.Text, varansPrisTextBox.Text);

                //for (int i = 0; i < bindingList.Count-1; i++)
                //{
                //    if ((varorListBox.Items[i] as VarorModel).Name.ToLower() == varansNamnTextBox.Text.ToLower())
                //    {
                //        (varorListBox.Items[i] as VarorModel).Price = int.Parse(varansPrisTextBox.Text);
                //    }
                //}
                DataBinding();
                ClearTextFields(varansNamnTextBox, varansPrisTextBox);
                var newList = bindingList.Where(x => x.Price > 0);
                varorListBox.ItemsSource = newList;
            }
        }

        private void DeleteVara_Click(object sender, RoutedEventArgs e)
        {
            VarorProcessor.DeleteVara(bindingList, varorListBox);
            DataBinding();
        }

        public void ClearTextFields(TextBox a, TextBox b)
        {
            a.Text = "";
            b.Text = "";
        }

        public void DataBinding()
        {
            varorListBox.ItemsSource = bindingList;
            varorListBox.DisplayMemberPath = "Display";

            var mostExpensive = VarorProcessor.MostExpensive(bindingList);
            dyrasteVara.Text = $"{mostExpensive.Name} - Pris: {mostExpensive.Price} kr";
            var cheapest = VarorProcessor.Cheapest(bindingList);
            billigasteVara.Text = $"{cheapest.Name} - Pris: {cheapest.Price} kr";
            summaTextBox.Text = $"{bindingList.Sum(x => x.Price).ToString()} kr";
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9,]+");
            e.Handled = regex.IsMatch(e.Text);
        }

    }
}
