using System;

namespace assignment1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your expression for addition:");

            // Get the Values from User..
           string strLine= Console.ReadLine();

            // storing only number into string array..
            string[] sTrim = strLine.Split('+');

            int sum = 0;

            try
           {
                Console.WriteLine("your numbers are:" );
                for (int i = 0; i < sTrim.Length; i++)
               {
               Console.WriteLine(sTrim[i] + ",");
                    sum = sum + Convert.ToInt32(sTrim[i]);
                }

                Console.WriteLine("Addition of your numbers is:"+sum);
             

            }
           catch (Exception e)
           {
               Console.WriteLine("error:"+ e.Message);
           }
          
       
        }
    }
}

