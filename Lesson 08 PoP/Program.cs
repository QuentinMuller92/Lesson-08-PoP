using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_08_PoP
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Rectangle rectangle = new Rectangle();
            //rectangle.setWidth(3);
            //rectangle.setWidth(4);
            //rectangle.getArea();

            //Point3D point3D = new Point3D(1, 2, 3);

            //FunOverload obj = new FunOverload();
            //obj.SetName("barack");
            //obj.SetName("barack ", " obama ");

            //Printdata p = new Printdata();
            //p.print(5);
            //p.print(500.263);
            //p.print("Hello C++");
            //Console.ReadKey();

            //Task 1
            //StudentAndTeacherTest test = new StudentAndTeacherTest();
            //test.Main();

            //Task2
            //AlbumTest albumTest = new AlbumTest();
            //albumTest.Test();

            //Homework
            Square square = new Square(4);

            Console.Write("Would you like to change the coordinates of a corner? (YES or NO) ");
            string answer = Console.ReadLine();
            int corner = -1;
            if(answer == "YES")
            {
                Console.Write("What's the number of the corner (0-3) > ");
                corner = Convert.ToInt32(Console.ReadLine());
                Console.Write("What's the new value of X > ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("What's the new value of Y > ");
                int y = Convert.ToInt32(Console.ReadLine());

                square.Move(corner, x, y);
            }
            
            Console.Write("\nWould you like to change the scale of the square? (YES or NO) ");
            answer = Console.ReadLine();
            if(answer == "YES")
            {
                Console.Write("What's the factor > ");
                int factor = Convert.ToInt32(Console.ReadLine());
                square.Scale(factor);
            }

            Console.WriteLine();
            Console.WriteLine(square.toString());
            SquareData squareData = new SquareData(square.SideLength);
            Console.WriteLine("Perimeter = " + squareData.getPerimeter() + ", Area = " + squareData.getArea());

            Console.ReadKey();
        }
    }
}
