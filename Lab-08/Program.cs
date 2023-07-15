namespace Lab_08
{
    public class Program
    {
        static void Main(string[] args)
        {
            var l1 = new Library();

            l1.Add("book", "Ahmad", "Ahmad", 500);
            l1.Add("book2", "Ahmad", "Ahmad", 500);
            l1.Add("book3", "Ahmad", "Ahmad", 500);
            l1.Add("book4", "Ahmad", "Ahmad", 500);
            l1.Add("book5", "Ahmad", "Ahmad", 500);

            var b1 = new Backpack<Book>();
          
            b1.Pack(l1.Borrow("book"));
            Console.WriteLine("book in library");
            
            foreach (var book in b1)
            {
                Console.WriteLine(book.Title);
            }

            foreach (var book in l1)
            {
                Console.WriteLine(book.Title);
            }


            l1.Return(b1.Unpack(0));
        }
    }
}