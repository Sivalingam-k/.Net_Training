using Oops;

internal class Program
{
    private static void Main(string[] args)
    {
        User u1,u2,u3,u4;

        for (int i = 0; i < 3; i++)
        {
            Console.Write("enter username : ");
            string username = Console.ReadLine();
            Console.Write("Enter password : ");
            string password = Console.ReadLine();
            u1 = new User(username, password);
            string result = u1.checkLogin();
            u1.getDetails();
            Console.WriteLine(result);

            Console.WriteLine("----------------------------");
            Console.WriteLine();



            u2 = new User("Siva", "Pass234", "Guest User");
            u2.getDetails();
            result=u2.checkLogin();
            Console.WriteLine(result);


            Console.WriteLine("----------------------------");
            Console.WriteLine();


            u3 = new User("Eashwar", "Pass456", "Special User","Chennai");
            u3.getDetails();
            result = u3.checkLogin();
            Console.WriteLine(result);


            Console.WriteLine("----------------------------");
            Console.WriteLine();


            u4 = new User("Dharnesh", "Pass789", "Normal User","Madhurai",false);
            u4.getDetails();
            result = u4.checkLogin();
            Console.WriteLine(result);


            Console.WriteLine("----------------------------");
            Console.WriteLine();

            //Console.WriteLine("Enter Number one :");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Number Two :");

            //int num2 = Convert.ToInt32(Console.ReadLine());

            //MathOperation mo = new MathOperation(num1, num2);
            //mo.display();




        }
    }
}