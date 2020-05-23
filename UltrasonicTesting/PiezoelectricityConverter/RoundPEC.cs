using System;

namespace UltrasonicTesting
{
    public class RoundPEC : PiezoelectricityConverter
    {
        /// <summary>
        /// Радиус Пьезоэлектрического Преобразователя(ПЕП). Размерность [м]
        /// </summary>
        public double Radius { get; private set; }
        public override double Thickness { get => Material.SpeedOfSound/(2*AcousticWave.Frequency); }
        public override double Area { get => Math.PI*Radius*Radius;}
        private double fresnelDistance;
        public override double FresnelDistance { get => fresnelDistance; }
        public override double FraunhoferDistance { get => 3*fresnelDistance; }
        public RoundPEC(double radius, Material material, AcousticWave acousticWave) : base(material, acousticWave)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), radius, "Должен быть больше нуля.");
            }
            Radius = radius;
            fresnelDistance = Radius * Radius / AcousticWave.CalcWavelength(Material);
        }
    }
}
