using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquare
{
    public class TraingleByThreeSides : BaseFigure
    {
        private double side1 = -1;
        private double side2 = -1;
        private double side3 = -1;

        public override double Calculate()
        {
            if (side1 < 0 || side2 < 0 || side3 < 0)
            {
                throw new ArgumentException("Укажите длины сторон треугольника для расчёта площади фигуры");
            }

            var halfper = (side1 + side2 + side3) / 2;
            return Math.Sqrt(halfper * (halfper - side1) * (halfper - side2) * (halfper - side3));
        }

        public override void SetParameters(double[] parameters)
        {
            if (parameters == null || parameters.Length != 3)
            {
                throw new ArgumentException("Введено неверное количество параметров - укажите 3 значения длин сторон треугольника");

            }


            if (parameters[0] <= 0 || parameters[1] <= 0 || parameters[2] <= 0)
            {
                throw new ArgumentException("Введите значение длины строны треугольника больше нуля");
            }
            
            var par = parameters.OrderBy(x => x).ToArray();
            side1 = par[0];
            side2 = par[1];
            side3 = par[2];
        }


        public bool Is90Degree()
        {
            return Math.Abs(Math.Pow(side3, 2) - Math.Pow(side1, 2) - Math.Pow(side2, 2)) < 0.00001 ;
        }
    }
}
