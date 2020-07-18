using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystemApp
{
    class NumberSystem
    {
        //Abc -- "Заданная система счисления"
        /// <summary>
        /// Строка символов системы счисления Abc по порядку (алфавит)
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
        /// <param name="numbers">Строка символов системы счисления Abc по порядку (алфавит)</param>
        public NumberSystem(string numbers)
        {
            this.numbers = numbers;
            lenght = numbers.Length;
            Dec = 0;
            Abc = numbers[0].ToString();
        }


        /// <summary>
        /// Устанавливает положительное десятичное число и его эквивалент в Abc системе счисления
        /// </summary>
        public void setDecNumber(int num)
        {
            Dec = Math.Abs(num);
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


        /// <summary>
        /// Представление десятичного числа в Abc системе счисления
        /// </summary>
        public string DecToABC(int Dec)
        {
            string result = "";

            if (Dec < lenght) 
                result += numbers[Dec];
            while (Dec >= 1)
            {
                result += numbers[Dec % lenght];
                Dec /= lenght;
            }

            result = Inverse(result);
            return result;
        }
        /// <summary>
        /// Представление Abc числа в десятичной системе счисления.  
        /// Вызывает исключение с текстом "UnknownSymbol" при нахождении неизвестного символа.
        /// </summary>
        public int AbcToDec(string Abc)
        {
            int Dec = 0;
            int ALenght = Abc.Length -1;
            for (int i = 0; i < Abc.Length; i++)
            {
                int index = numbers.IndexOf(Abc[i]);
                if (index == -1) throw new Exception("UnknownSymbol");
                Dec += index * (int)Math.Pow(lenght, Convert.ToDouble(ALenght-i));
            }

            return Dec;
        }


        /// <summary>
        /// Инвертирует строку
        /// </summary>
        private string Inverse(string str) 
        {
            string s = "";
            for (int i = str.Length - 1; i >= 0; i--)
                s += str[i].ToString();
            return s;
        } 
    }
}
