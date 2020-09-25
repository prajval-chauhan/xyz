using System;
using System.Dynamic;

namespace Coding_Exercise_1
{
    class Example
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Program");
            var random = new Random();
            var randomBool = random.Next(2);
            String attendance;
            if (randomBool == 0)
                attendance = "Present";
            else
                attendance = "Absent";
            Console.WriteLine("Employee is : " + attendance);
            int wph = 20;
            int fdh = 8;
            Console.WriteLine("Enter the number of days the employee was present : ");
            int days = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the total extra time he's worked (in hours) : ");
            int pth = Convert.ToInt16(Console.ReadLine());
            int wage = (days * fdh * wph) + (pth * wph);
            Console.WriteLine("The total wage of the employee is: Rs." +wage );
            
        }
    }

    class Coordinate_Geometry
    {
        static void los(string[] args)
        {
            Console.WriteLine("Enter the coordinates of the first point: ");
            int x1 = Convert.ToInt16(Console.ReadLine());
            int y1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the coordinates of the second point: ");
            int x2 = Convert.ToInt16(Console.ReadLine());
            int y2 = Convert.ToInt16(Console.ReadLine());
            double distance = Math.Sqrt((x1 - x2) ^ 2 + (y1 - y2) ^ 2);
            Console.WriteLine(distance);
        }
    }
}
