﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        private class Test
        {
            public void Print()
            {
                try
                {
                    throw new Exception();
                }
                catch (Exception)
                {
                    Console.Write("9");
                    throw new Exception();
                }
                finally
                {
                    Console.Write("2");
                }
            }
        }
        static void Main(string[] args)
        {
            var test = new Test();
            try
            {
                test.Print();
            }
            catch (Exception)
            {
                Console.Write("5");
            }
            finally
            {
                Console.Write("4");
            }
            Console.ReadLine();
        }
    }
}
