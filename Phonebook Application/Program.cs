using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("Phonebook Application");
            Console.WriteLine("Press 1. for Add Contact");
            Console.WriteLine("Press 2. for Search Contact");
            Console.WriteLine("Press 3. for Delete Contact");
            Console.WriteLine("Press 4. for Exit");

            Console.Write("Enter your choice: ");
            int choice;

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Try again");
                Console.WriteLine();
                continue;
            }

            switch (choice)
            {
                case 1:
                    Add(phonebook);
                    break;
                case 2:
                    Search(phonebook);
                    break;
                case 3:
                    Delete(phonebook);
                    break;
                case 4:
                    Console.WriteLine("Bye!");
                    return;
            }
        }
    }

    static void Add(Dictionary<string, string> a)
    {
        Console.Write("Enter the name of the contact: ");
        string name = Console.ReadLine();

        if (a.ContainsKey(name))
        {
            Console.WriteLine("Contact already exists.");
            return;
        }

        Console.Write("Enter the phone number: ");
        string phoneNumber = Console.ReadLine();

        a[name] = phoneNumber;
        Console.WriteLine("Contact added successfully.");
    }

    static void Search(Dictionary<string, string> a)
    {
        Console.Write("Enter the name of the contact to search: ");
        string name = Console.ReadLine();

        if (a.ContainsKey(name))
        {
            Console.WriteLine($"Name: {name}, Phone Number: {a[name]}");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    static void Delete(Dictionary<string, string> a)
    {
        Console.Write("Enter the name of the contact to delete: ");
        string name = Console.ReadLine();

        if (a.ContainsKey(name))
        {
            a.Remove(name);
            Console.WriteLine("Contact deleted.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
}

