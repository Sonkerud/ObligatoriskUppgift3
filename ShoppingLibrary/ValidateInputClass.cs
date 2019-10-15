using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ShoppingLibrary
{
    public class ValidateInputClass
    {
        public static bool ValidateInput(string name, string price)
        {
            if (name.Length == 0)
            {
                MessageBox.Show("Fyll i namn på vara");
                return false;
            }

            else if (price.Length == 0)
            {
                MessageBox.Show("Fyll i pris på vara");
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
