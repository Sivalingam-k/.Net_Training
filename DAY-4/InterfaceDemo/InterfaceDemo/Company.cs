namespace InterfaceDemo
{
    internal class Company : IAddress, IContact
    {
        public string cname;
        public string addressLine1 { get; set; }
        public string city { get ; set; }
        public string state { get ; set ; }
        public int postcode { get; set ; }
        public string email { get; set; }
        public long mobile { get; set ; }

        public void AddressDetails()
        {
            Console.WriteLine("CompanyDetails :");
            Console.WriteLine("CompanyName :" + cname);

            string address=this.addressLine1 +","+this.city+","+this.city+","+this.state+","+this.postcode;
            Console.WriteLine(address);
          
        }


        public void getContactDetails()
        {
            Console.WriteLine("Company Contact Details :");
            Console.WriteLine("Phone : " + this.mobile);
        }
    }
}
