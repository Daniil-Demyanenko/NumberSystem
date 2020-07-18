using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "0123456789" + //Алфавит для перебора
                "abcdefghijklmnopqrstuvwxyz" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var NS = new NumberSystem(numbers); //Инициализация
            NS.setAbcNumber("pf16"); //Установка начального числа


            for (int i = 0; i < 20; i++)
                Console.WriteLine("https://prnt.sc/1n{0}", NS.NextAbc());

            Console.ReadLine();
        }
    }
}
