
using demoApp2;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    //  class Age
    //{
    //    private readonly int _year;
    //    public Age(int year) {
    //       this._year = year;
    //        Console.WriteLine(this._year);
    //    }
    //    public void getAge()
    //    {
           
           
    //    }
    //}
private static void Main(string[] args)
    {

        //Constructor OverLoading
        //Employee e1, e2, e3;
        //e1 = new Employee("Siva",21);
        //Console.WriteLine("Employee Name :" + e1.employeeName + " Employee Age :" + e1.age);
        //Console.WriteLine();
        //e2 = new Employee("Eashwar", 21,2500.0);
        //Console.WriteLine("Employee Name :" + e2.employeeName + " Employee Age :" + e2.age + " Employee Salary : "+e2.salary);
        //Console.WriteLine();
        //e3 = new Employee("Dinesh", 21,20000.0,"ChangePond");
        //Console.WriteLine("Employee Name :" + e3.employeeName + " Employee Age :" + e3.age + " Employee Salary : " + e3.salary +"  Company Name : "+e3.company);

        //Console.WriteLine();
        //------------------------------------------------------------------
        //Object Initialization

        Student s1, s2;
        s1 = new Student() { studentId = 1, studentName = "Siva" };
        s1.Age = 25;
        Console.WriteLine("Student Id :" + s1.studentId);
        Console.WriteLine("Name :" + s1.studentName);
        Console.WriteLine("marks :" + s1.marks);
        Console.WriteLine("Age:" + s1.Age);

        //Age a = new Age(1990);
        //a.getAge(); 
        //Console.WriteLine("Welcome to OOps Concept!!");

        //Student s1 = new Student();   
        //s1.studentId = 100;
        //s1.studentName = "Shivalingam";
        //s1.marks = 100;
        //Student.collegeName = "MASC";


        //Console.WriteLine("Student_id : " +s1.studentId);
        //Console.WriteLine("Student_Name : " + s1.studentName);
        //Console.WriteLine("Student_marks : " + s1.marks);
        //Console.WriteLine("Student_College_name : " + Student.collegeName);

        //Student s2 = new Student();
        //s2.studentId = 200;
        //s2.studentName = "Eashwar";
        //s2.marks = 500;
        //Student.collegeName = "KASC";

        //Console.WriteLine("Student_id : " + s2.studentId);
        //Console.WriteLine("Student_Name : " + s2.studentName);
        //Console.WriteLine("Student_marks : " + s2.marks);
        //Console.WriteLine("Student_College_name : " + Student.collegeName);

        //Employee e1=new Employee();
        //e1.employeeName = "Shiva";
        //e1.age = 10;
        //e1.salary = 25000.0;
        //Employee.company = "ChangePond";

        //Console.WriteLine("Employee Details");
        //Console.WriteLine("Employee NAme :" +e1.employeeName);
        //Console.WriteLine("Employee Age :" +e1.age);
        //Console.WriteLine("Employee Salary :"+e1.salary);
        //Console.WriteLine("Employee Company :"+Employee.company);

        //Console.WriteLine();
        //Console.WriteLine("----------------------------------------------------------------");
        //Console.WriteLine();


        //Employee e2 = new Employee();
        //e2.employeeName = "Eashwar";
        //e2.age = 9;
        //e2.salary = 25000.0;
        //Employee.company = "ChangePond";
        //Console.WriteLine("Employee Details");
        //Console.WriteLine("Employee NAme :" + e2.employeeName);
        //Console.WriteLine("Employee Age :" + e2.age);
        //Console.WriteLine("Employee Salary :" + e2.salary);
        //Console.WriteLine("Employee Company :" + Employee.company);

        //Console.WriteLine();
        //Console.WriteLine("----------------------------------------------------------------");
        //Console.WriteLine();
    }
}