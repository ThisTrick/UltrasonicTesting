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
        public double ResponseTime { get; private set; }
        public double ResponseAmplitude { get; private set; }
        public double[] Chart { get; private set; }
        public bool IsFresnelZone { get; private set; }
        public AcousticAttenuation Attenuation { get; private set; }
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
            Attenuation = ChoiceAcousticAttenuation();
            ResponseAmplitude = ResponseAmplitudeCalc();

            var _responseTimeInt = (int)Math.Round(ResponseTime * 1000000);
            var samplesGraphics = _responseTimeInt + 1;
            Chart = new double[samplesGraphics];
            InitChart(ResponseAmplitude);
        }
        /// <summary>
        /// Выбор конкретного коэффициента затухания акустического тракта.
        /// </summary>
        /// <returns>Интерфейс для расчета коэффициента затухания акустического тракта.</returns>
        private AcousticAttenuation ChoiceAcousticAttenuation()
        {
            AcousticAttenuation acousticAttenuation;
            var thickness = TestObject.Thickness;
            var fresnelDistance = Converter.CalcFresnelDistance(TestObject.Material);
            var fraunhoferDistance = Converter.CalcFraunhoferDistance(TestObject.Material);
            if (thickness <= fresnelDistance)
            {
                acousticAttenuation = new AttenuationFresnelPlane(Converter, TestObject);
                IsFresnelZone = true;
            }
            else if (thickness >= fraunhoferDistance)
            {
                acousticAttenuation = new AttenuationFraunhoferPlane(Converter, TestObject);
                IsFresnelZone = false;
            }
            else
            {
                throw new ArithmeticException("Контроль в переходной зоне не возможен. Измените входные параметры.");
            }
            return acousticAttenuation;
        }
        private double ResponseAmplitudeCalc()
        {
            return Attenuation.Сalculate() * Converter.AcousticWave.Amplitude * 1;
        }
        private double ResponseTimeCalc()
        {
            return 2 * TestObject.Thickness / TestObject.Material.SpeedOfSound;
        }
        private void InitChart(double ResponseAmplitude)
        {
            Chart.Initialize();
            Chart[Chart.Length - 1] = ResponseAmplitude;
        }
    }
}
