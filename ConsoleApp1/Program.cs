using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //________________ARRAYS___________________
            const int MAX_RECORDS = 20;
            string[] usernameA = new string[MAX_RECORDS];
            string[] passwordsA = new string[MAX_RECORDS];
            string[] rolesA = new string[MAX_RECORDS];
            string[] book_name = new string[MAX_RECORDS];
            float[] book_price = new float[MAX_RECORDS];
            float[] quantityA = new float[MAX_RECORDS];
            float[] discountA = new float[MAX_RECORDS];
            string[] customer_name = new string[MAX_RECORDS];
            float[] books_buy = new float[MAX_RECORDS];
            string[] customer_booksA = new string[MAX_RECORDS];
            float[] billA = new float[MAX_RECORDS];
            float[] customerQuantity = new float[MAX_RECORDS];
            int userCount = 0;
            string op;
            float p;
            int customerCount = 0;
            int entry_count = 0;
            bool announce = false;
            string record;
            int count = 0;
            int countA = 0;


            // START OF EXECUTION
            string password;
            Console.Clear();
            mainHeader();
            //____________________ADMIN________________
            // option 1 for ADMIN
            while (true)
            {
                Console.Clear();
                mainHeader();
                op = login();

                // option 1 for admin
                if (op == "1")
                {
                    Console.Clear();
                    mainHeader();
                    password = login_option();
                    string path = @"E:\Programming\2nd semester\OOP\Business Application\ConsoleApp1\admin.txt";
                    StreamReader filePassword = new StreamReader(path);
                    if ((record = filePassword.ReadLine()) != null)
                    {
                        if (password == record)
                        {

                            clearScreen();
                            success();
                            while (true)
                            {
                                clearScreen();
                                mainHeader();
                                op = adminMenu();
                                clearScreen();
                                // admin option1
                                if (op == "1")
                                {
                                    mainHeader();
                                    addBook();
                                }
                                // admin option2
                                else if (op == "2")
                                {
                                    clearScreen();
                                    mainHeader();
                                    countA = viewallBooks(count, book_name, book_price, quantityA);
                                }
                                // admin option3
                                else if (op == "3")
                                {
                                    clearScreen();
                                    mainHeader();
                                    sort_books(countA, book_name, book_price, quantityA);
                                }
                                //admin option4
                                else if (op == "4")
                                {
                                    float dis;
                                    clearScreen();
                                    mainHeader();
                                    Console.WriteLine("\t\t>> Discount ");
                                    Console.Write("\t\t  Discount     : ");
                                    dis = float.Parse(Console.ReadLine());
                                    calculateDiscount(countA, dis, book_name, book_price, quantityA, discountA);
                                }
                                //admin option5
                                else if (op == "5")
                                {
                                    clearScreen();
                                    mainHeader();
                                    addCustomer();
                                }
                                //admin option 6
                                else if (op == "6")
                                {
                                    clearScreen();
                                    mainHeader();
                                    viewcustomerDetails(countA, customer_name, books_buy, billA);
                                }
                                //admin option 7
                                else if (op == "7")
                                {
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
                                // admin option 8
                                else if (op == "8")
                                {
                                    break;
                                }
                                // for any other option
                                else
                                {
                                    mainHeader();
                                    Console.WriteLine("\t\t\t              INVALID INPUT!!\t          ");
                                    Console.WriteLine("\t\t\t                TRY AGAIN!!! \t          ");
                                }
                            }
                        }

                        // for Wrong password
                        else
                        {
                            fail();
                        }
                    }
                }

                // option 2 for buyer
                else if (op == "2")
                {
                    Console.Clear();
                    mainHeader();
                    password = login_option();
                    string path = @"E:\Programming\2nd semester\OOP\Business Application\ConsoleApp1\buyer.txt";
                    StreamReader filePassword = new StreamReader(path);
                    if ((record = filePassword.ReadLine()) != null)
                    {
                        if (password == record)
                        {
                            clearScreen();
                            success();
                            while (true)
                            {
                                clearScreen();
                                mainHeader();
                                op = buyerMenu();
                                clearScreen();
                                // buyer option1
                                if (op == "1")
                                {
                                    clearScreen();
                                    mainHeader();
                                    Console.WriteLine("As An Buyer");
                                    viewallBooks(count, book_name, book_price, quantityA);
                                }
                                // buyer option 2
                                else if(op == "2")
                                {
                                    clearScreen();
                                    mainHeader();
                                    customerBooks(book_name,customerQuantity,customerCount);
                                }
                                // buyer option 3
                                else if(op == "3")
                                {
                                    clearScreen();
                                    mainHeader();
                                    returnBook(countA,book_name);
                                }
                                //buyer option 4
                                else if(op == "4")
                                {
                                    break;
                                }
                                // for any other option
                                else
                                {
                                    mainHeader();
                                    Console.WriteLine("\t\t\t              INVALID INPUT!!\t          ");
                                    Console.WriteLine("\t\t\t                TRY AGAIN!!! \t          ");
                                }
                            }
                        }
                    }
                    else
                    {
                        fail();
                    }
                }

                // option 3 for seller
                else if (op == "3")
                {
                    Console.Clear();
                    mainHeader();
                    password = login_option();
                    string path = @"E:\Programming\2nd semester\OOP\Business Application\ConsoleApp1\seller.txt";
                    StreamReader filePassword = new StreamReader(path);
                    if ((record = filePassword.ReadLine()) != null)
                    {
                        if (password == record)
                        {
                            clearScreen();
                            success();
                            while (true)
                            {
                                clearScreen();
                                mainHeader();
                                op = sellermenu();
                                clearScreen();
                                // seller option1
                                if (op == "1")
                                {
                                    string c_n, c_add;
                                    int n_b;
                                    clearScreen();
                                    mainHeader();
                                    Console.WriteLine("A Seller");
                                    Console.WriteLine(">> Sell Books");
                                    Console.WriteLine("Customer Name: ");
                                    c_n = Console.ReadLine();
                                    Console.WriteLine("Customer Address: ");
                                    c_add = Console.ReadLine();
                                    Console.WriteLine("Number Of Books : ");
                                    n_b = int.Parse(Console.ReadLine());
                                }
                                // seller option 2
                                else if(op == "2")
                                {
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
                                // seller option 3
                                else if(op == "3")
                                {
                                    break;
                                }
                                //for any other option
                                else
                                {
                                    Console.WriteLine("\t\t\t              INVALID INPUT!!\t          ");
                                    Console.WriteLine("\t\t\t                TRY AGAIN!!! \t          ");
                                }
                            }
                        }
                    }
                    //for wrong password
                    else
                    {
                        fail();
                    }
                }

                // option 4 to exit
                else if (op == "4")
                {
                    break;
                }

                // for any other input
                else
                {
                    mainHeader();
                    Console.WriteLine("\t\t\t               INVALID INPUT!!                    ");
                    Console.WriteLine("\t\t\t                  TRY AGAIN!!!                    ");
                    Console.ReadKey();
                }
            }
        }
       
        //__________________________FUNCTON DEFINATIONS_________________________
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
            Console.WriteLine("\t4. Discount");
            Console.WriteLine("\t5. Customer Details");
            Console.WriteLine("\t6. View Customer Details");
            Console.WriteLine("\t7. View Profit");
            Console.WriteLine("\t8. Exit");
            Console.Write("\t\t   Your Option... ");
            op = Console.ReadLine();
            return op;
        }

        static void addBook()
        { //__________Get book data __________
            string name;
            float price, quantity;
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            string path = "E:\\Programming\\2nd semester\\OOP\\Business Application\\ConsoleApp1\\addbook.txt";
            StreamWriter file = new StreamWriter(path,true);
            Console.Write("Enter Book name: ");
            name = Console.ReadLine();
            file.Write(name + ",");
            Console.Write("Enter Book Price: ");
            price = float.Parse(Console.ReadLine());
            file.Write(price + ",");
            Console.Write("Enter Quantity  : ");
            quantity = float.Parse(Console.ReadLine());
            file.WriteLine(quantity);
            file.Flush();
            file.Close(); 
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

        // function to login as admin or any other you want
        static string login_option()
        {
            string username, password;
            Console.WriteLine("Login");
            Console.WriteLine("--------------------");
            Console.Write(" Enter Username:  ");
            username = Console.ReadLine(); ;
            Console.Write(" Enter Password:   ");
            password = Console.ReadLine();
            return password;
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

        static int viewallBooks(int count,string[] book_name, float[] book_price , float[] quantityA)
        {
            //__________Retrieve book data and show on screen_______    
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Name\t\tPrice\t\tQuantity");
            string path = "E:\\Programming\\2nd semester\\OOP\\Business Application\\ConsoleApp1\\addbook.txt";
            StreamReader book = new StreamReader(path);
            string record;
            while ((record = book.ReadLine()) != null)
            {
                book_name[count] = passname(record, 1);
                book_price[count] = float.Parse(passname(record, 2));
                quantityA[count] = float.Parse(passname(record, 3));
                Console.WriteLine(book_name[count] + "\t\t" + book_price[count] + "\t\t" + quantityA[count]);
                count = count + 1;
            }
            book.Close();
            return count;
        }
        static string passname(string line, int field)
        {
            int counter = 1;
            string item = "";
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    counter = counter + 1;
                }
                else if (counter == field)
                {
                    item = item + line[i];
                }
            }
            return item;
        }

        static void sort_books(int count,string[] book_name , float[] book_price , float[] quantityA)
        { //_____________sort books according to price_________
            float price, quantity;
            string name;
            Console.WriteLine("As An Admin");
            Console.WriteLine("--------------------------------------");
            // viewallBooks();
            for (int k = 0; k < count - 1; k++)
            {
                // int min = k;
                for (int j = k + 1; j < count; j++)
                {
                    if (book_price[k] < book_price[j])
                    {
                        name = book_name[j];
                        price = book_price[j];
                        quantity = quantityA[j];
                        book_name[j] = book_name[k];
                        book_price[j] = book_price[k];
                        quantityA[j] = quantityA[k];
                        book_name[k] = name;
                        book_price[k] = price;
                        quantityA[k] = quantity;
                    }
                }
            }
            Console.WriteLine("After sorting ");
            Console.WriteLine("Name\t\tPrice\t\tQuantity");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(book_name[i] + "\t\t" + book_price[i] + "\t\t" + quantityA[i]);
            }
        }

        static void calculateDiscount(int count,float dis,string[] book_name,float[] book_price,float[] quantityA,float[] discountA)
        { //_____________calculate discount_______________
            int entry_count = 0;
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Name\t\tBook\t\tQuantity\tDiscount");
            string path = "E:\\Programming\\2nd semester\\OOP\\Business Application\\ConsoleApp1\\addbook.txt";
            StreamReader book = new StreamReader(path);
            string record;
            while ((record = book.ReadLine()) != null)
            {
                book_name[count] = passname(record, 1);
                string name = book_name[count];
                book_price[count] = float.Parse((passname(record, 2)));
                float price = book_price[count];
                quantityA[count] = float.Parse((passname(record, 3)));
                float quantity = quantityA[count];
                //book << endl;
                addBookIntoArray(entry_count,name,price,quantity,book_name,book_price,quantityA);
            }
            book.Close();
            for (int i = 0; i < count; i++)
            {
                float x = 0;
                x = (book_price[i] * dis) / 100;
                x = book_price[i] - x;
                discountA[i] = x;
                Console.WriteLine(book_name[i] + "\t\t" + book_price[i] + "\t\t" + quantityA[i] + "\t\t" + discountA[i]);
            }
        }

        static void addBookIntoArray(int entry_count,string name, float price, float q, string[] book_name, float[] book_price, float[] quantityA)
        { //______Store Book data into array____each time addBook() function is called. it will store into global array
            book_name[entry_count] = name;
            book_price[entry_count] = price;
            quantityA[entry_count] = q;
            entry_count++;
        }

        static void addCustomer()
        {
            // add Customer
            string name;
            float bookBuy, bill;
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            string path ="E:\\Programming\\2nd semester\\OOP\\Business Application\\ConsoleApp1\\customer.txt";
            StreamWriter file = new StreamWriter(path, true);
            Console.Write("Enter Customer name: ");
            name = Console.ReadLine();
            file.Write(name + ",");
            Console.Write("Enter Number of Books Buy: ");
            bookBuy = float.Parse(Console.ReadLine());
            file.Write(bookBuy + ",");
            Console.Write("Enter Bill: ");
            bill = float.Parse(Console.ReadLine());
            file.WriteLine(bill);
            file.Flush();
            file.Close();
            // addCustomerIntoArray(name, bookBuy, bill);
        }

        static void viewcustomerDetails(int count,string[] customer_name,float[] books_buy,float[] billA)
        { //_______Retrieve customer data and show on screen_______
            count = 0;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Name\t\tBook\t\tBill");
            string path = "E:\\Programming\\2nd semester\\OOP\\Business Application\\ConsoleApp1\\customer.txt";
            StreamReader customer = new StreamReader(path);
            string record;
            while ((record = customer.ReadLine()) != null)
            {
                customer_name[count] = passname(record, 1);
                books_buy[count] = float.Parse((passname(record, 2)));
                // cout<< price;
                billA[count] = float.Parse((passname(record, 3)));
                // cout<< quantity;
                Console.WriteLine(customer_name[count] + "\t\t" + books_buy[count] + "\t\t" + billA[count]);
                count = count + 1;
            }
            count--;
            customer.Close();
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

        static void customerBooks(string[] book_name, float[] customerQuantity, int customerCount)
        {
            string book;
            float quantity;
            Console.WriteLine("As An buyer");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter Book name: ");
            book = Console.ReadLine();
            Console.Write("Enter Quantity  : ");
            quantity = float.Parse(Console.ReadLine());
            addCustomerBooksIntoArrays(book, quantity,book_name,customerQuantity,customerCount);
        }

        static void addCustomerBooksIntoArrays(string book, float q ,string[] book_name,float[] customerQuantity,int customerCount)
        {
            book_name[customerCount] = book;
            customerQuantity[customerCount] = q;
            customerCount++;
        }

        static void returnBook(int count,string[] book_name)
        {
            string book;
            int flag = 0;
            float q;
            Console.WriteLine("As An buyer");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Enter Book name: ");
            book = Console.ReadLine();
            Console.Write("Enter Quantity  : ");
            q = float.Parse(Console.ReadLine());
            //nsole.Write(count);
            for (int i = 0; i < count; i++)
            {
                if (book == book_name[i])
                {
                    Console.WriteLine("\t\tRECORD FOUND!!");
                    Console.WriteLine("\t\tBOOK RETURNED ");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("\t\tRECORD NOT FOUND!!");
            }
        }

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
    }
}