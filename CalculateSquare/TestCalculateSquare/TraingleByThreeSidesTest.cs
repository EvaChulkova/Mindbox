using CalculateSquare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestCalculateSquare
{
    public class TraingleByThreeSidesTest
    {
        [Fact]
        public void TestTraingle()
        {
            var traingle = new TraingleByThreeSides();
            Assert.Throws<ArgumentException>(()=> traingle.Calculate());

            var param = new double[3];
            Assert.Throws<ArgumentException> (()=> traingle.SetParameters(null));
            Assert.Throws<ArgumentException> (()=> traingle.SetParameters(new double[1]));
            Assert.Throws<ArgumentException> (()=> traingle.SetParameters(param));
            
            param[0] = 1.5;
            Assert.Throws<ArgumentException>(() => traingle.SetParameters(param));
            
            param[1] = 2.0;
            Assert.Throws<ArgumentException>(() => traingle.SetParameters(param));

            param[2] = -1.5;
            Assert.Throws<ArgumentException>(() => traingle.SetParameters(param));

            param[2] = 3.0;
            var halfper = (1.5 + 2.0 + 3.0) / 2;
            var expectedValue = Math.Sqrt(halfper * (halfper - 1.5) * (halfper - 2.0) * (halfper - 3.0));

            traingle.SetParameters(param);
            Assert.Equal(expectedValue, traingle.Calculate());

            
            Assert.False(traingle.Is90Degree());

            param[0] = 7.0;
            param[1] = 24.0;
            param[2] = 25.0;
            traingle.SetParameters (param);
            Assert.True(traingle.Is90Degree());
        }

    } 
}
