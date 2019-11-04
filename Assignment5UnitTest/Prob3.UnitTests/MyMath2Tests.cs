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
    public class MyMath2Tests
    {
        [Test]
        public void Add_SumWithinByteRange_ReturnCorrectSum()
        {
            Assert.That(Prob3.MyMath2.Add(96, 96), Is.EqualTo(192));
        }

        [Test]
        public void Add_SumOutsideByteRange_ThrowsException()
        {
            Assert.That(() => Prob3.MyMath2.Add(160, 160), Throws.Exception);
        }
    }
}
