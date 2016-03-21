using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PW3_ResourceSystem
{
    class DVD : Resources
    {
        List<string> dvdTitles = new List<string>() {"1. Boondock Saints", "2. Rush Hour", "3. Star Wars" };

        Dictionary<string, int> studentID = new Dictionary<string, int>()
        { {"Bob Jones", 00120 }, {"Chad Lego", 00121 }, {"Dale Earnie", 00122 }, {"Jack Johnson", 00123 }, {"Ricky Bobby", 00124 } };
        List<string> bobJones = new List<string>() { };
        List<string> chadLego = new List<string>() { };
        List<string> daleEarnie = new List<string>() { };
        List<string> jackJohnson = new List<string>() { };
        List<string> rickyBobby = new List<string>() { };
        List<string> checkedOutTitles = new List<string>() { };
        List<string> availaleTitles = new List<string>() { };

        public string printAll()
        {
            StringBuilder build = new StringBuilder();
            build.Append(dvdTitles.ElementAt(0));
            build.Append("(DVD)");
            build.AppendLine();
            build.Append(dvdTitles.ElementAt(1));
            build.Append("(DVD)");
            build.AppendLine();
            build.Append(dvdTitles.ElementAt(2));
            build.Append("(DVD)");

            StreamWriter write = new StreamWriter("DVD.txt");
            using (write)
            {
                write.Write(build);
            }
                
            return build.ToString();
        }

        public override void Edit()
        {
            base.Edit();
           
            Console.WriteLine("What title would you like to edit? ");
            foreach(string title in dvdTitles)
            {
                Console.WriteLine(title);
            }
            string options = Console.ReadLine().ToLower();
            switch (options)
            {
                case "1":
                case "boondock saints":
                    dvdTitles.RemoveAt(0);
                    Console.WriteLine("What is the name of the Title?");
                    Title = Console.ReadLine().ToLower();
                    if (false)
                    {
                        Status = "Available";
                        Console.WriteLine(Title, ": is", Status);
                    }
                    Console.WriteLine("Enter time amount in minutes of title: ");
                    Length = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0} minutes.", Length);
                    Console.WriteLine("Edit ISBN: ");
                    ISBN = int.Parse(Console.ReadLine());
                    break;
                case "2":
                case "rush hour":
                    dvdTitles.RemoveAt(1);
                    Console.WriteLine("What is the name of the Title?");
                    Title = Console.ReadLine().ToLower();
                    if (false)
                    {
                        Status = "Available";
                        Console.WriteLine(Title, ": is", Status);
                    }
                    Console.WriteLine("Enter time amount in minutes of title: ");
                    Length = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0} minutes.", Length);
                    Console.WriteLine("Edit ISBN: ");
                    ISBN = int.Parse(Console.ReadLine());
                    break;
                case "3":
                case "star wars":
                    dvdTitles.RemoveAt(2);
                    Console.WriteLine("What is the name of the Title?");
                    Title = Console.ReadLine().ToLower();
                    if (false)
                    {
                        Status = "Available";
                        Console.WriteLine(Title, ": is", Status);
                    }
                    Console.WriteLine("Enter time amount in minutes of title: ");
                    Length = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0} minutes.", Length);
                    Console.WriteLine("Edit ISBN: ");
                    ISBN = int.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    Edit();
                    break;

            }

        }

        public override void Checkout()
        {
            base.Checkout();
            Menu menu = new Menu();
            bool book = false;
            foreach (KeyValuePair<string, int> names in studentID)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine("Enter Student ID number: ");
            string fullName = Console.ReadLine().ToLower();

            if (studentID.ContainsValue(int.Parse(fullName)))
            {
                book = true;
                Console.ReadKey();
            }
            if (book == false)
            {
                Console.WriteLine("Error: Request Unavailable");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                bool bookOut = false;
                Console.Write("\n");
                Console.WriteLine("Enter title  you would like to check out: \n");
                for (int g = 0; g < dvdTitles.Count; g++)
                {
                    Console.WriteLine(dvdTitles[g]);
                }
                string checkingOut = Console.ReadLine().ToLower();

                while (true)
                {
                    if (dvdTitles.Contains(checkingOut, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("true");
                        Console.ReadKey();
                        break;
                    }
                    if (bookOut == false)
                    {
                        Console.WriteLine("Error: Request Unavailable");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }

                if (fullName == "120")
                {
                    dvdTitles.Remove(checkingOut);
                    bobJones.Add(checkingOut);
                    while (true)
                    {
                        Console.WriteLine("Would you like to check out another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < dvdTitles.Count; g++)
                            {
                                Console.WriteLine(dvdTitles[g]);
                            }
                            Console.WriteLine("\n");
                            checkingOut = Console.ReadLine();
                            dvdTitles.Remove(checkingOut);
                            bobJones.Add(checkingOut);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }

                    StreamWriter checkoutBook = new StreamWriter("BobJones.txt");
                    StreamWriter write = new StreamWriter("Checkout.txt");
                    using (write)
                    {
                        write.WriteLine(checkingOut);
                    }
                    using (checkoutBook)
                    {
                        for (int c = 0; c < bobJones.Count; c++)
                        {
                            checkoutBook.WriteLine(bobJones[c]);
                        }
                    }
                }

                if (fullName == "121")
                {
                    dvdTitles.Remove(checkingOut);
                    chadLego.Add(checkingOut);
                    while (true)
                    {
                        Console.WriteLine("Would you like to check out another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < dvdTitles.Count; g++)
                            {
                                Console.WriteLine(dvdTitles[g]);
                            }
                            Console.WriteLine("\n");
                            checkingOut = Console.ReadLine();
                            dvdTitles.Remove(checkingOut);
                            chadLego.Add(checkingOut);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter checkoutBook = new StreamWriter("ChadLego.txt");
                    StreamWriter write = new StreamWriter("Checkout.txt");
                    using (write)
                    {
                        write.WriteLine(checkingOut);
                    }
                    using (checkoutBook)
                    {
                        for (int c = 0; c < chadLego.Count; c++)
                        {
                            checkoutBook.WriteLine(chadLego[c]);
                        }
                    }
                }

                if (fullName == "122")
                {
                    dvdTitles.Remove(checkingOut);
                    daleEarnie.Add(checkingOut);
                    while (true)
                    {
                        Console.WriteLine("Would you like to check out another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < dvdTitles.Count; g++)
                            {
                                Console.WriteLine(dvdTitles[g]);
                            }
                            Console.WriteLine("\n");
                            checkingOut = Console.ReadLine();
                            dvdTitles.Remove(checkingOut);
                            daleEarnie.Add(checkingOut);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter checkoutBook = new StreamWriter("DaleEarnie.txt");
                    StreamWriter write = new StreamWriter("Checkout.txt");
                    using (write)
                    {
                        write.WriteLine(checkingOut);
                    }
                    using (checkoutBook)
                    {
                        for (int c = 0; c < daleEarnie.Count; c++)
                        {
                            checkoutBook.WriteLine(daleEarnie[c]);
                        }
                    }
                }

                if (fullName == "123")
                {
                    dvdTitles.Remove(checkingOut);
                    jackJohnson.Add(checkingOut);
                    while (true)
                    {
                        Console.WriteLine("Would you like to check out another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < dvdTitles.Count; g++)
                            {
                                Console.WriteLine(dvdTitles[g]);
                            }
                            Console.WriteLine("\n");
                            checkingOut = Console.ReadLine();
                            dvdTitles.Remove(checkingOut);
                            jackJohnson.Add(checkingOut);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter checkoutBook = new StreamWriter("JackJohnson.txt");
                    StreamWriter write = new StreamWriter("Checkout.txt");
                    using (write)
                    {
                        write.WriteLine(checkingOut);
                    }
                    using (checkoutBook)
                    {
                        for (int c = 0; c < jackJohnson.Count; c++)
                        {
                            checkoutBook.WriteLine(jackJohnson[c]);
                        }
                    }
                }

                if (fullName == "124")
                {
                    dvdTitles.Remove(checkingOut);
                    rickyBobby.Add(checkingOut);
                    while (true)
                    {
                        Console.WriteLine("Would you like to check out another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < dvdTitles.Count; g++)
                            {
                                Console.WriteLine(dvdTitles[g]);
                            }
                            Console.WriteLine("\n");
                            checkingOut = Console.ReadLine();
                            dvdTitles.Remove(checkingOut);
                            rickyBobby.Add(checkingOut);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter checkoutBook = new StreamWriter("RickyBobby.txt");
                    StreamWriter write = new StreamWriter("Checkout.txt");
                    using (write)
                    {
                        write.WriteLine(checkingOut);
                    }
                    using (checkoutBook)
                    {
                        for (int c = 0; c < rickyBobby.Count; c++)
                        {
                            checkoutBook.WriteLine(rickyBobby[c]);
                        }
                    }
                }
            }

            menu.mainMenu();
        }

        public override void Return()
        {
            base.Return();

            Menu menu = new Menu();

            bool book = false;
            foreach (KeyValuePair<string, int> names in studentID)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine("Enter Student ID number: ");
            string fullName = Console.ReadLine().ToLower();

            if (studentID.ContainsValue(int.Parse(fullName)))
            {
                book = true;
                Console.ReadKey();
            }
            if (book == false)
            {
                Console.WriteLine("Error: Request Unavailable");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                bool bookOut = false;
                Console.Write("\n");
                Console.WriteLine("Enter title  you would like to return: \n");
                for (int g = 0; g < dvdTitles.Count; g++)
                {
                    Console.WriteLine(dvdTitles[g]);
                }
                string returnBook = Console.ReadLine().ToLower();

                while (true)
                {
                    if (dvdTitles.Contains(returnBook, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("true");
                        Console.ReadKey();
                        break;
                    }
                    if (bookOut == false)
                    {
                        Console.WriteLine("Error: Request Unavailable");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }

                if (fullName == "120")
                {
                    dvdTitles.Add(returnBook);
                    bobJones.Remove(returnBook);
                    while (true)
                    {
                        Console.WriteLine("Would you like to return another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < dvdTitles.Count; g++)
                            {
                                Console.WriteLine(dvdTitles[g]);
                            }
                            Console.WriteLine("\n");
                            returnBook = Console.ReadLine();
                            dvdTitles.Add(returnBook);
                            bobJones.Remove(returnBook);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter returnTitle = new StreamWriter("BobJones.txt");
                    using (returnTitle)
                    {
                        for (int c = 0; c < bobJones.Count; c++)
                        {
                            returnTitle.WriteLine(bobJones[c]);
                        }
                    }
                }

                if (fullName == "121")
                {
                    dvdTitles.Add(returnBook);
                    chadLego.Remove(returnBook);
                    while (true)
                    {
                        Console.WriteLine("Would you like to return another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < dvdTitles.Count; g++)
                            {
                                Console.WriteLine(dvdTitles[g]);
                            }
                            Console.WriteLine("\n");
                            returnBook = Console.ReadLine();
                            dvdTitles.Add(returnBook);
                            chadLego.Remove(returnBook);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter returnTitle = new StreamWriter("ChadLego.txt");
                    using (returnTitle)
                    {
                        for (int c = 0; c < chadLego.Count; c++)
                        {
                            returnTitle.WriteLine(chadLego[c]);
                        }
                    }

                }

                if (fullName == "122")
                {
                    dvdTitles.Add(returnBook);
                    daleEarnie.Remove(returnBook);
                    while (true)
                    {
                        Console.WriteLine("Would you like to return another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < dvdTitles.Count; g++)
                            {
                                Console.WriteLine(dvdTitles[g]);
                            }
                            Console.WriteLine("\n");
                            returnBook = Console.ReadLine();
                            dvdTitles.Add(returnBook);
                            daleEarnie.Remove(returnBook);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter returnTitle = new StreamWriter("DaleEarnie.txt");
                    using (returnTitle)
                    {
                        for (int c = 0; c < daleEarnie.Count; c++)
                        {
                            returnTitle.WriteLine(daleEarnie[c]);
                        }
                    }
                }

                if (fullName == "123")
                {
                    dvdTitles.Add(returnBook);
                    jackJohnson.Remove(returnBook);
                    while (true)
                    {
                        Console.WriteLine("Would you like to return another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < dvdTitles.Count; g++)
                            {
                                Console.WriteLine(dvdTitles[g]);
                            }
                            Console.WriteLine("\n");
                            returnBook = Console.ReadLine();
                            dvdTitles.Add(returnBook);
                            jackJohnson.Remove(returnBook);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter returnTitle = new StreamWriter("JackJohnson.txt");
                    using (returnTitle)
                    {
                        for (int c = 0; c < jackJohnson.Count; c++)
                        {
                            returnTitle.WriteLine(jackJohnson[c]);
                        }
                    }
                }

                if (fullName == "124")
                {
                    dvdTitles.Add(returnBook);
                    rickyBobby.Remove(returnBook);
                    while (true)
                    {
                        Console.WriteLine("Would you like to return another book? (y\n)");
                        string topicSelection = Console.ReadLine();
                        if (topicSelection.ToLower() == "y")
                        {
                            Console.WriteLine("Enter book title: \n");
                            for (int g = 0; g < dvdTitles.Count; g++)
                            {
                                Console.WriteLine(dvdTitles[g]);
                            }
                            Console.WriteLine("\n");
                            returnBook = Console.ReadLine();
                            dvdTitles.Add(returnBook);
                            rickyBobby.Remove(returnBook);
                        }
                        else if (topicSelection.ToLower() == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection, please enter (y\n)");
                        }
                    }
                    StreamWriter returnTitle = new StreamWriter("RickyBobby.txt");
                    using (returnTitle)
                    {
                        for (int c = 0; c < rickyBobby.Count; c++)
                        {
                            returnTitle.WriteLine(rickyBobby[c]);
                        }
                    }
                }
            }
            menu.mainMenu();
        }
    }
}
