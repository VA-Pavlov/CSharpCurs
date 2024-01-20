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
            Exercise8();
        }

        static void Exercise1()
        {
            Random random = new Random();
            int ArraySize = random.Next(5, 20);
            int[] MyArray = new int[ArraySize];
            Console.Write("array = {");
            for (int i = 0; i < ArraySize; i++)
            {
                MyArray[i] = random.Next(-100, 100);
                Console.Write(MyArray[i] + " ");
            }
            Console.WriteLine("}");

            Array.Sort(MyArray);
            int Counter = 0;
            for (int i = 0; i < ArraySize; i++)
            {
                while (i != ArraySize - 1 && MyArray[i] == MyArray[i + 1])
                {
                    i++;
                }
                Counter++;

            }

            Console.WriteLine(ArraySize + " " + Counter);
        }

        static void Exercise2()
        {
            int UserValue = int.Parse(Console.ReadLine());
            int[] MyArray = MakeRandomArray();
            int Counter = 0;
            for (int i = 0; i < MyArray.Length; i++)
                if (MyArray[i] < UserValue)
                    Counter++;
            ConsoleWriteArray(MyArray);
            Console.WriteLine(Counter);
        }

        static void Exercise3()
        {
            int UserNumberOne = int.Parse(Console.ReadLine());
            int UserNumberTwo = int.Parse(Console.ReadLine());
            int UserNumberTree = int.Parse(Console.ReadLine());

            int[] MyArray = {7,6,5,3,4,7,6,5,8,7,6,5};

            int Counter = 0;

            for(int i = 0; i < MyArray.Length-2; i++)
            {
                if (MyArray[i] == 7 && MyArray[i + 1] == 6 && MyArray[i + 2] == 5) Counter++;

            }
            ConsoleWriteArray(MyArray);
            Console.WriteLine(Counter);
        }

        //static void Exercise4()
        //{
        //    int ArraySizeOne = int.Parse(Console.ReadLine());
        //    int ArraySizeTwo = int.Parse(Console.ReadLine());

        //    int [] FirstArray = MakeRandomArray(ArraySizeOne);
        //    int[] SecondArray = MakeRandomArray(ArraySizeTwo);

        //    int [] MinSizeArrayLink = ArraySizeOne > ArraySizeTwo ? SecondArray : FirstArray;
        //    int [] MaxSizeArrayLink = ArraySizeOne <= ArraySizeTwo ? FirstArray : SecondArray;

        //    Array.Sort(MinSizeArrayLink);
        //    Array.Sort(MaxSizeArrayLink);

        //    for(int i = 0; i < MaxSizeArrayLink.Length; i++)
        //    {
        //        if(MinSizeArrayLink[0] ! MaxSizeArrayLink[i + 1])
        //    }
        //}

        static void Exercise5()
        {
            int[,] MyArray = { { 9, 3, 3, 4 }, { 11, 6, 5, 5 } };
            int MinValue = MyArray[0,0];
            int MaxValue = MyArray[0,0];
            
            foreach(int value in MyArray)
            {
                if (value > MaxValue) MaxValue = value;
                if (value < MinValue) MinValue = value;
            }
            Console.WriteLine($"Max: {MaxValue}\nMin: {MinValue}");
        }

        static void Exercise6()
        {
            string UaerLine = Console.ReadLine();
            Console.WriteLine(UaerLine.Split(' ').Length);
        }

        static void Exercise7()
        {
            string UaerLine = Console.ReadLine();
            string [] ArrayWordsFromUserLine = UaerLine.Split(' ');
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < ArrayWordsFromUserLine.Length; i++)
            {
                string Word = ArrayWordsFromUserLine[i];
                for(int q = Word.Length-1; q >= 0;q--)
                    stringBuilder.Append(Word[q]);
                stringBuilder.Append(i != ArrayWordsFromUserLine.Length - 1 ? " " : "");
            }
            string FinalLine = stringBuilder.ToString();
            Console.WriteLine(FinalLine);
        }

        static void Exercise8()
        {
            string UaerLine = Console.ReadLine();
            char[] Vowels = {'e','y','u','i','o','a'};
            string NewLine = String.Join("", UaerLine.ToLower().Split(Vowels));
            Console.WriteLine(UaerLine.Length - NewLine.Length);
            
        }

        static int[] MakeRandomArray()
        {
            Random random = new Random();
            int [] NewArray = new int[random.Next(0, 15)];
            for(int i = 0;i<NewArray.Length;i++)
                NewArray[i] = random.Next(-10,10);
            return NewArray;
        }
        static int[] MakeRandomArray(int size)
        {
            Random random = new Random();
            int[] NewArray = new int[size];
            for (int i = 0; i < NewArray.Length; i++)
                NewArray[i] = random.Next(0, 10);
            return NewArray;
        }

        static void ConsoleWriteArray(int[]InputArray)
        {          
            for (int i = 0; i < InputArray.Length; i++)
                Console.Write(InputArray[i]+" ");
            Console.Write("\n");
        }
    }
}
