using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Flower flower1 = new Flower();
            flower1.AddFlower("Троянда", "Червоний", true, 104);
            flower1.Fade();
            flower1.Blooming();
            flower1.ColorBud();
        }
    }
}
