using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Advance
{
    abstract class Car
    {
        public string brand;
        public string model;

        public abstract string getCarDetails();
       
    }
    
    class BMW : Car
    {
        public string specialFeactures;


        public override string getCarDetails() {

            return "Brand : "+this.brand+" Model : "+model+ " With Special Features : " + specialFeactures;   
        }
    }

    class Mercedez : Car
    {
        public string mileage;


        public override string getCarDetails()
        {

            return "Brand : " + this.brand + " Model : " + model + " With Mileage : " + mileage;
        }
    }
}
