using C__Homework_7._1;
using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;

class MainClass
{
    public static void Main()
    {
        Backpack B = new Backpack("Зелёный", "Монти", "Ткань", 1, 4);
        B.Show();

        Item[] I = new Item[4];
        Console.WriteLine("\nВещи для рюкзака:");
        I[0] = new Item("Бутылка воды", 1);
        I[1] = new Item("Яблоко", 1);
        I[2] = new Item("Зарядка", 1);
        I[3] = new Item("Ноутбук", 6);
        foreach (Item temp in I)
            temp.Show();

        Console.WriteLine("\n-------------------------------------------\n");

        B.Del += Color_Message;

        B.Put(I[0].volume);
        B.Put(I[1].volume);
        B.Put(I[2].volume);
        B.Put(I[3].volume);

        static void Color_Message(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}