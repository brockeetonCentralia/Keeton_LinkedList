//Broc Keeton
//IT113
//NOTES:
//BEHAVIORS NOT IMPLIMENTED AND WHY:
using Keeton_linkedlist;

LinkedList MyList = new LinkedList();

Menu();

void Menu()
{
    Console.WriteLine("Menu");
    Console.WriteLine("1: Add Name");
    Console.WriteLine("2: Remove Name");
    Console.WriteLine("3: Search for Name");
    Console.WriteLine("4: Print All Names");
    Console.WriteLine("5: Exit");

    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Type Name: ");
            string a = Console.ReadLine();
            MyList.Add(a);
            Menu();
            break;

        case "2":
            Console.WriteLine("Type Name: ");
            string b = Console.ReadLine();
            MyList.Remove(b);
            Menu();
            break;

        case "3":
            Console.WriteLine("Type Name: ");
            string c = Console.ReadLine();
            MyList.Contains(c);
            Menu();
            break;

        case "4":
            MyList.PrintAllNodes();
            Menu();
            break;

        case "5":
            Console.WriteLine("Exiting...");
            Thread.Sleep(600);
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Please select from list.");
            Menu();
            break;
    }

}