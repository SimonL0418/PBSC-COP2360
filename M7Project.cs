using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> myDict = new Dictionary<string, List<string>>();
        bool running = true;

        while (running)
        {
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
                    running = false;
                    Console.WriteLine("quit program");
                    break;
                default:
                    Console.WriteLine("Invlalid choice. choose again");
                    break;
            }
        }
    }

    static void PopulateDictionary(Dictionary<string, List<string>> dict)
    {
        Console.Write("Key: ");
        string key = Console.ReadLine();
        Console.Write("Value: ");
        string value = Console.ReadLine();

        if (!dict.ContainsKey(key))
        {
            dict[key] = new List<string>();
        }

        dict[key].Add(value);
        Console.WriteLine($"{value} added to key '{key}'.");
    }

    static void DisplayDictionary(Dictionary<string, List<string>> dict)
    {
        Console.WriteLine("\nDictionary Contents:");
        foreach (var pair in dict)
        {
            Console.WriteLine($"{pair.Key}: {string.Join(", ", pair.Value)}");
        }
    }

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

    static void AddNewKeyValue(Dictionary<string, List<string>> dict)
    {
        Console.Write("New key: ");
        string key = Console.ReadLine();
        Console.Write("Value: ");
        string value = Console.ReadLine();

        if (!dict.ContainsKey(key))
        {
            dict[key] = new List<string>();
        }

        dict[key].Add(value);
        Console.WriteLine($"'{key}' added with value '{value}'.");
    }

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

    static void SortKeys(Dictionary<string, List<string>> dict)
    {
        var sortedKeys = dict.Keys.OrderBy(k => k).ToList();
        Console.WriteLine("\nSorted Keys:");
        foreach (var key in sortedKeys)
        {
            Console.WriteLine(key);
        }
    }
}
