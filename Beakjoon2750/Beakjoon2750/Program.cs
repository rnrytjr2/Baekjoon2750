using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beakjoon2750
{
    class Program
    {
        static void Main(string[] args)
        {
            int linecount = int.Parse(Console.ReadLine());
            int[] data = new int[linecount];
            for (int i = 0; i < linecount; i++)
            {
                data[i] = (int.Parse(Console.ReadLine()));
            }
            bool sortcheck = false;
            while (true)
            {
                sortcheck = false;
                for (int i = 0; i < data.Length; i++)
                {
                    if (i+1<data.Length)
                    {
                        if (data[i] > data[i+1])
                        {
                            int temp = data[i];
                            data[i] = data[i+1];
                            data[i+1] = temp;
                            sortcheck = true;
                        }
                    }
                }
                if (!sortcheck)
                {
                    break;
                }
            }
            for (int i = 0; i < linecount; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}
