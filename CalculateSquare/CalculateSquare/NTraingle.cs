using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSquare
{
    public class NTraingle : BaseFigure
    {
        private double side = -1;
        private double amount = -1;
       

        public override double Calculate()
        {
            if (side < 0 || amount < 3)
            {
                throw new ArgumentException("Укажите длину стороны многоугольника и количество сторон");
            }

            return (amount * Math.Pow(side, 2)) / (4 * Math.Tan(Math.PI/amount));
        }

        public override void SetParameters(double[] parameters)
        {
            if (parameters == null || parameters.Length != 2)
            {
                throw new ArgumentException("Неверное количество параметров - укажите длину стороны многоугольника и количество сторон");

            }


            if (parameters[0] < 3 || parameters[1] <= 0)
            {
                throw new ArgumentException("Введите значение длины строны многоугольника и их количество больше нуля");
            }


            amount = Math.Truncate(parameters[0]);
            side = parameters[1];

        }
    }
}
