using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculateSquare 
{
    public class CircleByRadius : BaseFigure
    {
        private double radius = -1;

        public override double Calculate()
        {
            if (radius < 0)
            {
                throw new ArgumentException("Укажите радиус для расчёта площади круга");
            }
            return Math.PI * radius * radius;
        }

        public override void SetParameters(double[] parameters)
        {
            if (parameters == null || parameters.Length != 1)
            {
                throw new ArgumentException("Неверное количество параметров - укажите только радиус");

            }
                

            if (parameters[0] <= 0)
            {
                throw new ArgumentException("Введите значение радиуса больше нуля");
            }
            radius = parameters[0];

        }
    }
}
