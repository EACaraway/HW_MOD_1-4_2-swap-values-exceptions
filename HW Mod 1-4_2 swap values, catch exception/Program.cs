using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HW_MOD_1_4_2_swap_values__catch_exception
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user for dividend and divisor and then Tryparse to int.
            Console.Write("Please ender your dividend: ");
            int.TryParse(Console.ReadLine(), out int dividend);
            Console.Write("Please ender your divisor: ");
            int.TryParse(Console.ReadLine(), out int divisor);

            //per HW instructions, swap user dividend and divisor.
            Swap(ref dividend,ref divisor);
            
            Divide(dividend, divisor, out int quotient);
            Console.WriteLine($"{dividend} / {divisor} = {quotient}");
            
        }

        // method that divides and throws an exception if you try to divide by 0.
        public static int Divide(int a, int b, out int quotient)
        {
            try
            {
                quotient = a / b;
                return quotient;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
                quotient = 0;
                return quotient;
            }
            
            //if (b != 0)
            //{
            //    return a/b;
            //}
            //else
            //{
            //    throw new System.DivideByZeroException("You can't divide by zero.");
                
            //}
            
        }

        // use ref to swap values in memory instead of pointing to a value in memory.
        public static void Swap( ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
