using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PW3_ResourceSystem
{
    class Menu
    {
        public void mainMenu()
        {
            //Instantiate classes into menu
            Student student = new Student();
            DVD dvd = new DVD();
            Magazine mag = new Magazine();
            Book book = new Book();
           


            List<string> Menu1 = new List<string>() { "\n\t1. View All Resources", "\n\t2. View Available Resources", "\n\t3. Edit Resources", "\n\t4. View Student Accounts",
                "\n\t5. View All Students", "\n\t6. CheckOut", "\n\t7. CheckIn", "\n\t8. Exit" };
            string[] menu = Menu1.ToArray();
            Console.WriteLine("**********Hello welcome to: \"Bootcamp Resources Checkout System\"**********");
                Console.WriteLine("*****Please choose one of the following \"Menu Items\"*****");
                for (int i = 0; i<menu.Length; i++)
                {
                    Console.WriteLine("\t" + menu[i]);
                }

                string optionMenu = Console.ReadLine().ToLower();
                switch (optionMenu)
                {
                    case "1":
                    case "view all resources":
                        Console.Clear();
                        student.writeAllResources();
                        student.readAllResources();
                        mainMenu();
                        break;
                    case "2":
                    case "view available resources":
                        Console.Clear();
                        Console.WriteLine(dvd.printAll());
                        Console.WriteLine(mag.printAll());
                        Console.WriteLine(book.printAll());
                        mainMenu();
                        break;
                    case "3":
                    case "edit resources":
                        Console.Clear();
                        Console.WriteLine("Which resource would you like to edit? ");
                        Console.WriteLine("1. DVD");
                        Console.WriteLine("2. Magazine");
                        Console.WriteLine("3. Book");
                        string option = Console.ReadLine().ToLower();
                        switch(option)
                        {
                            case "1":
                            case "dvd":
                                dvd.Edit();
                                mainMenu();
                                break;
                            case "2":
                            case "magazine":
                                mag.Edit();
                                mainMenu();
                                break;
                            case "3":
                            case "book":
                                book.Edit();
                                mainMenu();
                                break;
                            default:
                                Console.Clear();
                                mainMenu();
                                break;
                        }
                        mainMenu();
                        break;
                    case "4":
                    case "view student accounts":
                        Console.Clear();
                        student.studentAccounts();
                        mainMenu();
                        break;
                    case "5":
                    case "view all students":
                        Console.Clear();
                        student.writeStudents();
                        student.readStudents();
                        mainMenu();
                        break;
                    case "6":
                    case "checkout":
                        Console.Clear();
                        Console.WriteLine("Which resource would you like to checkout from? ");
                        Console.WriteLine("1. DVD");
                        Console.WriteLine("2. Magazine");
                        Console.WriteLine("3. Book");
                        string option1 = Console.ReadLine().ToLower();
                        switch (option1)
                        {
                            case "1":
                            case "dvd":
                                dvd.Checkout();
                                mainMenu();
                                break;
                            case "2":
                            case "magazine":
                                mag.Checkout();
                                mainMenu();
                                break;
                            case "3":
                            case "book":
                                book.Checkout();
                                mainMenu();
                                break;
                            default:
                                Console.Clear();
                                mainMenu();
                                break;
                        }
                        mainMenu(); 
                        break;
                    case "7":
                    case "checkin":
                        Console.Clear();
                        Console.WriteLine("Which resource would you like to return? ");
                        Console.WriteLine("1. DVD");
                        Console.WriteLine("2. Magazine");
                        Console.WriteLine("3. Book");
                        string option2 = Console.ReadLine().ToLower();
                        switch (option2)
                        {
                            case "1":
                            case "dvd":
                                dvd.Return();
                                mainMenu();
                                break;
                            case "2":
                            case "magazine":
                                mag.Return();
                                mainMenu();
                                break;
                            case "3":
                            case "book":
                                book.Return();
                                mainMenu();
                                break;
                            default:
                                Console.Clear();
                                mainMenu();
                                break;
                        }
                        mainMenu();
                        break;
                    case "8":
                    case "exit":
                        Console.Clear();
                        Exit();
                        break;
                    default:
                        Console.Clear();
                        mainMenu();
                        break;
                }
        }

        static void Exit()
        {
            Console.WriteLine("Good-Bye");
        }
    }

}
