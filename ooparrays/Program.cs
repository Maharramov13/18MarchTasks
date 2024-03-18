internal class Program
{
    public static void Main(string[] args)
    {
        Book[]books=new Book[10];
        for(int i=0;i<books.Length;i++)
        {
            System.Console.WriteLine($"kitabin adini daxil edin");
            String name=Console.ReadLine();
            
            System.Console.WriteLine($"Kitabin sehife sayini daxil edin :");
            int pageCount=int.Parse(Console.ReadLine());
            Book book=new Book();
            book.Name=name;
            book.pageCount=pageCount;
            books[i]=book;
        }
        System.Console.WriteLine("Kitablar");
        foreach(var book in books)
        {
            System.Console.WriteLine($"Ad:{book.Name} sehife sayi:{book.PageCount}");
        }
    }
}