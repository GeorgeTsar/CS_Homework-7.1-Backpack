using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Homework_7._1
{
    internal class Item
    {
        public string name { get; set; }
        public int volume { get; set; }


        public Item() : this(null, 0) { }
        public Item(string n, int vol)
        {
            name = n;

            if (volume < 0)
            {
                throw new VolumeException("Объём не может быть отрицательным");
            }

            volume = vol;
        }

        public void Show()
        {
            Console.WriteLine("\n{0}, {1}", name, volume);
        }

        public void Input()
        {
            Console.WriteLine("\nВведите название: ");
            name = Console.ReadLine();
            Console.WriteLine("\nВведите объём: ");
            volume = Int32.Parse(Console.ReadLine());
        }
    }
}
