using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;


namespace VariableEntorno
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;

            value = Environment.GetEnvironmentVariable("TestFinal1", EnvironmentVariableTarget.User);
            Console.WriteLine("Valor de la variable: {0}\n", value);
            Console.ReadKey();

        }
    }
}
