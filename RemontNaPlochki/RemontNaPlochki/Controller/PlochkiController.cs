using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RemontNaPlochki.Model;
using RemontNaPlochki.View;

namespace ddz.Model
{
    public class PlochkiController
    {
        private Display display;
        private Plochki plochki;

        public PlochkiController()
        {
            display = new Display();
            plochki = new Plochki(display.N, display.W, display.L, display.M, display.O);
            display.Plocki = plochki.CalculateNecessaryTiles(); 
            display.Vreme = plochki.CalculateTime(); 
            display.Show();
        }
    }
}

