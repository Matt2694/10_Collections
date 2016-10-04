using System;
using _10_Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Program
{
    class Program
    {
        Portfolio portfolio = new Portfolio();
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            bool running = true;
            string choice = "";
            ShowMenu();
            string name;
            double pps;
            double nos;
            double totalValue;

            do
            {
                
                choice = GetUserChoice();
                switch (choice)
                {
                    case "2": IList<IAsset> assets = portfolio.GetAssetsSortedByName(); Console.WriteLine("Stocks sorted"); Console.WriteLine("Press any key to continue..."); Console.ReadKey(); break;
                    case "1": name = GetName(); pps = GetPPS(); nos = GetNoS(); Stock newStock = new Stock(name, pps, nos); portfolio.AddAsset(newStock); Console.WriteLine("Stock added"); Console.WriteLine("Press any key to continue..."); Console.ReadKey(); break;
                    case "3": PrintStocks(); Console.WriteLine("Press any key to continue..."); Console.ReadKey(); break;
                    case "4": totalValue = portfolio.GetTotalValue(); Console.WriteLine("The total value is " + totalValue.ToString()); Console.WriteLine("Press any key to continue..."); Console.ReadKey(); break;
                    case "9": running = false; break;
                }
                Console.Clear();
            } while (running);
        }

        private void PrintStocks()
        {
            IList<IAsset> stocks = portfolio.GetAssets();
            foreach(IAsset stock in stocks)
            {
                Console.WriteLine(stock.ToString());
            }
        }

        private double GetNoS()
        {
            Console.WriteLine("How many stocks do you have?");
            string input = Console.ReadLine();
            return Convert.ToDouble(input);
        }

        private double GetPPS()
        {
            Console.WriteLine("What is the value of one stock?");
            string input = Console.ReadLine();
            return Convert.ToDouble(input);
        }

        private string GetName()
        {
            Console.WriteLine("What is the name of your stock?");
            return Console.ReadLine();
        }

        private string GetUserChoice()
        {
            Console.WriteLine("Type 1 to add\nType 2 to sort\nType 3 to print\nType 4 to get a total value of all of your stocks\nType 9 at any time to end the program\nWhat would you like to do?");
            string input = Console.ReadLine();
            if(input == "1" || input == "2" || input == "3" || input == "4" || input == "9"){

                return input;
            }
            else
            {
                return null;
                throw new ArgumentException("Invalid input");
            }
        }

        private void ShowMenu()
        {
            Console.WriteLine("This program will add and sort stocks\n");
        }
    }
}
