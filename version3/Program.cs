using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using version3.BL;

namespace version3
{
    class Program
    {
        //Start of Main
        static void Main(string[] args)
        {
            List<Book> book = new List<Book>();
            List<Customer> customer = new List<Customer>();
            List<CustomerBook> cB = new List<CustomerBook>();
            LogIn credentials = new LogIn();
            Book bookData = new Book();
            Customer customerData = new Customer();
            CustomerBook details = new CustomerBook();
            string op;
            bookData.readBook(book);
            customerData.readCustomer(customer);
            Console.Clear();
            mainHeader();
            //Start of Main While Loop
            while(true)
            {
                Console.Clear();
                mainHeader();
                op = login();
               
                //Option 1 for Admin
                if(op == "1")
                {
                    clearScreen();
                    mainHeader();
                    string record;
                    string path = @"E:\Programming\2nd semester\OOP\Business Application\version3\admin.txt";
                    StreamReader filePassword = new StreamReader(path);
                    if((record = filePassword.ReadLine()) != null)
                    {
                        if(record == credentials.login_option())
                        {
                            clearScreen();
                            success();
                            while (true)
                            {
                                clearScreen();
                                mainHeader();
                                op = adminMenu();
                                clearScreen();

                                // Admin Option 1
                                if (op == "1")
                                {
                                    mainHeader();
                                    bookData.addBookintoList(book);
                                }

                                //Admin Option 2
                                else if (op == "2")
                                {
                                    mainHeader();
                                    bookData.viewAllBooks(book);
                                }

                                //Admin Option 3
                                else if (op == "3")
                                {
                                    mainHeader();
                                    bookData.sorting(book);
                                }

                                //Admin Option 4
                                else if (op == "4")
                                {
                                    string name;
                                    mainHeader();
                                    Console.WriteLine("As An Admin");
                                    Console.WriteLine("-------------------------------------------");
                                    Console.Write("Enter Book Name: ");
                                    name = Console.ReadLine();
                                    bookData.searchBook(book, name);
                                }

                                //Admin Option 5
                                else if (op == "5")
                                {
                                    string name;
                                    mainHeader();
                                    Console.WriteLine("As An Admin");
                                    Console.WriteLine("-------------------------------------------");
                                    Console.Write("Enter Book Name: ");
                                    name = Console.ReadLine();
                                    bookData.deleteBook(book, name);
                                }

                                //Admin Option 6
                                else if (op == "6")
                                {
                                    float disc;
                                    mainHeader();
                                    Console.WriteLine("\t\t>> Discount ");
                                    Console.Write("\t\t  Discount     : ");
                                    disc = float.Parse(Console.ReadLine());
                                    bookData.calculateDiscount(disc,book);
                                }

                                //Admin Option 7
                                else if (op == "7")
                                {
                                    mainHeader();
                                    customerData.addCustomerintoList(customer);
                                }

                                //Admin Option 8
                                else if (op == "8")
                                {
                                    mainHeader();
                                    customerData.viewAllCustomers(customer);
                                }

                                //Admin Option 9
                                else if (op == "9")
                                {
                                    float p;
                                    clearScreen();
                                    mainHeader();
                                    Console.WriteLine("As An Admin");
                                    Console.WriteLine(">> View Salary");
                                    Console.WriteLine(" Your Salary is : 20000");
                                    p = (20000 * 5) / 100;
                                    p = p + 20000;
                                    Console.Write("Profit = ");
                                    Console.WriteLine(p);
                                }

                                //Admin Option 10
                                else if (op == "10")
                                {
                                    break;
                                }

                                //For Any Option
                                else
                                {
                                    clearScreen();
                                    mainHeader();
                                    Console.WriteLine("\t\t\t              INVALID INPUT!!\t          ");
                                    Console.WriteLine("\t\t\t                TRY AGAIN!!! \t          ");
                                    Console.ReadKey();
                                }
                            }
                        }
                        else
                        {
                            fail();
                        }
                    }
                }

                //Option 2 for Buyer
                else if(op == "2")
                {
                    clearScreen();
                    mainHeader();
                    string record;
                    string path = @"E:\Programming\2nd semester\OOP\Business Application\version3\buyer.txt";
                    StreamReader filePassword = new StreamReader(path);
                    if ((record = filePassword.ReadLine()) != null)
                    {
                        if (record == credentials.login_option())
                        {
                            clearScreen();
                            success();
                            while (true)
                            {
                                clearScreen();
                                mainHeader();
                                op = buyerMenu();
                                clearScreen();

                                //Buyer Option 1
                                if (op == "1")
                                {
                                    mainHeader();
                                    bookData.viewAllBooks(book);
                                }

                                //Buyer Option 2
                                else if (op == "2")
                                {
                                    mainHeader();
                                    details.addCustomerBookintoList(cB);
                                }

                                //Buyer Option 3
                                else if (op == "3")
                                {
                                    mainHeader();
                                    details.returnBook(cB);
                                }

                                //Buyer Option 4
                                else if (op == "4")
                                {
                                    break;
                                }

                                //For AnyOther Option
                                else
                                {
                                    clearScreen();
                                    mainHeader();
                                    Console.WriteLine("\t\t\t              INVALID INPUT!!\t          ");
                                    Console.WriteLine("\t\t\t                TRY AGAIN!!! \t          ");
                                    Console.ReadKey();
                                }
                            }
                        }
                        else
                        {
                            fail();
                        }
                    }
                }

                //Option 3 for Seller
                else if(op == "3")
                {
                    clearScreen();
                    mainHeader();
                    string record;
                    string path = @"E:\Programming\2nd semester\OOP\Business Application\version3\seller.txt";
                    StreamReader filePassword = new StreamReader(path);
                    if ((record = filePassword.ReadLine()) != null)
                    {
                        if (record == credentials.login_option())
                        {
                            clearScreen();
                            success();
                            while(true)
                            {
                                clearScreen();
                                mainHeader();
                                op = sellermenu();
                                clearScreen();

                                //Seller Option 1
                                if (op == "1")
                                {
                                    string c_n, c_add;
                                    int n_b;
                                    clearScreen();
                                    mainHeader();
                                    Console.WriteLine("A Seller");
                                    Console.WriteLine(">> Sell Books");
                                    Console.Write("Customer Name: ");
                                    c_n = Console.ReadLine();
                                    Console.Write("Customer Address: ");
                                    c_add = Console.ReadLine();
                                    Console.Write("Number Of Books : ");
                                    n_b = int.Parse(Console.ReadLine());
                                }

                                //Seller Option 2
                                else if (op == "2")
                                {
                                    float p;
                                    clearScreen();
                                    mainHeader();
                                    Console.WriteLine("As A Seller");
                                    Console.WriteLine(">> View Salary");
                                    Console.WriteLine(" Your Salary is : 5000");
                                    p = (5000 * 5) / 100;
                                    p = p + 5000;
                                    Console.Write("Profit = ");
                                    Console.WriteLine(p);
                                }

                                //Seller Option 3
                                else if (op == "3")
                                {
                                    break;
                                }

                                //For AnyOther Option
                                else
                                {
                                    clearScreen();
                                    mainHeader();
                                    Console.WriteLine("\t\t\t              INVALID INPUT!!\t          ");
                                    Console.WriteLine("\t\t\t                TRY AGAIN!!! \t          ");
                                    Console.ReadKey();
                                }
                            }
                        }
                        else
                        {
                            fail();
                        }
                    }
                }

                //Option 4 for Exit
                else if(op == "4")
                {
                    break;
                }

                //For AnyOther Option
                else
                {
                    clearScreen();
                    mainHeader();
                    Console.WriteLine("\t\t\t              INVALID INPUT!!\t          ");
                    Console.WriteLine("\t\t\t                TRY AGAIN!!! \t          ");
                    Console.ReadKey();
                }
            }
            //End of Main While Loop

            Console.ReadKey();
        }
        //End of Main

        //________________FUNCTIONS DEFINATION___________________

        static void clearScreen()
        {
            //____clear screen_____
            Console.Write("Press any key to continue ");
            Console.ReadKey();
            Console.Clear();
        }

        static void mainHeader()
        {
            //_________DISPLAY HEADER___________
            Console.WriteLine("\t\t**********************************************************************");
            Console.WriteLine("\t\t                                                                      ");
            Console.WriteLine("\t\t***                Book Store Management System                    ***");
            Console.WriteLine("\t\t                                                                      ");
            Console.WriteLine("\t\t**********************************************************************");
        }

        //  login menu
        static string login()
        {
            string op;
            Console.WriteLine("Login");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. As An Admin ");
            Console.WriteLine("2. As  A Buyer ");
            Console.WriteLine("3. As  A Seller");
            Console.WriteLine("4. Exit");
            Console.Write("   Your Option... ");
            op = Console.ReadLine();
            return op;
        }

        static void success()
        {
            // function to display login successfully
            mainHeader();
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("             Login successfully!           ");
            Console.ReadKey();
        }

        static void fail()
        {
            // for wrong password
            string op;
            clearScreen();
            mainHeader();
            Console.WriteLine("                                                             ");
            Console.WriteLine("                                                             ");
            Console.WriteLine("\t                    WRONG PASSWORD!!!                  \t  ");
            Console.WriteLine("\t                     TRY AGAIN!!!                      \t  ");
            Console.Write("press any key to continue");
            op = Console.ReadLine();
            Console.ReadKey();
        }

        static string adminMenu()
        {
            //_______________Admin menu_______________
            string op;
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("You can choose any option from below");
            Console.WriteLine("\t1. Add Books");
            Console.WriteLine("\t2. View All Books");
            Console.WriteLine("\t3. Sort books According to Price");
            Console.WriteLine("\t4. Search Book");
            Console.WriteLine("\t5. Delete Book");
            Console.WriteLine("\t6. Discount");
            Console.WriteLine("\t7. Add Customer Details");
            Console.WriteLine("\t8. View Customer Details");
            Console.WriteLine("\t9. View Profit");
            Console.WriteLine("\t10. Exit");
            Console.Write("\t\t   Your Option... ");
            op = Console.ReadLine();
            return op;
        }

        static string buyerMenu()
        {
            string op;
            // buyer menu
            Console.WriteLine("You can choose any option from below");
            Console.WriteLine("1. View all Books");
            Console.WriteLine("2. Buy Books");
            Console.WriteLine("3. Return Boks");
            Console.WriteLine("4. Exit     ");
            Console.Write("   Your option...");
            op = Console.ReadLine();
            return op;
        }

        //_________________SELLER MENU______________________
        static string sellermenu()
        {
            string op;
            // seller menu
            Console.WriteLine("As An Seller");
            Console.WriteLine("You can choose any option from below");
            Console.WriteLine("1. Sell Boos");
            Console.WriteLine("2. View Profit");
            Console.WriteLine("3. Exit");
            Console.Write("   Your option...");
            op = Console.ReadLine();
            return op;
        }

        //End of Functions Definations
    }
}
