using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  2. Составьте программу, вычисляющую A*B, не пользуясь 
    операцией умножения. А и B любое натуральное число.*/

namespace Lab_3_2_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 3;
            int B = 15;

            int sum = 0;
            for (int i = 0; i < B; i++)            
                sum += A;            
            Console.WriteLine($"{A}*{B} = {sum}");
            Console.ReadKey();
        }
    }
}
