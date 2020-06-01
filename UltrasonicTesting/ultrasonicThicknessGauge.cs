using System;
using UltrasonicTesting.Attenuation;
using UltrasonicTesting.Models;

namespace UltrasonicTesting
{
    /// <summary>
    /// Ультразвуковой толщиномер.
    /// </summary>
    public class UltrasonicThicknessGauge
    {
        /// <summary>
        /// Пьезоэлектрический Преобразователь(ПЕП) толщиномера.
        /// </summary>
        public PiezoelectricityConverter Converter { get; private set; }
        /// <summary>
        /// Объект Контроля.
        /// </summary>
        public TestObject TestObject { get; private set; }
        /// <summary>
        /// Рассчитанная толщина Объекта Контроля.
        /// </summary>
        public double Result { get; private set; }
        public double ResponseTime { get; private set; }
        public double[] Chart { get; private set; }
        private int _responseTimeInt;
        public IAcousticAttenuationСalculate AttenuationСalculate { get; private set; }
        public UltrasonicThicknessGauge(PiezoelectricityConverter converter, TestObject testObject)
        {
            ChangeTestObject(testObject);
            Converter = converter ?? throw new ArgumentNullException(nameof(converter));
        }
        /// <summary>
        /// Изменение Объекта Контроля.
        /// </summary>
        /// <param name="newTestObject">Новый Объекта Контроля.</param>
        public void ChangeTestObject(TestObject newTestObject)
        {
            TestObject = newTestObject ?? throw new ArgumentNullException(nameof(newTestObject));
        }
        /// <summary>
        /// Запускает измерение толщины.
        /// </summary>
        public void StartTesting() 
        {
            ResponseTime = ResponseTimeCalc();
            _responseTimeInt = (int)Math.Round(ResponseTime * 1000000);
            var samplesGraphics = _responseTimeInt + 1;
            Chart = new double[samplesGraphics];
            AttenuationСalculate = ChoiceAcousticAttenuation();
            var responseAmplitude = ResponseAmplitude();
            InitChart(responseAmplitude);
            Result = ResponseTime / 2 * TestObject.Material.SpeedOfSound;
        }
        /// <summary>
        /// Выбор конкретного коэффициента затухания акустического тракта.
        /// </summary>
        /// <returns>Интерфейс для расчета коэффициента затухания акустического тракта.</returns>
        private IAcousticAttenuationСalculate ChoiceAcousticAttenuation()
        {
            IAcousticAttenuationСalculate acousticAttenuation;
            var thickness = TestObject.Thickness;
            var fresnelDistance = Converter.FresnelDistance;
            var fraunhoferDistance = Converter.FraunhoferDistance;
            if(thickness <= fresnelDistance)
            {
                acousticAttenuation = new AttenuationFresnelPlane(Converter, TestObject);
            }
            else if(thickness >= fraunhoferDistance)
            {
                acousticAttenuation = new AttenuationFraunhoferPlane(Converter, TestObject);
            }
            else
            {
                throw new ArithmeticException("Контроль в переходной зоне не возможен. Измените входные параметры.");
            }
            return acousticAttenuation;
        }
        private double ResponseAmplitude()
        {
            double result = AttenuationСalculate.Сalculate() * Converter.AcousticWave.Amplitude * 1;
            return result;
        }
        private double ResponseTimeCalc()
        {
            double result = 2 * TestObject.Thickness / TestObject.Material.SpeedOfSound;
            return result;
        }
        private void InitChart(double responseAmplitude)
        {
            for (int t = 0; t < Chart.Length; t++)
            {
                if(t != _responseTimeInt)
                {
                    Chart[t] = 0;
                }
                else if (t == _responseTimeInt)
                {
                    Chart[t] = responseAmplitude;
                }
                else
                {
                    throw new ApplicationException();
                }
            }
        }
    }
}
