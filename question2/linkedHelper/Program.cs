using System;
using System.Collections.Generic;

namespace linkedHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList<string> shoppingList = new DynamicList<string>();
            shoppingList.Add("Milk");
            shoppingList.Add("Milk"); //Empty List
            shoppingList.Add("Milk");
            shoppingList.Add("Honey");
            shoppingList.Add("Olives");
            shoppingList.Add("Water");

            for (var i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }


        }
    }
}
