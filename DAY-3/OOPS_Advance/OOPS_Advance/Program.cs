using OOPS_Advance;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ABSTRACTION CONCEPT !!!");

        BMW b=new BMW();
        b.brand = "BMW";
        b.model = "G-series";
        b.specialFeactures = "Massage seats";
       Console.WriteLine( b.getCarDetails());

        Mercedez m = new Mercedez();
        m.brand = "BMW";
        m.model = "G-series";
        m.mileage = "13";
        Console.WriteLine(m.getCarDetails());
        Console.WriteLine("\n");
        Console.WriteLine("ABSTRACTION CONCEPT !!! WITH PERSON ,EMPLOYEE DETAILS ");
        Employee e=new Employee();
        e.Id = 100;
        e.firstName = "Siva";
        e.lastName = "Lingam";
        e.gender = "Male";
        e.salary = 10000;
        Console.WriteLine(e.displayDetails());



        // Console.WriteLine("INHERITANCE CONCEPT !!!");

        //Person p=new Person();
        ////p.firstName = "Shiva";
        ////p.lastName = "Lingam";
        ////p.gender = "Male";

        //Console.WriteLine("\n");
        //Console.WriteLine("Person Details :");
        //Console.WriteLine("\n");
        //Console.WriteLine("Person Full Name : "+p.firstName+" "+p.lastName);
        //Console.WriteLine("Person Gender : " +p.gender);
        //Console.WriteLine("\n");

        //Student s = new Student("Eashwaran","A","Male",200,500);
        //s.studentId= 1;
        //s.firstName = "Eashwar";
        //s.lastName = "A";
        //s.marks = 100;
        //s.gender = "Male";

        //Console.WriteLine("\n");
        //Console.WriteLine("Student Details :");
        //Console.WriteLine("\n");
        //s.displayDetails();
        // s.displayStudentDetails();
        //Console.WriteLine("Student Id : " + s.studentId);
        //Console.WriteLine("Student Full Name : " + s.firstName + " " + s.lastName);
        //Console.WriteLine("Student Mark : " + s.marks);
        //Console.WriteLine("Student Gender : " + s.gender);
        //Console.WriteLine("\n");

        //Employee e = new Employee("Dharnesh","Rajamanickam","Female",100,5000);
        //e.Id = 100;
        //e.firstName = "Eashwar";
        //e.lastName = "A";

        //e.gender = "Male";
        //e.salary = 8786798;

        //Console.WriteLine("\n");
        //Console.WriteLine("Employee Details :");
        //Console.WriteLine("\n");
        //e.displayDetails();
        //e.displayEmployeeDetails();
        //Console.WriteLine("Employee Id : " + e.Id);
        //Console.WriteLine("Employee Full Name : " + e.firstName + " " + e.lastName);

        //Console.WriteLine("Employee Gender : " + e.gender);
        //Console.WriteLine("Employee Salary : " + e.salary);
        // Console.WriteLine("\n");

    }
}