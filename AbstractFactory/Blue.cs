﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Blue : IColor
    {
        public void Fill()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Blue");
        }
    }
}
