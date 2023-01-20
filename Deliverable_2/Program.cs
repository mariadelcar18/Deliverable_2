/* 
 * Author: Maria del Carmen Perez Soto de Paiva 
 * Date: 1/20/2023
 * Description:C# Console Application to respond to a grade (number) input with a letter output. 
 */

using System;
namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating user instructions 
            Console.WriteLine("Please enter a numeric grade: ");
            
            // Creating a try-catch method to only allow numeric values.
            try 
            {
                // Creating and assigning variables 
                decimal grade = decimal.Parse(Console.ReadLine());
                string letter;

                // Creating conditions to assign letters to specific grades
                if (grade >= 98)
                {
                    letter = "A+";
                    Console.WriteLine("Your expected letter grade or ISM 4300 is " + letter + "!");
                }
                else if (grade >= 92 && grade < 98)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade or ISM 4300 is " + letter + "!");
                }
                else if (grade >= 90 && grade < 92)
                {
                    letter = "A-";
                    Console.WriteLine("Your expected letter grade or ISM 4300 is " + letter + "!");
                }
                else if (grade >= 88 && grade < 90)
                {
                    letter = "B+";
                    Console.WriteLine("Your expected letter grade or ISM 4300 is " + letter + "!");
                }
                else if (grade >= 82 && grade < 88)
                {
                    letter = "B";
                    Console.WriteLine("Your expected letter grade or ISM 4300 is " + letter + "!");
                }
                else if (grade >= 80 && grade < 82)
                {
                    letter = "B-";
                    Console.WriteLine("Your expected letter grade or ISM 4300 is " + letter + "!");
                }
                else if (grade >= 78 && grade < 80)
                {
                    letter = "C+";
                    Console.WriteLine("Your expected letter grade or ISM 4300 is " + letter + "!");
                }
                else if (grade >= 72 && grade < 78)
                {
                    letter = "C";
                    Console.WriteLine("Your expected letter grade or ISM 4300 is " + letter + "!");
                }
                else if (grade >= 70 && grade < 72)
                {
                    letter = "C-";
                    Console.WriteLine("Your expected letter grade or ISM 4300 is " + letter + "!");
                }
                else if (grade >= 68 && grade < 70)
                {
                    letter = "D+";
                    Console.WriteLine("Your expected letter grade or ISM 4300 is " + letter + "!");
                }
                else if (grade >= 62 && grade < 68)
                {
                    letter = "D";
                    Console.WriteLine("Your expected letter grade or ISM 4300 is " + letter + "!");
                }
                else if (grade >= 60 && grade < 62)
                {
                    letter = "D-";
                    Console.WriteLine("Your expected letter grade or ISM 4300 is " + letter + "!");
                }
                else
                {
                    letter = "F";
                    Console.WriteLine("Your expected letter grade or ISM 4300 is " + letter + "!");
                }
            }
            
            catch
            {
                Console.WriteLine("Please enter a numeric value. Other values will not be accepted.");
            }
        }
    }
}