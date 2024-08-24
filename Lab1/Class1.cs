using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введіть ім'я студента: ");
            string firstName = Console.ReadLine();

            Console.Write("Введіть прізвище студента: ");
            string lastName = Console.ReadLine();

            Console.Write("Введіть вік студента: ");
            string sAge = Console.ReadLine();

            Console.Write("Введіть назву університету: ");
            string university = Console.ReadLine();

            Console.Write("Введіть спеціальність: ");
            string major = Console.ReadLine();

            Console.Write("Введіть рік навчання: ");
            string sYearOfStudy = Console.ReadLine();

            Console.Write("Введіть кількість оцінок: ");
            int numberOfGrades = int.Parse(Console.ReadLine());
            double[] grades = new double[numberOfGrades];

            for (int i = 0; i < numberOfGrades; i++)
            {
                Console.Write($"Введіть оцінку {i + 1}: ");
                grades[i] = double.Parse(Console.ReadLine());
            }

            Student student = new Student();
            student.FirstName = firstName;
            student.LastName = lastName;
            student.Age = int.Parse(sAge);
            student.University = university;
            student.Major = major;
            student.YearOfStudy = int.Parse(sYearOfStudy);
            student.Grades = grades;

            double averageGrade = student.CalculateAverageGrade();

            Console.WriteLine();
            Console.WriteLine("________________________________________________");
            Console.WriteLine("Дані про студента:");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("Ім'я: " + student.FirstName);
            Console.WriteLine("Прізвище: " + student.LastName);
            Console.WriteLine("Вік: " + student.Age.ToString());
            Console.WriteLine("Університет: " + student.University);
            Console.WriteLine("Спеціальність: " + student.Major);
            Console.WriteLine("Рік навчання: " + student.YearOfStudy.ToString());
            Console.WriteLine("Середній бал: " + averageGrade.ToString("0.00"));

            Console.ReadKey();
        }
    }

}

