﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDynamicAX.AX.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicExecuter de = new DynamicExecuter();
            var result = de.Execute("TestDynamicAX.DynamicFileList", "{Path:'abc'}");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
