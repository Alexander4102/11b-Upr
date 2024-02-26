using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemontNaPlochki.Model
{
    public class Plochki
     {
       private double n;
       private double w;
       private double l;
       private double m;
       private double o;

       public Plochki(double n, double w, double l, double m, double o)
       {
         this.N = n;
         this.W = w;
         this.L = l;
         this.M = m;
         this.O = o;

       }
          public double N { get; set; }
          public double W { get; set; }
          public double L { get; set; }
          public double M { get; set; }
          public double O { get; set; }

        public double CalculateNecessaryTiles()
        {
            var plosht = N * N;
            var pokrivane = plosht - O;
            var nujniPlochki = pokrivane / N;
            return nujniPlochki;
        }

        public double CalculateTime()
        {
            var plosht = N * N;
            var pokrivane = plosht - O;
            var nujniPlochki = pokrivane / N;
            var vreme = nujniPlochki * 0.2;
            return vreme;
        }
    }
}
