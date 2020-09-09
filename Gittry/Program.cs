using System;

namespace Gittry
{
    class Program
    {

        static void Main(string[] args)
        {

            
            
                int num1, num2;
            
            
                Console.WriteLine("please enter the Number1");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter the Number2");
                num2 = Convert.ToInt32(Console.ReadLine());
            
            
                int result = num1 + num2;
            
                Console.WriteLine("Sum of two Numbers"+ result.ToString());
                Console.ReadLine();
            
            

        }
    }
}
