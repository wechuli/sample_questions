using System;
using System.Collections.Generic;

namespace LinkedListHelperLib
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicList<char> shoppingList = new DynamicList<char>();
            
            shoppingList.Add('E');
            shoppingList.Add('B'); 
            shoppingList.Add('E');
            shoppingList.Add('E');
            shoppingList.Add('B');
            shoppingList.Add('A');
            shoppingList.Add('B');
       
            
            Console.WriteLine("Input");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.Write($" {shoppingList[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(shoppingList.Count);
            LinkedListHelpers.RemoveNodesRepeatingMoreThanTwoTimes(shoppingList);

            Console.WriteLine();
            Console.WriteLine("Output");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.Write($" {shoppingList[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(shoppingList.Count);
        }
    }
}
