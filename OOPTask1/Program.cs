internal class Program
{
    private static void Main(string[] args)
    {
       Book[,] books=new Book[10,3];
       for(int i=0;i<10;i++){
        System.Console.WriteLine($"Kitabin adini girin ({i+1}.kitab)");
        string Name=Console.ReadLine();
        if(Name.Length<=3){
            System.Console.WriteLine("Kitab adi 3 herfden cox olmalidir!");
            break;
        }
        System.Console.WriteLine($"Kitabin sehife sayisini girin {i+1}.sehife");
        int PageCount=Convert.ToInt16(Console.ReadLine());
        

        books[i]=new Book() {Name=Name,PageCount=PageCount};
       }
       System.Console.WriteLine("Kitablar");
       foreach(var book in books){
        System.Console.WriteLine($"Ad:{book.Name},sehife sayisi:{book.PageCount}");
       }
       System.Console.WriteLine(books);
    }
}