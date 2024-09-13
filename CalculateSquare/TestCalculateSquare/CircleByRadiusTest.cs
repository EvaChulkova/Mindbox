using CalculateSquare;
using System;
using Xunit;

namespace TestCalculateSquare
{
    public class CircleByRadiusTest
    {
        [Fact]
        public void Test1()
        {
            var circule = new CircleByRadius();
            Assert.Throws<ArgumentException>(()=> circule.Calculate());
            
            var par = new double[1];
            Assert.Throws<ArgumentException>(() => circule.SetParameters(null));
            Assert.Throws<ArgumentException>(() => circule.SetParameters(new double[2]));
            Assert.Throws<ArgumentException>(() => circule.SetParameters(par));
           
            
            par[0] = -1.5;
            Assert.Throws<ArgumentException>(() => circule.SetParameters(par));
            
            par[0] = 1.5;
            circule.SetParameters(par);
            Assert.Equal(Math.PI*1.5*1.5, circule.Calculate());
        }
    }
}