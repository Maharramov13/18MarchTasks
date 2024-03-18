using System.Collections.Concurrent;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    public static void Main(string[] args)
    {
      /*Asagidaki parameterlerden ibaret Student class-i yaradirsiniz
Name
Surname
Asagidaki parameterlerden ibaret Gorup class-i yaradirsiniz:
No - Group nomresini ifade edir
Limit - Group-da ola bilecek maximum telebe sayini ifade edir
Students - Group-unicerisindeki telebeleri ifade edir (Student typda array)
AddStudent() - metod prameter olaraq Student typinda obyekt qebul edir ve onu eger
 groupda yer varsa groupun students arrayine elave edir
GetStudnets() - bu metod studentler siyahisini geriye qaytarir
ps: Group obyekti uzerinde Studnetlere birbasa value set oluna bilinmemelidir,
 yalnizca AddStudent metodu ile group obyekti icindeki Students arrayine deyer elave etmek mumkundur */

Group group=new Group(3);
Student student=new Student(){
    Name="Turan",SurName="Maharramov"
};
Student student1=new Student(){
    Name="Ali",SurName="Aliyev"
};
Student student2=new Student(){
    Name="Famil",SurName="Ismayilov"
};
group.AddStudent(student);
group.AddStudent(student1);
group.AddStudent(student2);

Student[] students=group.GetStudents();
System.Console.WriteLine("Group Students:");
foreach(var stuu in students){
    System.Console.WriteLine($"{student.Name} {student.SurName}");
}






    }
}

