using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library("ABD");
            Book book = new Book("Amok koşucusu", "Stefan zweig", 20);

            while (true)
            {
                Console.WriteLine("1. Add book\r\n2. Get book by id\r\n3. Remove book\r\n4. Update Book\r\n5. Get all books\r\n0. Quit ");
                int secim;
                bool ischeck = int.TryParse(Console.ReadLine(), out secim);

                if (ischeck)
                {
                    switch (secim)
                    {
                        case 0:
                            return;

                        case 1:

                            Console.WriteLine("Name:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Author Name:");
                            string Authorname = Console.ReadLine();


                            while (true)
                            {
                                Console.WriteLine("price");
                                bool check = int.TryParse(Console.ReadLine(), out int price);

                                if (check)
                                {
                                    Book book1 = new Book(name, Authorname, price);
                                    library.AddBook(book1);

                                    break;

                                }



                            }

                            break;



                        case 2:
                            int id;
                            while (true)
                            {
                                Console.WriteLine("ID");
                                bool check = int.TryParse(Console.ReadLine(), out id);
                                if (check)
                                {
                                    Console.WriteLine(library.GetBookById(id));
                                    break;
                                }
                            }
                            break;

                        case 3:
                            int id3;

                            while (true)
                            {
                                Console.WriteLine("ID:");
                                bool check = int.TryParse(Console.ReadLine(), out id3);
                                if (check)
                                {
                                    break;
                                }


                            }
                            library.RemoveBook(id3);
                            break;




                        case 4:
                            int id4;
                            while (true)
                            {
                                bool check = int.TryParse(Console.ReadLine(), out id4);
                                if (check)
                                {
                                    break;
                                }




                            }
                            Console.WriteLine("Name:");
                            string name2 = Console.ReadLine();
                            Console.WriteLine("Author Name:");
                            string Authorname2 = Console.ReadLine();


                            while (true)
                            {
                                Console.WriteLine("price");
                                bool check = int.TryParse(Console.ReadLine(), out int price);
                                if (check)
                                {
                                    Book book1 = new Book(name2, Authorname2, price);
                                    library.Update(id4, book1);

                                    break;

                                }



                            }
                            break;
                        case 5:
                            library.GetAllBooks();
                            break;

                        default:
                            break;
                    }
                }

            }
        }

    }
}