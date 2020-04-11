using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge__Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] temp_arr = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(temp_arr, Int32.Parse);
            int length = n;

            for(int i=0; i<length/2;i++)
            {
                int temp = arr[i];
                arr[i] = arr[length - i - 1];
                arr[length - i - 1] = temp;
            }

            for(int j=0;j<n;j++)
            {
                Console.Write($"{arr[j]} ");
            }

            Console.ReadLine();
        }
    }
}
