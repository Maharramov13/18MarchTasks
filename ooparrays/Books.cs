using System.Dynamic;

class Book{
    public string name;
    public int pageCount;

    public string Name{
        get{return name;}
        set{
           if(value.Length<=3)
           {
            throw new ArgumentException("Kitab adi en az 4 herfli olmalidir" );
            
           }
           name=value;
        }
    }
    public int PageCount{
    
       get{return pageCount;}
        set{
            if(value<10){
                throw new ArgumentException("Kitab sehifesi 10-dan cox olmalidir ");
            }
            pageCount=value;
        } 
    }
}