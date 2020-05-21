using Microsoft.VisualStudio.TestTools.UnitTesting;
using UltrasonicTesting;

namespace UltrasonicTesting_Tests
{
    [TestClass]
    public class AcousticWaveTest
    {
        Material matetial;
        AcousticWave acousticWave;
        [TestInitialize]
        public void AcousticWaveTestInialize()
        {
            double speedOfSound = 340;
            double density = 1.2;
            double fspl = 1.1;
            matetial = new Material(speedOfSound, density, fspl);

            double amplitude = 15;
            double frequency = 4000;
            acousticWave = new AcousticWave(amplitude, frequency);

        }
        [TestMethod]
        public void CalcWavelengthTest()
        {
            // arrange
           
            // act
            double expected = 0.085;
            double delta = 0.00001; // погрешность 0.01%
            double actual = acousticWave.CalcWavelength(matetial);

            // assert
            Assert.AreEqual(expected, actual, delta);
        }
        [TestMethod]
        public void СhangeFrequencyTest()
        {
            //arrange
            double newFrequensy = 5000;

            //act
            double expected = newFrequensy;
            acousticWave.СhangeFrequency(newFrequensy);
            double actual = acousticWave.Frequency;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void СhangeAmplitudeTest()
        {
            //arrange
            double newAmplitude = 50;

            //act
            double expected = newAmplitude;
            acousticWave.ChangeAmplitude(newAmplitude);
            double actual = acousticWave.Amplitude;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
