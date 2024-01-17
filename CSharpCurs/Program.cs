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
            Exercise1();
        }

        static void Exercise1()
        {
            Random random = new Random();
            int ArraySize = random.Next(5, 20);
            int[] MyArray = new int[ArraySize];
            Console.Write("array = {");
            for(int i = 0; i < ArraySize;i++)
            {
                MyArray[i] = random.Next(-100, 100);
                Console.Write(MyArray[i]+" ");
            }
            Console.WriteLine("}");

            Array.Sort(MyArray);
            int Counter = 0;
            for(int i = 0;i < ArraySize;i++)
            {
                while (i != ArraySize - 1 && MyArray[i] == MyArray[i + 1]  )
                {
                    i++;
                }
                Counter++;

            }
            
            Console.WriteLine(ArraySize +" "+ Counter);
        }

        static void Exercise2()
        {

        }

        }
}
