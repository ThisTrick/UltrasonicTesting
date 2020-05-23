using System;

namespace UltrasonicTesting
{
    /// <summary>
    /// Коэффициент затухания акустического тракта.
    /// </summary>
    public abstract class AcousticAttenuation
    {
        /// <summary>
        /// Пьезоэлектрический Преобразователь(ПЕП).
        /// </summary>
        protected PiezoelectricityConverter Converter;
        /// <summary>
        ///  Объект Контроля(ОК).
        /// </summary>
        protected TestObject TestObject;
        /// <summary>
        /// Коэффициент прохождения ультразвукового луча по интенсивности.
        /// </summary>
        protected double IntensityTransmittance;
        protected AcousticAttenuation(PiezoelectricityConverter converter, TestObject testObject)
        {
            Converter = converter ?? throw new ArgumentNullException(nameof(converter));
            TestObject = testObject ?? throw new ArgumentNullException(nameof(testObject));
            IntensityTransmittance = IntensityTransmittanceCalc(converter.Material, testObject.Material);
        }
        /// <summary>
        /// Расчет коэффициента прохождения ультразвукового луча по интенсивности.
        /// </summary>
        /// <param name="materialPEC">Материал Пьезоэлектрического Преобразователя(ПЕП)</param>
        /// <param name="materialTO">Материал Объекта Контроля.</param>
        /// <returns></returns>
        private double IntensityTransmittanceCalc(Material materialPEC, Material materialTO)
        {
            if (materialPEC is null || materialTO is null)
            {
                throw new ArgumentNullException(nameof(materialPEC));
            }

            double sum = materialPEC.AcousticImpedance + materialTO.AcousticImpedance;
            double mult = materialPEC.AcousticImpedance * materialTO.AcousticImpedance;
            double intensityTransmittance = (4 * mult) / Math.Pow(sum, 2);
            return intensityTransmittance;
        }
    }
}
