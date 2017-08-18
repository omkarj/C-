using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_Part2
{
    class DelegateExample
    {
        public delegate void CalculateSimpleInterest(double Principle, double RateOfInterest, double Year);


        public void GetTotalInterest(double Principle, double RateOfInterest, double Year)
        {
            Console.WriteLine("Total Interest : {0}", (Principle * (RateOfInterest * 0.01) * Year));
        }

        public void GetInterestRatePerYear(double Principle, double RateOfInterest, double Year)
        {
            Console.WriteLine("Interest Rate Per Year : {0}%", RateOfInterest);
        }

        public void CallDelegates(DelegateExample d)
        {
            Console.WriteLine("Using Instance Method");
            Console.WriteLine("Enter Principle, Rate of Interest & Number of Years Respectively :");
            double principle = Convert.ToDouble(Console.ReadLine());
            double ROI = Convert.ToDouble(Console.ReadLine());
            double years = Convert.ToDouble(Console.ReadLine());

            //Instance Method
            CalculateSimpleInterest d0 = new CalculateSimpleInterest(d.GetTotalInterest);
            d0 += new CalculateSimpleInterest(d.GetInterestRatePerYear);
            d0(principle, ROI, years);
        }
    }
}