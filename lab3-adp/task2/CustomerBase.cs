using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_adp.task2
{
    public abstract class CustomerBase
    {
        public abstract string Type { get; }
        public abstract double Discount { get; }

        public double CalculateDiscount(double amount)
        {
            return amount * Discount;
        }
    }

    public class CustomerSilver : CustomerBase
    {
        public override string Type => "Silver";
        public override double Discount => 0.9;
    }

    public class CustomerGold : CustomerBase
    {
        public override string Type => "Gold";
        public override double Discount => 0.8;
    }
    public class CustomerPlatinum : CustomerBase
    {
        public override string Type => "Platinum";
        public override double Discount => 1.0;
    }

    public class CustomerRegular : CustomerBase
    {
        public override string Type => "Regular";
        public override double Discount => 0.2;
    }


}
