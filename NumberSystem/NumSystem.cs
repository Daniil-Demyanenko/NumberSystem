using System;

namespace NumberSystem
{
    public class NumSystem
    {
        //Abc -- "Заданная система счисления"

        /// <summary>
        /// Строка символов системы счисления Abc по порядку (алфавит)
        /// </summary>
        public string numbers { private set; get; }
        /// <summary>
        /// Длинна алфавита (основание системы счисления)
        /// </summary>
        int lenght;
        /// <summary>
        /// Текущее число в десятичной системе счисления
        /// </summary>
        public int Dec { private set; get; }
        /// <summary>
        /// Текущее число в заданной системе счисления
        /// </summary>
        public string Abc { private set; get; }

        public NumSystem()
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
        public NumSystem(string numbers)
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
            Abc = DecToAbc(Dec);
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
        public string DecToAbc(int Dec)
        {
            Dec = Math.Abs(Dec);
            string result = "";

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
            int ALenght = Abc.Length - 1;
            for (int i = 0; i < Abc.Length; i++)
            {
                int index = numbers.IndexOf(Abc[i]);
                if (index == -1) throw new Exception("UnknownSymbol");
                Dec += index * (int)Math.Pow(lenght, Convert.ToDouble(ALenght - i));
            }

            return Dec;
        }

        /// <summary>
        /// Возвращает следующее число в Abc системе счисления
        /// </summary>
        public string NextAbc()
        {
            Dec++;
            Abc = DecToAbc(Dec);
            return Abc;
        }
        /// <summary>
        /// Возвращает предыдущее число в Abc системе счисления, если оно не отрицательное. Иначе возвращает нуль в Abc системе счисления.
        /// </summary>
        public string LastAbc()
        {
            if (Dec > 0)
            {
                Dec--;
                Abc = DecToAbc(Dec);
            }
            return Abc;
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
        /// <summary>
        /// Возвращает true если строка может являться значением в системе счисления Abc.
        /// </summary>
        public bool isValidAbc(string str)
        {
            bool Valid = true;

            for (int i = 0; i < str.Length; i++)
            {
                if (numbers.IndexOf(str[i]) == -1)
                {
                    Valid = false;
                    break;
                }
            }

            return Valid;
        }
    }
}
