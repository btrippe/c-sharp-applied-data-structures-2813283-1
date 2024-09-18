// Example file for C# Applied Data Structures by Joe Marini
// Solution for Programming Challenge

using System;
using System.Collections.Generic;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Test Code
            ShoppingList list = new ();
            list.AddItem("Milk", 2.25, 1);
            list.AddItem("Sugar", 1.75, 2);
            list.AddItem("Bread", 3.25, 1);
            list.AddItem("Butter", 4.95, 1);
            Console.WriteLine($"Items: {list.GetCount()}");

            list.PrintList();

            list.RemoveItem("Bread");
            list.RemoveItem("Sugar");
            list.AddItem("Cookies", 0.50, 4);
            list.AddItem("Oranges", 0.65, 5);
            list.AddItem("Chicken", 8.95, 1);
            Console.WriteLine($"Items: {list.GetCount()}");

            list.PrintList();
        }
    }

   

}
