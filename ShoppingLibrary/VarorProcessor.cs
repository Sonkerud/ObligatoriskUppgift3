using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingLibrary
{
    public class VarorProcessor
    {
        public static void AddVara(List<VarorModel> list, string name, string price)
        {
            VarorModel model = new VarorModel(
               name,
               decimal.Parse(price)
               );

            //Control if new Vara already exists. If it does - update price.
            var found = list.Any(x => x.Name.ToLower() == model.Name.ToLower());

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name.ToLower() == model.Name.ToLower())
                {
                    list[i].Price = model.Price;
                }
            }

            //If if doesn't exist. Add new Vara.
            if (!found)
            {
                list.Add(model);
            }

        }
        public static void DeleteVara(List<VarorModel> list, ListBox listBox)
        {
            list.Remove((VarorModel)listBox.SelectedItem);
        }
        public void ClearTextFields(TextBox a, TextBox b)
        {
            a.Text = "";
            b.Text = "";
        }
        //Calculate most expensive vara
        public static VarorModel MostExpensive(List<VarorModel> list)
        {
            decimal maxPrice = 0;
            VarorModel model = new VarorModel("Tom lista", 0);
            try
            {
                maxPrice = list.Max(t => t.Price);
            }
            catch (Exception)
            {
                return model;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Price == maxPrice)
                {
                    model = list[i];
                }
            }
            return model;

        }
        //Calculate cheapest vara
        public static VarorModel Cheapest(List<VarorModel> list)
        {
            decimal minPrice = 0;
            VarorModel model = new VarorModel("Tom lista", 0);
            try
            {
                minPrice = list.Min(t => t.Price);
            }
            catch (Exception)
            {
                return model;
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Price == minPrice)
                {
                    model = list[i];
                }
            }
            return model;
        }

    }
}
