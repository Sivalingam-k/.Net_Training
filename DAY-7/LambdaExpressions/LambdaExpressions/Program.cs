

using LambdaExpressions;

internal class Program
{
    private static void Main(string[] args)
    {


        var numbers = new int[] { 1, 2, 3, 4, 5, 6, 8 };
        //Inline Lambda or Expression lambdas
        var count = numbers.Count(x => x % 2 == 0);
        Console.WriteLine(count);

        List<int> numbers1 = new List<int> { 2, 43, 55,5, 7, 8, 9, 5 };
        //Statement lambdas
        int count1 = numbers1.Count(x =>
        {
            return x==5;
        });

        Console.WriteLine(count1);

        //Function Lambdas: Func is type of delegate

        Func<int, int> squareDelegate = x => x * x;
        Console.WriteLine(squareDelegate(2));


        //Inner Class : class contain one Another class inside it.

        InnerClass.Address.Contact c=new InnerClass.Address.Contact();
        c.getContact();
    }
}