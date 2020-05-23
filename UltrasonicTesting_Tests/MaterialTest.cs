using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UltrasonicTesting;

namespace UltrasonicTesting_Tests
{
    [TestClass]
    public class MaterialTest
    {
        [TestMethod]
        public void AcousticImpedanceTest()
        {
            // arrange
            double speedOfSound = 340;
            double density = 1.2;
            double fspl = 1.1;
            Material matetial = new Material(speedOfSound, density, fspl);


            // act
            double expected = 408;
            double delta = 0.00001; // погрешность 0.01%
            double actual = matetial.AcousticImpedance;

            // assert
            Assert.AreEqual(expected, actual, delta);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionSpeedOfSoundConstructor()
        {
            new Material(-1, 12, 12);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionDensityConstructor()
        {
            new Material(10, 0, 12);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionFsplConstructor()
        {
            new Material(10, 10, -1);
        }

    }
}
