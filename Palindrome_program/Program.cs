using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_program
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int num, temp;
            Console.Write("Enter a Number To Check Palindrome : ");
            num = Convert.ToInt32(Console.ReadLine());
            int rem, sum = 0;
            temp = num;
            while (num > 0)
            {
                 
                rem = num % 10;
             
                sum = (sum * 10) + rem;
                
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine($"Number {temp} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"Number {temp} is not Palindrome");
            }
            
        }
    }
 }

