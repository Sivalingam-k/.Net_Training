
public delegate void calloutmyname(string username);

class publisherDemo
{
    public event calloutmyname callname;

    public void raiseEvent(string username)
    {
        callname(username);
    }
}
class subscriberDemo
{
    public void subscribercallname(string username)
    {
        Console.WriteLine("Good Morning : " + username);
    }

    public void connect()
    {
        publisherDemo pc = new publisherDemo();
        pc.callname += subscribercallname;
        pc.raiseEvent("Siva");
        pc.raiseEvent("Lingam");

    }

}
class DelegatesDemo
{

   
    public void Add(int a, int b)
    {
        int c = a + b;
        Console.WriteLine("Sum of " + a + " + " + b + " = " + c);
    }

    public void multiply(int a, int b)
    {
        int c = a * b;
        Console.WriteLine("Multiply of " + a + " * " + b + " = " + c);
    }

    public void substract(int a, int b)
    {
        int c = a - b;
        Console.WriteLine("Multiply of " + a + " - " + b + " = " + c);
    }

    public void div(int a, int b)
    {
        int c = a / b;
        Console.WriteLine("Division of " + a + " /" + b + " = " + c);
    }

}
public delegate void numberopersations(int a, int b);


class Program
{
    private static void Main(string[] args)
    {
        //numberopersations no;
        //DelegatesDemo dd = new DelegatesDemo();
        //no = dd.Add;
        //no += dd.substract;
        //no += dd.multiply;
        //no += dd.div;
        //no(20, 30);

        subscriberDemo sc = new subscriberDemo();
        sc.connect();

    }
}