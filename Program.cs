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
            // Local variables
            // These are the minimum and maximum acceptable grades
            int MIN_GRADE = 0;
            // The max grade is going to be 150 when considering extra credit
            int MAX_GRADE = 150;

            // This is the maximum grade without extra-credit
            int MAX_WITHOUT_EC = 100;

            // The minimum grade levels are according to the syllabus
            // These are the minimum integer grades to recieve each letter grade.
            int MIN_A = 90;
            int MIN_B = 80;
            int MIN_C = 70;
            int MIN_D = 60;

            // Block of code to try to execute. If the program fails, it will continue to the catch section.
            try
            {
                // The console is going to request the user to enter an integer grade
                Console.WriteLine("What grade do you expect to earn in ISM 4300? Please enter an integer:");
                // The code reads the user's input and parses it out to an integer. The integer is then assigned to the new variable "grade"
                int grade = int.Parse(Console.ReadLine());

                // This initial IF statement ensures that the user has entered a grade within the acceptable range. If true, it will continue to the code within it. Else, it will continue to ELSE.
                if ((grade >= MIN_GRADE) && (grade <= MAX_GRADE)) {

                    // This repeats the value that the user entered
                    Console.WriteLine("You entered: " + grade.ToString());

                    // This is for grades where extra credit is seen
                    if (grade > MAX_WITHOUT_EC) {
                        Console.WriteLine("Whoa, A hardworker! Your letter grade is 'A'");
                        // Calculates and prints out the extra credits points!
                        Console.WriteLine((grade-MAX_WITHOUT_EC) + " extra-credit points!");
                    }

                    // For a perfect 100
                    else if (grade == MAX_WITHOUT_EC) {
                        Console.WriteLine("Yeay! A perfect score. Your letter grade is 'A'!");
                    }

                    // For a letter grade of A
                    else if ((grade >= MIN_A) && (grade <= MAX_WITHOUT_EC)) {
                        Console.WriteLine("Your letter grade is 'A'");
                    }

                    // For a letter grade of B
                    else if ((grade >= MIN_B) && (grade < MIN_A))
                    {
                        Console.WriteLine("Your letter grade is 'B'");
                    }

                    // For a letter grade of C
                    else if ((grade >= MIN_C) && (grade < MIN_B))
                    {
                        Console.WriteLine("Your letter grade is 'C'");
                    }

                    // For a letter grade of D
                    else if ((grade >= MIN_D) && (grade < MIN_C))
                    {
                        Console.WriteLine("Your letter grade is 'D'");
                    }

                    // For a letter grade of F
                    else if (grade < MIN_D)
                    {
                        Console.WriteLine("Your letter grade is 'F'");
                        Console.WriteLine("Better luck next time!");
                    }

                    // For a letter grade of F if they got a 0
                    else if (grade == MIN_GRADE)
                    {
                        Console.WriteLine("Your letter grade is 'F'");
                        Console.WriteLine("Are you even trying?");
                    }
                }
                
                // Code to execute if the user input is not within the acceptable range
                else
                // Explain the acceptable input values
                {
                    Console.WriteLine("Please enter a grade between the minimum of " + MIN_GRADE.ToString() + " and maximum of " + MAX_GRADE.ToString() + " (with extra-credit)!");
                }
                // Wait for user input before exiting
                Console.WriteLine("Please reopen the program to try again. Press any key to continue...");
                Console.ReadKey(true);
            }
            catch
            {
                // Explain the acceptable input values
                Console.WriteLine("Whoops! Something went wrong. Please enter a grade between the minimum of " + MIN_GRADE.ToString() + " and maximum of " + MAX_GRADE.ToString() + " (with extra-credit)!");
                // Wait for user input before exiting
                Console.WriteLine("Please reopen the program to try again. Press any key to continue...");
                Console.ReadKey(true);
            }
        }
    }
}
