using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kp3
{
    class Flower:Bud
    {
        public string Name;
        public void AddFlower(string name,string color,bool bloom,int petals)
        {
            Name = name;
            Color = color; 
            Bloom = bloom;
            Petals = petals;
        }
    }
    class Bud:Petal
    {
        public string Color;
        public bool Bloom;

        public void Blooming()
        {
            if (Bloom)
            {
                Console.WriteLine("Квітка цвіте");
            }
            else
            {
                Bloom = true;
                Console.WriteLine("Квітка зацвіла");
            }
        }

        public void Fade()
        {
            if (Bloom)
            {
                Bloom = false;
                Console.WriteLine("Квітка зів'яла");
            }
            else 
            {
                Console.WriteLine("Квітка уже зів'яла");
            }
        }

        public void ColorBud()
        {
            if (!Bloom)
            {
                Console.WriteLine("Квітка не цвіте");
            }
            else
            {
                Console.WriteLine(Color);
            }
        }
    }
    class Petal
    {
        public int Petals;
    }
}
