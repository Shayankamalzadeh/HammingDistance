﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingDistanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string a;
                string b;
                int result;
                Hamming.Hamming haming = new Hamming.Hamming();
                Console.WriteLine("Please write a string");
                a = Console.ReadLine();
                Console.WriteLine("Please write another string");
                b = Console.ReadLine();
                try
                {
                    result = haming.HamingSpace(a, b);
                    Console.WriteLine("Hamming Distance is:{0}", result.ToString());
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Oops:{0}", ex.Message);
                }

                Console.WriteLine();
                Console.WriteLine("If you do not continue please write 'exit' ");
            } while ("exit" != Console.ReadLine());
        }
    }
}
