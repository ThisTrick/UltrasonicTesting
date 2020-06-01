using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UltrasonicTesting;
using UltrasonicTesting.Models;

namespace UltrasonicTesting_Tests
{
    [TestClass]
    public class RoundPECTest
    {
        static RoundPEC roundPEC;
        [ClassInitialize]
        public static void RoundPECTestInitialize(TestContext testContext)
        {
            // arrange
            double radius = 0.02;

            double speedOfSound = 340;
            double density = 1.2;
            double fspl = 1.1;
            Material material = new Material(speedOfSound, density, fspl);

            double amplitude = 15;
            double frequency = 4000;
            AcousticWave acousticWave = new AcousticWave(amplitude, frequency);

            roundPEC = new RoundPEC(radius, material, acousticWave);
        }

        [TestMethod]
        public void ThicknessTest()
        {
            // act
            double expected = 0.0425; 
            double delta = 0.00001; // погрешность 0.01%
            double actual = roundPEC.Thickness;
            // assert
            Assert.AreEqual(expected, actual, delta);

        }
        [TestMethod]
        public void AreaTest()
        {
            // act
            double expected = 0.001256637;
            double delta = 0.00001; // погрешность 0.01%
            double actual = roundPEC.Area;
            // assert
            Assert.AreEqual(expected, actual, delta);
        }
        [TestMethod]
        public void FresnelDistanceTest()
        {
            // act
            double expected = 0.00470588; 
            double delta = 0.00001; // погрешность 0.01%
            double actual = roundPEC.FresnelDistance;
            // assert
            Assert.AreEqual(expected, actual, delta);
        }
        [TestMethod]
        public void FraunhoferDistanceTest()
        {
            // act
            double expected = 0.01411764; //0,01411764
            double delta = 0.00001; // погрешность 0.01%
            double actual = roundPEC.FraunhoferDistance;
            // assert
            Assert.AreEqual(expected, actual, delta);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ArgumentOutOfRangeExceptionRadiusConstructur()
        {
            new RoundPEC(-1, new Material(1, 1, 1), new AcousticWave(1, 1));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullExceptionMaterialCtor()
        {
            new RoundPEC(1, null, new AcousticWave(1, 1));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullExceptionAcousticWaveCtor()
        {
            new RoundPEC(1, new Material(1, 1, 1), null);
        }
    }
}
