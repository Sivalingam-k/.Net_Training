internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a / b;

            Console.WriteLine("Quotient is " + c);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed!!");
            Console.WriteLine("Details: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid input format. Please enter numeric values!!");
            Console.WriteLine("Details: " + ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: Number is too large or too small!!");
            Console.WriteLine("Details: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred!!");
            Console.WriteLine("Details: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Finished");
        }

        Console.ReadKey();
    }
}