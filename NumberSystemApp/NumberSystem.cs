using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystemApp
{
    class NumberSystem
    {
        /// <summary>
        /// Строка символов системы счисления по порядку (алфавит)
        /// </summary>
        string numbers;
        /// <summary>
        /// Длинна алфавита (основание системы счисления)
        /// </summary>
        int lenght;
        /// <summary>
        /// Текущее число в десятичной системе счисления
        /// </summary>
        int Dec;
        /// <summary>
        /// Текущее число в заданной системе счисления
        /// </summary>
        string Abc;

        public NumberSystem() 
        {
            numbers = "01";
            lenght = numbers.Length;
            Dec = 0;
            Abc = numbers[0].ToString();
        }
        /// <summary>
        /// Инициализирует систему счисления
        /// </summary>
        public NumberSystem(string abc)
        {
            numbers = abc;
            lenght = numbers.Length;
            Dec = 0;
            Abc = numbers[0].ToString();
        }

        /// <summary>
        /// Устанавливает десятичное число и его эквивалент в Abc системе счисления
        /// </summary>
        public void setDecNumber(int num)
        {
            Dec = num;
            Abc = DecToABC(num);
        }
        /// <summary>
        /// Устанавливает число Abc и его эквивалент в десятичной системе счисления
        /// </summary>
        public void setAbcNumber(string num)
        {
            Dec = AbcToDec(num);
            Abc = num;
        }

        public string DecToABC(int Dec)
        {
            return "0";
        }
        public int AbcToDec(string Abc)
        {
            return 0;
        }
    }
}
