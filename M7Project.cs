using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //dictionary creation
        Dictionary<string, List<string>> myDict = new Dictionary<string, List<string>>();
        bool running = true; //something about keeping a loop

        while (running)
        {
            //options
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Populate dictionary");
            Console.WriteLine("2. Display contents");
            Console.WriteLine("3. Remove key");
            Console.WriteLine("4. Add new key-value pair");
            Console.WriteLine("5. Add value to existing key");
            Console.WriteLine("6. Sort keys");
            Console.WriteLine("7. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();
//big switch statements
            switch (choice)
            {
                case "1":
                    PopulateDictionary(myDict);
                    break;
                case "2":
                    DisplayDictionary(myDict);
                    break;
                case "3":
                    RemoveKey(myDict);
                    break;
                case "4":
                    AddNewKeyValue(myDict);
                    break;
                case "5":
                    AddValueToExistingKey(myDict);
                    break;
                case "6":
                    SortKeys(myDict);
                    break;
                case "7":
                    running = false; //probably closes it
                    Console.WriteLine("quit program");
                    break;
                default:
                    Console.WriteLine("Invalid choice. choose again");
                    break;
            }
        }
    }
//does the pair
    static void PopulateDictionary(Dictionary<string, List<string>> dict)
    {
        Console.Write("Key: ");
        string key = Console.ReadLine();
        Console.Write("Value: ");
        string value = Console.ReadLine();
//new list
        if (!dict.ContainsKey(key))
        {
            dict[key] = new List<string>();
        }
//adding stuff to list
        dict[key].Add(value);
        Console.WriteLine($"{value} added to key '{key}'.");
    }
//shows stuff
    static void DisplayDictionary(Dictionary<string, List<string>> dict)
    {
        Console.WriteLine("\nDictionary Contents:");
        foreach (var pair in dict)
        {
            //shows specific stuff
            Console.WriteLine($"{pair.Key}: {string.Join(", ", pair.Value)}");
        }
    }
//delete stuff
    static void RemoveKey(Dictionary<string, List<string>> dict)
    {
        Console.Write("Remove key: ");
        string key = Console.ReadLine();

        if (dict.Remove(key))
        {
            Console.WriteLine($"'{key}' removed.");
        }
        else
        {
            Console.WriteLine($"Key '{key}' not found.");
        }
    }
//add new pair stuff
    static void AddNewKeyValue(Dictionary<string, List<string>> dict)
    {
        Console.Write("New key: ");
        string key = Console.ReadLine();
        Console.Write("Value: ");
        string value = Console.ReadLine();

        //new list if no list
        if (!dict.ContainsKey(key))
        {
            dict[key] = new List<string>();
        }
//add num to list
        dict[key].Add(value);
        Console.WriteLine($"'{key}' added with value '{value}'.");
    }
//add stuff to existing keys
    static void AddValueToExistingKey(Dictionary<string, List<string>> dict)
    {
        Console.Write("Key: ");
        string key = Console.ReadLine();

        if (dict.ContainsKey(key))
        {
            Console.Write("Value: ");
            string value = Console.ReadLine();
            dict[key].Add(value);
            Console.WriteLine($"'{value}' added to key '{key}'.");
        }
        else
        {
            Console.WriteLine("Key not found.");
        }
    }
//sort stuff
    static void SortKeys(Dictionary<string, List<string>> dict)
    {
        //in ascending
        var sortedKeys = dict.Keys.OrderBy(k => k).ToList();
        Console.WriteLine("\nSorted Keys:");
        foreach (var key in sortedKeys)
        {
            Console.WriteLine(key);
        }
    }
}
