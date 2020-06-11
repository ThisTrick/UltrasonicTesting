using System;

namespace UltrasonicTesting.Models
{
    /// <summary>
    /// Класс описывающий физические свойства материалов.
    /// </summary>
    public class Material
    {
        /// <summary>
        /// Имя материала.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Скорость распространения звука в материале. Размерность [м/с].
        /// </summary>
        public double SpeedOfSound { get; private set; }
        /// <summary>
        /// Плотность материала. Размерность [кг/м³].
        /// </summary>
        public double Density { get; private set; }
        /// <summary>
        /// Удельное акустическое сопротивление упругой среды. Размерность [Па*с/м].
        /// </summary>
        public double AcousticImpedance { get => SpeedOfSound * Density; }
        /// <summary>
        /// Пространственный коэффициент затухания. Размерность [Нп/м].
        /// </summary>
        public double FSPL { get; set; }
        public Material(string name, double speedOfSound, double density, double fspl)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("message", nameof(name));
            }
            if (speedOfSound <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(speedOfSound), speedOfSound, "Должен быть больше нуля.");
            }
            if (density <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(density), density, "Должен быть больше нуля.");
            }
            if (fspl <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(fspl), fspl, "Должен быть больше нуля.");
            }
            Name = name;
            SpeedOfSound = speedOfSound;
            Density = density;
            FSPL = fspl;
        }
    }
}
