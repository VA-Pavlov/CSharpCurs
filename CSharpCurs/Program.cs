using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberSeven();
        }

        static void NumberOne()
        {
            int UserNumber;
            Console.WriteLine("Введите число:");
            UserNumber = Console.Read();
            if (UserNumber % 3 == 0)
                Console.Write("Fizz ");
            if (UserNumber % 5 == 0)
                Console.Write("Buzz");
            else
                Console.WriteLine(UserNumber);
        }

        static void NumberTwo()
        {
            float UserNumberOne = int.Parse(Console.ReadLine());
            float UserNumberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine(UserNumberOne / 100 * UserNumberTwo);
        }

        static void NumberThree()
        {
            int UserNumberOne = int.Parse(Console.ReadLine());
            int UserNumberTwo = int.Parse(Console.ReadLine());
            int UserNumberTree = int.Parse(Console.ReadLine());
            int UserNumberFour = int.Parse(Console.ReadLine());

            int FinslNumber = UserNumberOne * 1000 + UserNumberTwo *100 + UserNumberTree * 10 + UserNumberFour;
            Console.WriteLine(FinslNumber);
        }

        static void NumberFour()
        {
            int UserNumber = int.Parse(Console.ReadLine());
            if (UserNumber < 1000000 && UserNumber > 99999)
            {
                int DigitOfNumberOne = int.Parse(Console.ReadLine());
                int DigitOfNumberTwo = int.Parse(Console.ReadLine());

                
            }
            else
                Console.WriteLine("Введено некорректное чило");

        }

        static void NumberFive() 
        {
            
            DateTime dateTime = DateTime.Parse(Console.ReadLine());
            switch(dateTime.Month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Winter " + dateTime.DayOfWeek);
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Spring " + dateTime.DayOfWeek);
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Summer " + dateTime.DayOfWeek);
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Autumn " + dateTime.DayOfWeek);
                    break;
            }
        }

        static void NumberSix()
        {
            Console.WriteLine("Введите температуру:");
            float UserNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Выбирете шкалу измереня:\n 1 - Фарнгей\n 2 - Цельсия ");
            int UstrSelection = int.Parse(Console.ReadLine());
            switch(UstrSelection)
            {
                case 2:
                    UserNumber = UserNumber * 9 / 5 + 32;
                    Console.WriteLine(UserNumber + "F");
                    break;
                case 1:
                    UserNumber = (UserNumber - 32) * 5 / 9;
                    Console.WriteLine(UserNumber + "C");
                    break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    NumberSix();
                    break;
            }
        }
        static void NumberSeven()
        {
            int UserNumberOne = int.Parse(Console.ReadLine());
            int UserNumberTwo = int.Parse(Console.ReadLine());

            if(UserNumberOne > UserNumberTwo)
            {
                int boxValue = UserNumberOne;
                UserNumberOne = UserNumberTwo;
                UserNumberTwo = boxValue;
            }

            for(int i = UserNumberOne; i <= UserNumberTwo; i++) 
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
        }
    }
}
