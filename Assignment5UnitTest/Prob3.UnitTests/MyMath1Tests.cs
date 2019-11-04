using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Prob3;

namespace Prob3.UnitTests
{
    [TestFixture]
    public class MyMath1Tests
    {
        [Test]
        public void Add_SumWithinByteRange_ReturnCorrectSum()
        {
            Assert.AreEqual(192, Prob3.MyMath1.Add(96, 96));
        }

        [Test]
        public void Add_SumOutsideByteRange_ReturnIncorrectSum()
        {
            Assert.AreEqual(320, Prob3.MyMath1.Add(160, 160));
        }
    }
}
