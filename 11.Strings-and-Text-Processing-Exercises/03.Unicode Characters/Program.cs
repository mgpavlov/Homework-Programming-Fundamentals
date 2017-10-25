﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var result = input.Select(t => $@"\u{Convert.ToUInt16(t):x4}").ToList();

            Console.WriteLine(String.Join("",result));
        }
    }
}
