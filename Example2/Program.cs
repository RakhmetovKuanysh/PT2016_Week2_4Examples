using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            F3();
        }

        private static void F3()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();
            string [] arr = line.Split(' ');
            int sum = 0;

            for (int i = 0; i < arr.Length; ++i)
            {
                sum += int.Parse(arr[i]); 
            }

            Console.WriteLine(sum);
            sr.Close();
            fs.Close();

        }

        private static void F2()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();

            Console.WriteLine(line);

            sr.Close();
            fs.Close();
        }

        private static void F1()
        {
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("hello world");

            sw.Close();
            fs.Close();     
        }
    }
}
