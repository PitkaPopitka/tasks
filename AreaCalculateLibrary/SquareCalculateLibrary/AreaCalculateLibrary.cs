using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareCalculateLibrary
{
    public static class Circle
    {
        public static double calculate(double rad) 
        {
            if (rad < 0)
            {
                MessageBox.Show("invalid value. Radius can't be less than 0");
                return 0;
            }
            else
            {
                double area = Math.PI * Math.Pow(rad, 2);
                return area;
            }
        }
    }

    public static class Triangle 
    {
        private static bool RightCheck(double first_side, double second_side, double third_side) 
        {
            var biggest_side = new[] { first_side, second_side, third_side }.Max();
            double biggest_sqr = biggest_side * biggest_side;
            if (biggest_sqr + biggest_sqr == first_side * first_side + second_side * second_side + third_side * third_side)
            {
                Console.WriteLine("triangle is right");
                return true;
            }
            else
            {
                Console.WriteLine("triangle is'nt right");
                return false;
            }
        }

        public static double calculate(double first_side, double second_side, double third_side) 
        {
            if (first_side > second_side + third_side || second_side > first_side + third_side || third_side > first_side + second_side)
            {
                Console.WriteLine("Triangle can not exist");
                return 0;
            }
            else
            {
                double semi_perimeter = (first_side + second_side + third_side) / 2;
                double area = Math.Sqrt(semi_perimeter * (semi_perimeter - first_side) * (semi_perimeter - second_side) * (semi_perimeter - third_side));
                RightCheck(first_side, second_side, third_side);
                return area;
            }
        }
    }
}
