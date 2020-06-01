using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UltrasonicTesting;
using UltrasonicTesting.Models;
using UltrasonicTesting.Attenuation;

namespace UltrasonicTesting_Tests
{
    [TestClass]
    public class AttenuationFresnelPlaneTest
    {
        AttenuationFresnelPlane attenuation;
        [TestInitialize]
        public void AttenuationFraunhoferPlaneTestInitialize()
        {
            // arrange
            double speedOfSound = 340;
            double density = 1.2;
            double fspl = 1.1;
            Material materialPEC = new Material(speedOfSound, density, fspl);

            double amplitude = 15;
            double frequency = 4000;
            AcousticWave acousticWave = new AcousticWave(amplitude, frequency);

            double radius = 0.02;
            RoundPEC roundPEC = new RoundPEC(radius, materialPEC, acousticWave);

            double speedOfSound2 = 3000;
            double density2 = 1.2;
            double fspl2 = 1.1;
            Material materialTO = new Material(speedOfSound2, density2, fspl2);

            TestObject testObject = new TestObject(materialTO, 0.2);

            attenuation = new AttenuationFresnelPlane(roundPEC, testObject);

        }
        [TestMethod]
        public void СalculateTest()
        {

            // act ///0,000986
            double expected = 0.188438;
            double delta = 0.00001; // погрешность 0.01%
            double actual = attenuation.Сalculate();
            // assert
            Assert.AreEqual(expected, actual, delta);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullExceptionPiezoelectricityConverterCtor()
        {
            new AttenuationFresnelPlane(null, new TestObject(new Material(1, 1, 1), 1));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullExceptionTestObjectCtor()
        {
            new AttenuationFresnelPlane(new RoundPEC(1, new Material(1, 1, 1), new AcousticWave(1, 1)), null);
        }
    }
}
