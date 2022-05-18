using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyShoppingListFile
{
    class Program
    {
        static void Main(string[] args)

        //Konsooliäpp, mis lubab või võimaldab kasutajal lisada neid asju MyShoppingList faili
        {
            string fileLocation = @"C:\Users\Moniik\samples\ShoppingList";
            string fileName = @"\\MyShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a item to your shopping list? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your item:");
                    string userItem = Console.ReadLine();
                    myShoppingList.Add(userItem);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Have a nice day!");
                }

            }
            Console.Clear();

            foreach (string item in myShoppingList)
            {
                Console.WriteLine($"Your item: {item}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myShoppingList);
        }
    }
}

