using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class MathOperation
    {
        private double num1;
        private double num2;

        public MathOperation(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        private void Addition()
        {
            double add =this.num1 + this.num2;
            Console.Write("Addition :"+add);

        }
        private void Subtraction()
        {
            double sub =this.num1 - this.num2;
            Console.Write("Subtraction :" +sub);
        }
        private void Multiply()
        {
            double mul = (this.num1 * this.num2);
            Console.Write("MUltiplication :"+mul);
        }
        private void Divide()
        {
            if (num2 == 0)
            {
                Console.WriteLine("Please Enter Valid Number to see Output");
            }
            else
            {
                double div = (this.num1 / this.num2);
                Console.Write("Divide :" + div);
            }
        }

        public void display()
        {
            MathOperation mo = new MathOperation(num1,num2);
            mo.Addition();
            Console.WriteLine();
            mo.Subtraction();
            Console.WriteLine();
           
            mo.Multiply();
            Console.WriteLine();
            mo.Divide();
            Console.WriteLine();
        }
    }
}
