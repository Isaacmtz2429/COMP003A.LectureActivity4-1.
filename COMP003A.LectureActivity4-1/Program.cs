/*
// Author: Isaac Martinez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Calculate average grades using arrays and lists in C#
*/
namespace COMP003A.LectureActivity4_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter grade for student 1 (0-100): ");

            // Declare an array to store 5 grades
            int[] grades = new int[5];

            // Collect, validate, then store the grades
            for (int i = 0; i < grades.Length; i++)
            {
                int grade = -1; // Initialize with an invalid value to ensure validation starts
                while (grade < 0 || grade > 100)
                {
                    Console.Write($"Enter grade for student {i + 1} (0-100): ");
                    if (int.TryParse(Console.ReadLine(), out grade)) // Check if input is a valid integer
                    {
                        if (grade >= 0 && grade <= 100)
                        {
                            grades[i] = grade;
                        }
                        else
                        {
                            Console.WriteLine("Grade must be between 0 and 100.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        grade = -1; // Reset grade to an invalid value to re-enter the loop
                    }
                    // Calculate the average grade
                    double sum = 0;
                    for (int i = 0; i < grades.Length;i++)
                    {
                        sum += grades[i]; // Add the currect grade to the total sum for avergaing
                    }
                    double average = sum / grades.Length;

                    // Display the grade and average
                    Console.WriteLine("\nGrades: ");
                    foreach (int grade  in grades)
                    {
                        Console.WriteLine(grade); // Display each grade stored in the array
                    }
                    Console.WriteLine($"Average Grade: {average: F2}");
                }
            }
        }

        
        
    }
}
