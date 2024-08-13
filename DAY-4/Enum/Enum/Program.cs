using System.Net.Http.Headers;

enum PaymentOptions
{
    CreditCard, DebitCard, NetBanking, Wallet
}
class Payment
{
    public string invoicename { get; set; }
    public PaymentOptions options;
    public static int noofpayments, paymentoptionscountC, paymentoptionscountD, paymentoptionscountN, paymentoptionscountW;
    static Payment()
    {
        noofpayments = 0;
        paymentoptionscountC = 0;//1
        paymentoptionscountD = 0;
        paymentoptionscountN = 0;
        paymentoptionscountW = 0;
    }
    public Payment()
    {
        noofpayments += 1;
    }
    public void getPayementOptionWiseCount()
    {
        if (this.options == PaymentOptions.CreditCard)
        {
            paymentoptionscountC += 1;
        }
        else if (this.options == PaymentOptions.DebitCard)
        {
            paymentoptionscountD += 1;
        }
        else if (this.options == PaymentOptions.NetBanking)
        {
            paymentoptionscountN += 1;
        }
        else if (this.options == PaymentOptions.Wallet)
        {
            paymentoptionscountW += 1;
        }
        else
        {
            Console.WriteLine("No options");
        }
    }
    public override string ToString()
    {
        System.Console.WriteLine(base.GetHashCode());
        return "Class1.ToString";
    }
}

class Profile<t1, t2> {
    public t1 Gender;
    public t2 isAdult;
}


class Program
{
    private static void Main(string[] args)
    {
        Profile<string, bool> pro = new Profile<string, bool>();
        pro.Gender = "Male";
        pro.isAdult = true;

        Profile<int, int> pro1 = new Profile<int, int>();
        pro1.Gender = 1;
        pro1.isAdult = 0;
        string gender = pro1.Gender == 1 ? "Male" : "Female";
        string adult = pro1.isAdult == 1 ? "True" : "False";
        Console.WriteLine("Gender : " + pro.Gender);
        Console.WriteLine("Adult : " + pro.isAdult);

        Console.WriteLine("Gender : " + gender);
        Console.WriteLine("Adult : " + adult);



        Payment p = new Payment();
        p.invoicename = "BroadBandBill";
        p.options = PaymentOptions.CreditCard;
        p.getPayementOptionWiseCount();
        Console.WriteLine(p.invoicename + " is paid by " + p.options);

        Payment p1 = new Payment();
        p1.invoicename = "AmazonShopping";
        p1.options = PaymentOptions.Wallet;
        p1.getPayementOptionWiseCount();
        Console.WriteLine(p1.invoicename + " is paid by " + p1.options);

        Payment p2 = new Payment();
        p2.invoicename = "AmazonShopping - 1";
        p2.options = PaymentOptions.NetBanking;
        p2.getPayementOptionWiseCount();
        Console.WriteLine(p2.invoicename + " is paid by " + p2.options);


        Payment p3 = new Payment();
        p3.invoicename = "AmazonShopping-2";
        p3.options = PaymentOptions.Wallet;
        p3.getPayementOptionWiseCount();
        Console.WriteLine(p3.invoicename + " is paid by " + p3.options);

        Console.WriteLine("No of Payment recieved: " + Payment.noofpayments);
        Console.WriteLine("No of times Credit Card Used: " + Payment.paymentoptionscountC);
        Console.WriteLine("No of times Debit Card Used: " + Payment.paymentoptionscountD);
        Console.WriteLine("No of times NetBanking  Used: " + Payment.paymentoptionscountN);
        Console.WriteLine("No of times Wallet  Used: " + Payment.paymentoptionscountW);
    }
}