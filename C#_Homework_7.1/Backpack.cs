using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace C__Homework_7._1
{
    public delegate void BackpackDel(string message);   // Делегат
    internal class Backpack
    {
        public string color { get; set; }
        public string firm { get; set; }
        public string fabric { get; set; }
        public int weight { get; set; }
        public int volume { get; set; }

        public event BackpackDel Del;    // Событие

        public Backpack() : this(null, null, null, 0, 0) { }
        public Backpack(string col, string fir, string fab, int wei, int vol)
        {
            color = col;
            firm = fir;
            fabric = fab;

            if (weight < 0)
            {
                throw new WeightException("Вес не может быть отрицательным");
            }
            if (volume < 0)
            {
                throw new VolumeException("Объём не может быть отрицательным");
            }

            weight = wei;
            volume = vol;
        }

        public void Show()
        {
            Console.WriteLine("\n{0}, {1}, {2}, {3}, {4}", color, firm, fabric, weight, volume);
        }

        public void Input()
        {
            Console.WriteLine("\nВведите цвет рюкзака: ");
            color = Console.ReadLine();
            Console.WriteLine("\nВведите фирму-производителя рюкзака: ");
            firm = Console.ReadLine();
            Console.WriteLine("\nВведите материал рюкзака: ");
            fabric = Console.ReadLine();
            Console.WriteLine("\nВведите вес рюкзака: ");
            weight = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nВведите объём рюкзака: ");
            volume = Int32.Parse(Console.ReadLine());
        }

        public void Put(int _vol)
        {
            if (_vol <= volume)
            {
                _vol -= volume;

                Del?.Invoke("Предмет в рюкзаке");
            }
            else
            {
                Del?.Invoke("Предмет не помещается!");
            }
        }
    }
}
