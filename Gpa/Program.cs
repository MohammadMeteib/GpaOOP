using Gpa.Models;
Student student = new Student();
string name;
string major;
int gpa;

Console.WriteLine("Enter name");
name = Console.ReadLine();
Console.WriteLine("Enter major");
major = Console.ReadLine();
Console.WriteLine("Enter GPA");
gpa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(student.StudentInfo(name, major, gpa));
