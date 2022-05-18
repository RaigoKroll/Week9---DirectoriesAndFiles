using System;
using System.IO;
namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Võimaldab kasutajal luua uue kausta ja uue faili.
            //Kausta nimi on shopping list ja faili nimi MyShoppingList.txt

            string rootDirectory = @"C:\Users\Moniik\samples";
            string newDirectory = @"ShoppingList";
            string fileName = "MyShoppingList.txt";

            Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
            File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");

            Console.WriteLine(@"Folder created to C:\Users\Moniik\samples with name: ShoppingList");
            Console.WriteLine("MyShoppingList.txt file is created to folder: ShoppingList");
        }
    }
}
