/*
Name: Jayden Mohacsi
Date: 01/19/2023
Description: Student grade using conditional statements 
*/
using System; 
namespace Deliverable_2_Mohacsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get in ISM4300?");
            string grade = Console.ReadLine();

            try
            {
                decimal n1 = decimal.Parse(grade);
                n1 = Math.Round(n1);

                if (n1 <= 59)
                {
                    Console.WriteLine("Your letter grade is F");
                }
                else if (n1 <= 69 && n1 >=60)
                {
                    Console.WriteLine("Your letter grade is D");
                }
                else if (n1 <= 79 && n1 >= 70)
                {
                    Console.WriteLine("Your letter grade is C");
                }
                else if (n1 <= 89 && n1 >= 80)
                {
                    Console.WriteLine("Your letter grade is B");
                }
                else
                {
                    Console.WriteLine("Your letter grade is A");
                }
                
            }
            catch
            {
                Console.WriteLine("Your letter grade is " + grade);
            }
        }
    }
}