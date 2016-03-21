using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PW3_ResourceSystem
{
    class Student
    {
        //View all students from ".txt" file. **(Completed/Not Tested)**
        //Write each student a ".txt" file

        Dictionary<string, int> studentID = new Dictionary<string, int>()
        { {"Bob Jones", 00120 }, {"Chad Lego", 00121 }, {"Dale Earnie", 00122 }, {"Jack Johnson", 00123 }, {"Ricky Bobby", 00124 } };

        List<string> bobJones = new List<string>() { };
        List<string> chadLego = new List<string>() { };
        List<string> daleEarnie = new List<string>() { };
        List<string> jackJohnson = new List<string>() { };
        List<string> rickyBobby = new List<string>() { };
       

        public void viewAllNames()
        {
            Menu menu = new Menu();

            Dictionary<string, int> studentID = new Dictionary<string, int>()
            { {"Bob Jones", 00120 }, {"Chad Lego", 00121 }, {"Dale Earnie", 00122 }, {"Jack Johnson", 00123 }, {"Ricky Bobby", 00124 } };

            StringBuilder students = new StringBuilder();
            foreach (KeyValuePair<string, int> id in studentID)
            {
                students.Append(id).Append("\n");
            }
            Console.WriteLine(students);

            menu.mainMenu();
        }

        public void writeStudents()
        {
            //Writes to file
            StreamWriter write = new StreamWriter("AllStudents.txt");
            StringBuilder students = new StringBuilder();
            foreach (KeyValuePair<string, int> id in studentID)
            {
                students.Append(id).Append("\n");
            }
            using (write)
            {
                write.Write(students); 
            }
                
        }

        public void readStudents()
        {
            //Reads from file
            StreamReader read = new StreamReader("AllStudents.txt");
            using (read)
            {
                string text = System.IO.File.ReadAllText(@"AllStudents.txt");
                System.Console.WriteLine("Contents of AllStudents.txt = {0}", text);
                read.Close();
                read.Dispose();
            }
        }

        public void studentAccounts()
        {
            Menu menu = new Menu();

            StringBuilder booksChecked = new StringBuilder();

            foreach (KeyValuePair<string, int> names in studentID)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine("Enter Student ID number: ");
            string fullName = Console.ReadLine().ToLower();

            if (studentID.ContainsKey(fullName))
            {
                Console.WriteLine("Please enter ID number: ");
                studentAccounts();
            }
            else if (studentID.ContainsValue(int.Parse(fullName)))
            {
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Error: Request Unavailable");
                Console.ReadKey();
                Console.Clear();
                studentAccounts();
            }

            if (fullName == "120")
            {
                if (bobJones.Count == 0)
                {
                    Console.WriteLine("You have nothing checked out!");
                }
                for (int a = 0; a < bobJones.Count; a++)
                {
                    booksChecked.Append(bobJones[a]).Append("\n");
                }
                Console.WriteLine(booksChecked);

                StreamReader reader = new StreamReader("BobJones.txt");
                using (reader)
                {
                    string booksOut = reader.ReadToEnd();
                    Console.Write($"These books are checked out");
                }
                
            }
            if (fullName == "121")
            {
                if (chadLego.Count == 0)
                {
                    Console.WriteLine("You have nothing checked out!");
                }
                for (int a = 0; a < chadLego.Count; a++)
                {
                    booksChecked.Append(chadLego[a]).Append("\n");
                }
                Console.WriteLine(booksChecked);

                StreamReader reader = new StreamReader("ChadLego.txt");
                using (reader)
                {
                    string booksOut = reader.ReadToEnd();
                    Console.Write($"These books are checked out");
                }
                
            }
            if (fullName == "122")
            {
                if (daleEarnie.Count == 0)
                {
                    Console.WriteLine("You have nothing checked out!");
                }
                for (int a = 0; a < daleEarnie.Count; a++)
                {
                    booksChecked.Append(daleEarnie[a]).Append("\n");
                }
                Console.WriteLine(booksChecked);

                StreamReader reader = new StreamReader("DaleEarnie.txt");
                using (reader)
                {
                    string booksOut = reader.ReadToEnd();
                    Console.Write($"These books are checked out");
                }
            }
            if (fullName == "123")
            {
                if (jackJohnson.Count == 0)
                {
                    Console.WriteLine("You have nothing checked out!");
                }
                for (int a = 0; a < jackJohnson.Count; a++)
                {
                    booksChecked.Append(jackJohnson[a]).Append("\n");
                }
                Console.WriteLine(booksChecked);

                StreamReader reader = new StreamReader("JackJohnson.txt");
                using (reader)
                {
                    string booksOut = reader.ReadToEnd();
                    Console.Write($"These books are checked out");
                }
            }
            if (fullName == "124")
            {
                if (rickyBobby.Count == 0)
                {
                    Console.WriteLine("You have nothing checked out!");
                }
                for (int a = 0; a < rickyBobby.Count; a++)
                {
                    booksChecked.Append(rickyBobby[a]).Append("\n");
                }
                Console.WriteLine(booksChecked);

                StreamReader reader = new StreamReader("RickyBobby.txt");
                using (reader)
                {
                    string booksOut = reader.ReadToEnd();
                    Console.Write($"These books are checked out");
                }
            }

            menu.mainMenu();
        }

        public void writeAllResources()
        {
            DVD dvd = new DVD();
            Magazine mag = new Magazine();
            Book book = new Book();

            //Writes to file
            StreamWriter write = new StreamWriter("AllResources.txt");
            using (write)
            {
                write.WriteLine(dvd.printAll());
                write.WriteLine(mag.printAll());
                write.WriteLine(book.printAll());
            }
                
        }

        public void readAllResources()
        {
            StreamReader read = new StreamReader("AllResources.txt");
            using (read)
            {
                string text = System.IO.File.ReadAllText(@"AllResources.txt");
                System.Console.WriteLine("Contents of AllResources.txt = {0}", text);
                read.Dispose();
            }
        }
    }
}
