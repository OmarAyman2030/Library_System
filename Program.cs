namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libarary libarary = new Libarary();
            Console.WriteLine("\t\t\t\t\t\tWelcome To The Library System");
            Console.WriteLine(" Are You Librarian or Regular User (L/R) ");
            char UserType = Console.ReadLine().ToUpper()[0];
            if(UserType == 'L')
            {
                //L Logic
                Console.Write("Welcome Librarian, Please Enter Your Name: ");
                string lName = Console.ReadLine();

                Libarian l1 = new Libarian(lName); 

                Console.WriteLine($"Welcome Mr/Ms, {l1.Name}");
                while(true) { 

                Console.WriteLine("Please choose options: To Add book(A) / Remove book(R) / Display book(D) / Exit(E)");

                    {
                        char choice = Console.ReadLine().ToUpper()[0];
                        switch (choice)
                        {
                            case 'A':

                                //Add book
                                Console.WriteLine("Enter The Book details");
                                Console.Write("Book Name: ");
                                string bookName = Console.ReadLine();
                                Console.Write("Book Author: ");
                                string bookAutour = Console.ReadLine();
                                Console.Write("Book Year: ");
                                int bookYear = int.Parse(Console.ReadLine());
                                Book book = new Book()
                                {
                                    Title = bookName,
                                    Author = bookAutour,
                                    Year = bookYear,
                                };
                                l1.AddBook(book, libarary);
                                break;

                            case 'R':
                                //Remove Book
                                Console.WriteLine("Enter The Book details");
                                Console.Write("Book Name: ");
                                bookName = Console.ReadLine();
                                Console.Write("Book Author: ");
                                bookAutour = Console.ReadLine();
                                Console.Write("Book Year: ");
                                bookYear = int.Parse(Console.ReadLine());
                                book = new Book()
                                {
                                    Title = bookName,
                                    Author = bookAutour,
                                    Year = bookYear,
                                };

                                l1.RemoveBook(book, libarary);
                                break;

                            case 'D':
                                Console.WriteLine("The book List: ");
                                l1.DisplayBooks(libarary);
                                break;

                            case 'E':
                                Console.WriteLine("\t\t\tThanks for Coming To the library and Visit us again\n");
                                return;


                            default:
                                Console.WriteLine("Please select from the options avaliable (A {For Add Book} , R {For Remove Book} , D {For Display Book} , E {Exit})");
                                break;


                        }
                    }
                   
                }


            }

            else if(UserType == 'R')
            {
                //R logic
                Console.Write("Welcome User, Please Enter Your Name: ");
                string Uname = Console.ReadLine();
                LibararyUser u1 = new LibararyUser(Uname);
                Console.WriteLine($"Welcome Mr/Ms, {u1.Name}");
                while (true)
                {

                    Console.WriteLine("Please choose options: To Display book(D) or Borrow book(B) or Exit(E)");

                    {
                        char choice = Console.ReadLine().ToUpper()[0];
                        switch (choice)
                        {
                            case 'D':
                                Console.WriteLine("The book List: ");
                                u1.DisplayBooks(libarary);
                                break;
                            case 'B':

                                //Add book
                                Console.WriteLine("Enter The Book details");
                                Console.Write("Book Name: ");
                                string bookName = Console.ReadLine();
                                Console.Write("Book Author: ");
                                string bookAutour = Console.ReadLine();
                                Console.Write("Book Year: ");
                                int bookYear = int.Parse(Console.ReadLine());
                                Book book = new Book()
                                {
                                    Title = bookName,
                                    Author = bookAutour,
                                    Year = bookYear,
                                };
                                u1.BoworredBooks(book, libarary);
                                break;
                            case 'E':
                                Console.WriteLine("\t\t\tThanks for Coming To the library and Visit us again\n");
                                return;
                            default:
                                Console.WriteLine("Please select from the options avaliable D {For Display Book} , B{For Borrow Book} , E {Exit})");
                                break;


                        }
                    }

                }

                
            }

            else
            {
                Console.WriteLine("\t\tSorry, You should enter Valid choice (L for Librarian) , (R for Regular User) ");
            }
          
        }
    }
}
