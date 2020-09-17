// Author: Varghese Charly
// Project Name: Tech Assignment 2b
// Purpose: The code is designed to take in a integer grade and convert that to a letter grade according to specifications on the syllabus.

using System;

namespace Tech_Assign_2b
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What grade do you expect to earn in ISM 4300? Please enter an integer:");
                int grade = int.Parse(Console.ReadLine());
                
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
