using ShoppingListApp;
using System;
using System.Collections.Generic;
class Program
{
    static List<Store> stores = new List<Store>();

    static void Main()
    {
        ////Console.Clear();
        bool runningApp = true;

        Console.WriteLine("~~*==== Shopping List App ====*~~");
        Console.WriteLine("\nWelcome to the Shopping List App! Organize all your shopping essentials in one place!");
        Console.WriteLine("\nPlease select from one of the following options:");


        while (runningApp)
        {
            Console.WriteLine("\n1) ADD a new Shopping List.");
            Console.WriteLine("2) VIEW list by Store.");
            Console.WriteLine("3) REMOVE list by Store.");
            Console.WriteLine("4) SEARCH list by Store.");
            Console.WriteLine("5) EXIT the application.");

            Console.Write("\nChoose an option: ");
            string optionChoice = Console.ReadLine();

            switch (optionChoice)
            {
                case "1":
                    AddShoppingList();
                    break;

                case "2":
                    ViewListByStore();
                    break;

                case "3":
                    SearchListByStore();
                    break;

                case "4":
                    RemoveListByStore();
                    break;

                case "5":
                    runningApp = false;
                    Console.WriteLine("\nShopping List will now exit. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option choice. Please try again.");
                    break;


            }
        }
    }

    static void AddShoppingList()
    {
        Console.WriteLine("\nWill display AddShoppingList features.");
    }

    static void ViewListByStore()
    {
        Console.WriteLine("\nWill display ViewListByStore features.");
    }

    static void SearchListByStore() 
    {
        Console.WriteLine("\nWill display SearchListByStore features.");
    }

    static void RemoveListByStore() 
    {
        Console.WriteLine("\nWill display RemoveListByStore features.");
    }

}