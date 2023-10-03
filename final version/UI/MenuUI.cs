using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_version.UI
{
    class MenuUI
    {
        public static void clearScreen()
        {
            //____clear screen_____
            Console.Write("Press any key to continue ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void mainHeader()
        {
            //_________DISPLAY HEADER___________
            Console.WriteLine("\t\t**********************************************************************");
            Console.WriteLine("\t\t                                                                      ");
            Console.WriteLine("\t\t***                Book Store Management System                    ***");
            Console.WriteLine("\t\t                                                                      ");
            Console.WriteLine("\t\t**********************************************************************");
        }

        public static string loginMenu()
        {
            string op;
            Console.WriteLine("________Login Menu________");
            Console.WriteLine(" 1.Sign In");
            Console.WriteLine(" 2.Sign Out");
            Console.WriteLine(" 3.Exit");
            Console.Write("Enter Option: ");
            op = Console.ReadLine();
            return op;
        }

        //  login menu
        public static string login()
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

        public static void success()
        {
            // function to display login successfully
            mainHeader();
            Console.WriteLine("As An Admin");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("             Login successfully!           ");
            Console.ReadKey();
        }

        public static void fail()
        {
            // for wrong password
            string op;
            mainHeader();
            Console.WriteLine("                                                             ");
            Console.WriteLine("                                                             ");
            Console.WriteLine("\t                    Invalid Input!!!                  \t  ");
            Console.WriteLine("\t                     TRY AGAIN!!!                      \t  ");
            Console.Write("press any key to continue");
            op = Console.ReadLine();
            Console.ReadKey();
        }

        public static string adminMenu()
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

        public static string buyerMenu()
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
        public static string sellermenu()
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
