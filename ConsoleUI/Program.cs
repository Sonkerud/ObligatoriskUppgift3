using ShoppingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        public static string priceOffVara;
        public static string nameofVara;
        public static string userInput = "Y";
            
        static void Main(string[] args)
        {
            Console.WriteLine("Din inköpslista. Lägg till vara nedan. Namnge varan 'exit' när du är färdig.");
            while (userInput != "exit")
            {
                   userInput = CreateVara();
            }
            DataOutput();
        }

        public static string CreateVara() 
        {
            Console.WriteLine("Namn på vara:  ");
            nameofVara = Console.ReadLine();
            if (nameofVara != "exit")
            {
                Console.WriteLine("Ange Pris: ");
                priceOffVara = Console.ReadLine();
                VarorProcessor.AddVara(VarorModel.listOfVaror, nameofVara, priceOffVara);
            }
            return nameofVara;
        }

        public static void DataOutput()
        {
            OutputList();
            OutputSumCheapestExpensive();
        }

        public static void OutputList()
        {
            Console.WriteLine("\nDina varor:");
            foreach (var item in VarorModel.listOfVaror)
            {
                Console.WriteLine($"{item.Name} Pris: {item.Price}");
            }
        }

        public static void OutputSumCheapestExpensive()
        {
            Console.WriteLine($"\nSumma i korgen: {VarorProcessor.Sum(VarorModel.listOfVaror)} kr");

            Console.WriteLine($"\nBilligaste vara/varor:");
            foreach (var item in VarorProcessor.Cheapest(VarorModel.listOfVaror))
            {
                Console.WriteLine($"{item.Name} - Pris: {item.Price}");
            }

            Console.WriteLine($"\nDyraste vara/varor:");
            foreach (var item in VarorProcessor.MostExpensive(VarorModel.listOfVaror))
            {
                Console.WriteLine($"{item.Name} - Pris: {item.Price}");
            }
            Console.ReadLine();
        }
    }
}
