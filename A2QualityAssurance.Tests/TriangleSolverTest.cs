using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace A2QualityAssurance.Tests
{
    [TestFixture]
    public class TriangleSolverTest
    {
        //all three types of triangles should pass
        [Test]
        public void EquilateralShouldPass()
        {
            Assert.IsTrue(TriangleSolver.Analyze(5, 5, 5) == "E");
        }

        [Test]
        public void IsoscelesShouldPass()
        {
            Assert.IsTrue(TriangleSolver.Analyze(2, 2, 3) == "I");
        }

        [Test]
        public void ScaleneShouldPass()
        {
            Assert.IsTrue(TriangleSolver.Analyze(6, 5, 4) == "S");
        }

        //i Should get a "N" which means not a triangle
        [Test]
        public void ImpossibleSidesShouldFail()
        {
            Assert.IsTrue(TriangleSolver.Analyze(1, 2, 3) == "N");
        }

        //Decimals should work and not crash or be denied
        [Test]
        public void DecimalsShouldPass()
        {
            Assert.IsTrue(TriangleSolver.Analyze(3.4, 6.5, 4.5) == "S");
        }

        //you cannot make a shape with negative sides
        [Test]
        public void NegativesShouldFail()
        {
            Assert.IsTrue(TriangleSolver.Analyze(-5,-5,-5) == "N");
        }
    }
}
