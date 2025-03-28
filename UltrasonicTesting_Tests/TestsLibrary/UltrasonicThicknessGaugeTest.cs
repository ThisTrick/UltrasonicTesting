﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UltrasonicTesting;
using UltrasonicTesting.Models;

namespace UltrasonicTesting_Tests
{
    [TestClass]
    public class UltrasonicThicknessGaugeTest
    {
        public UltrasonicThicknessGauge thicknessGauge;
        [TestInitialize]
        public void UltrasonicThicknessGaugeTestInialize()
        {
            // arrange
            double speedOfSound = 340;
            double density = 1.2;
            double fspl = 1.1;
            Material materialPEC = new Material(string.Empty, speedOfSound, density, fspl);

            double amplitude = 15;
            double frequency = 4000;
            AcousticWave acousticWave = new AcousticWave(amplitude, frequency);

            double radius = 0.02;
            RoundPEC roundPEC = new RoundPEC(radius, materialPEC, acousticWave);

            double speedOfSound2 = 3000;
            double density2 = 1.2;
            double fspl2 = 1.1;
            Material materialTO = new Material(string.Empty, speedOfSound2, density2, fspl2);

            TestObject testObject = new TestObject(materialTO, 0.2);

            thicknessGauge = new UltrasonicThicknessGauge(roundPEC, testObject);
            thicknessGauge.StartTesting();
        }
        [TestMethod]
        public void ChangeTestObjectTest()
        {
            // arrange
            double speedOfSound2 = 3000;
            double density2 = 1.2;
            double fspl2 = 1.1;
            Material materialTO = new Material(string.Empty, speedOfSound2, density2, fspl2);

            TestObject newTestObject = new TestObject(materialTO, 0.2);
            // act
            thicknessGauge.ChangeTestObject(newTestObject);
            // assert
            Assert.AreEqual<TestObject>(newTestObject, thicknessGauge.TestObject);
        }
        [TestMethod]
        public void ResponseTimeTest()
        {
            // act
            double expected = 0.0001333;
            double delta = 0.000001; // погрешность 0.001%
            double actual = thicknessGauge.ResponseTime;
            // assert
            Assert.AreEqual(expected, actual, delta);
        }
        [TestMethod]
        public void ChartLengthTest()
        {
            // act
            double[] expectedChart = new double[134];
            expectedChart.Initialize();
            int expected = expectedChart.Length;
            double[] actualChart = thicknessGauge.Chart;
            int actual = actualChart.Length;
            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Chart133ValueTest()
        {
            // act
            double[] expectedChart = new double[134];
            expectedChart.Initialize();
            expectedChart[133] = 0.01479;
            double delta = 0.00001; // погрешность 0.01%
            double[] actualChart = thicknessGauge.Chart;
            // assert
            Assert.AreEqual(expectedChart[133], actualChart[133], delta);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullExceptionPiezoelectricityConverterCtor()
        {
            new UltrasonicThicknessGauge(null, new TestObject(new Material(string.Empty, 1, 2, 1), 1));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullExceptionTestObjectCtor()
        {
            new UltrasonicThicknessGauge(new RoundPEC(1, new Material(string.Empty, 1, 1, 1), new AcousticWave(1, 1)), null);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ArgumentNullExceptionTestObjectChangeTestObject()
        {
            thicknessGauge.ChangeTestObject(null);
        }
    }
}
