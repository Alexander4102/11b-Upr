using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemontNaPlochki.View
{
    public class Display
    {
        public Display()
        {
            this.N = 0;
            this.W = 0;
            this.L = 0;
            this.M = 0;
            this.O = 0;
            this.Plocki = 0;
            this.Vreme = 0;
            this.GetValue();
        }
       
        public double N { get; set; }
        public double W { get; set; }
        public double L { get; set; }
        public double M { get; set; }
        public double O { get; set; }

        public double Plocki { get; set; }
        public double Vreme { get; set; }

        public void GetValue()
        {
            N = double.Parse(Console.ReadLine());
            W = double.Parse(Console.ReadLine());
            L = double.Parse(Console.ReadLine());
            M = double.Parse(Console.ReadLine());
            O = double.Parse(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine($"{this.Plocki:F2}");
            Console.WriteLine($"{this.Vreme:F2}");
        }
    }
}
