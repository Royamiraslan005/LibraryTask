using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Library library=new Library();
            while (true)
            {
                Console.WriteLine("\n -------MENYU------ ");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Get book by id");
                Console.WriteLine("3. Remove book");
                Console.WriteLine("4. Update Book");
                Console.WriteLine("5. Get all books");
                Console.WriteLine("0. Quit");

                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        Console.Write("kitabin adini daxil edin");
                        string name= Console.ReadLine();
                        Console.Write("kitabin muellifini daxil edin");
                        string author= Console.ReadLine();
                        Console.Write("kitabin qiymetini daxil edin");
                        double price=double.Parse(Console.ReadLine());
                        Book book=new Book(name,author,price);
                        library.AddBook(book);
                        break;
                        case "2":
                        Console.WriteLine("kitabin id sini daxil edin");
                        int id=int.Parse(Console.ReadLine());
                        break;
                        case "3":
                        Console.WriteLine("kitabin ID sini sil");
                        break;
                    case "4":
                        Console.WriteLine("kitabi deyis");
                        break;
                        case "5":
                        Console.WriteLine("kitablarin hamisini daxil edin");
                        break;
                        case "0":
                        Console.WriteLine("QUIT");
                        break;
                       default:
                        Console.WriteLine("yeniden cehd ediniz");
                        break;
                }
            }
        }
    }
}
