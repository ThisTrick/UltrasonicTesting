using System;
using UltrasonicTesting.Models;

namespace UltrasonicTesting
{
    public class RoundPEC : PiezoelectricityConverter
    {
        /// <summary>
        /// Радиус Пьезоэлектрического Преобразователя(ПЕП). Размерность [м]
        /// </summary>
        public double Radius { get; private set; }
        public override double Thickness { get => Material.SpeedOfSound / (2 * AcousticWave.Frequency); }
        public override double Area { get => Math.PI * Radius * Radius; }
        public RoundPEC(double radius, Material material, AcousticWave acousticWave) : base(material, acousticWave)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), radius, "Должен быть больше нуля.");
            }
            Radius = radius;
        }
        public override double CalcFresnelDistance(Material testObjectMaterial)
        {
            var fresnelDistance = Radius * Radius / AcousticWave.CalcWavelength(testObjectMaterial);
            return fresnelDistance;
        }
        public override double CalcFraunhoferDistance(Material testObjectMaterial)
        {
            var fraunhoferDistance = 3 * CalcFresnelDistance(testObjectMaterial);
            return fraunhoferDistance;
        }
    }
}
