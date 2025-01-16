namespace Lesson8;

public class Student
{
    private string name;
    private int age;
    private int grade;

   public Student(string name,int age,int grade)
   {
       this.name = name;
       this.age = age;
       this.grade = grade;
       
   }

   public bool IsExcellent()
   {
       if (grade == 5||grade==4) return true;
       else return false;
   }
}