using System;
using System.Collections.Generic;
using System.IO;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Can't divide by zero");

            }

            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {

            if (String.IsNullOrEmpty(fileName))
            {
                throw new ArgumentOutOfRangeException("can't pass an empty string");
            }
            else if (fileName.Contains(".cs"))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Divide(10, 2));
                Console.WriteLine(Divide(10, 0));
                Console.WriteLine(Divide(10, 2));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");



            foreach (KeyValuePair<string, string> stu in students)
            {
                try
                {
                    Console.WriteLine(CheckFileExtension(stu.Value));
                    Console.WriteLine("*******************");
                }


                catch (ArgumentOutOfRangeException x)
                {
                    Console.WriteLine(x.Message);
                }
            }
        }
    }
}
