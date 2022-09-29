using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountAreaLibrary
{
    public class CountAreaLibrary
    {
        /// <summary>
        /// Вычисление площади треугольника по трем сторонам
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        double Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentException($"No side that is less than 0!\n Error!");
            else
                if (a > (b + c) || b > (a + c) || c > (a + b))
                throw new ArgumentException($"No side of triangle that is more then sum of other two!\n Error! ");
            else
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }

        /// <summary>
        /// Вычисление площади окружности по диаметру
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        double Circle(double r)
        {
            if (r < 0)
                throw new ArgumentException($"No radius of circle that is less than 0!\n Error!");
            else
                return Math.PI * Math.Pow(r, 2);
        }
    }
}