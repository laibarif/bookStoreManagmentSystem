using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using final_version.BL;
using final_version.DL;
using final_version.UI;

namespace final_version
{
    class Program
    {
        static void Main(string[] args)
        {
            string Cpath = "credentials.txt";
            string bookPath = "addbook.txt";
            CredentialsDL.readDataFromFile(Cpath);
            BookDL.readBook(bookPath);
            string op;
            while (true)
            {
                Console.Clear();
                MenuUI.mainHeader();
                op = MenuUI.loginMenu();
                if (op == "1")
                {
                    Credentials user = CredentialsDL.SignIn();
                    MenuUI.clearScreen();
                    if (user != null)
                    {
                        string role = user.role();
                        if(role == "Admin")
                        {
                           // MenuUI.mainHeader();
                            MenuUI.success();
                            MenuUI.clearScreen();
                            while (true)
                            {
                                Console.Clear();
                                MenuUI.mainHeader();
                                op = MenuUI.adminMenu();
                                MenuUI.clearScreen();
                                MenuUI.mainHeader();
                                if (op == "1")
                                {
                                    Book book = BookUI.addBook();
                                    BookDL.addBookintoList(book);
                                    BookDL.addBookintoFile(book, bookPath);
                                }
                                else if (op == "2")
                                {
                                    BookUI.viewAllBooks(BookDL.Books);
                                }
                                else if (op == "3")
                                {
                                    BookUI.sorting(BookDL.Books);
                                }
                                else if (op == "4")
                                {
                                    BookUI.searchBook(BookDL.Books);
                                }
                                else if (op == "5")
                                {
                                    BookUI.deleteBook(BookDL.Books);
                                }
                                else if (op == "6")
                                {
                                    BookUI.calculateDiscount(BookDL.Books);
                                }
                                else if (op == "7")
                                {

                                }
                                else if (op == "8")
                                {

                                }
                                else if (op == "9")
                                {

                                }
                                else if (op == "10")
                                {
                                    break;
                                }
                                else
                                {
                                    MenuUI.fail();
                                }
                                Console.ReadKey();
                            }
                        }
                        else if(role == "Customer")
                        {
                            MenuUI.mainHeader();
                            MenuUI.buyerMenu();
                        }
                        else if(role == "Seller")
                        {
                            MenuUI.mainHeader();
                            MenuUI.sellermenu();
                        }
                    }
                    else
                    {
                        MenuUI.fail();
                    }
                }
                else if (op == "2")
                {
                    Credentials user = CredentialsUI.TakeInput();
                    CredentialsDL.addUserIntoList(user);
                    CredentialsDL.storeUserintoFile(user, Cpath);
                }
                else if (op == "3")
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
