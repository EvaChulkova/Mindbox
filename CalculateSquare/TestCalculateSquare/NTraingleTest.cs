using CalculateSquare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestCalculateSquare
{
    public class NTraingleTest
    {
        [Fact]
        public void TestNTraingle()
        {
            var ntraingle = new NTraingle();
            Assert.Throws<ArgumentException>(() => ntraingle.Calculate());

            var param = new double[2];
            Assert.Throws<ArgumentException>(() => ntraingle.SetParameters(null));
            Assert.Throws<ArgumentException>(() => ntraingle.SetParameters(new double[1]));
            Assert.Throws<ArgumentException>(() => ntraingle.SetParameters(param));

            param[0] = 1.5;
            Assert.Throws<ArgumentException>(() => ntraingle.SetParameters(param));
            
            param[0] = 4.0;
            param[1] = - 2.0;
            Assert.Throws<ArgumentException>(() => ntraingle.SetParameters(param));


            //traingle
            param[0] = 3;
            param[1] = 2;

            ntraingle.SetParameters(param);
            Assert.True(Math.Abs( 2*Math.Sin(Math.PI*120/180)- ntraingle.Calculate())<0.000001);

            //4square
            param[0] = 4;
            param[1] = 2;

            ntraingle.SetParameters(param);
            Assert.True(Math.Abs(4.0 - ntraingle.Calculate())<0.000001);


            //6square
            param[0] = 6;
            param[1] = 2;
            var expectedValue = (param[0] * Math.Pow(param[1], 2)) / (4 * Math.Tan(Math.PI / param[0]));

            ntraingle.SetParameters(param);
            Assert.Equal(expectedValue, ntraingle.Calculate());
        }
    }
}
