using Oops;

internal class Program
{
    private static void Main(string[] args)
    {
        //User u1;
      // Console.WriteLine("WelCome to Login Page");

        Console.WriteLine("Enter Number one :");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Number Two :");

        int num2 = Convert.ToInt32(Console.ReadLine());

        MathOperation mo = new MathOperation(num1, num2);
        mo.display();




    }
}