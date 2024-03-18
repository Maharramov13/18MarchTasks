using System.Reflection.Metadata.Ecma335;

public class Student
{

    public string Name{get;set;}
    public string SurName{get;set;}


   public string GetFullName()
    {
        return Name;
        return SurName;
    }
    
   public void GetStudents()
   {
    var str=$"My name is{Name},and my surname is {SurName}";
   }

    
      
}