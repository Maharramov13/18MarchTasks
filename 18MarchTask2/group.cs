using System.Security.Cryptography.X509Certificates;

class Group
{
    public Student[]students;
    int No;
    int limit;
public Group(int limit)
{
    students=new Student[limit];
    No=0;
    this.limit=limit;
}
public void AddStudent(Student student)
{
    if(No<limit)
    {
        students[No]=student;
        No++;
        System.Console.WriteLine($"{student.Name} {student.SurName} studenti gruba elave edildi");

    }

    else
    {
        System.Console.WriteLine("Qrupda yerler dolub");
    }
}
public Student[] GetStudents()
{
    Student[]result=new Student[No];
    Array.Copy(students,result,No);
    return result;
}
}