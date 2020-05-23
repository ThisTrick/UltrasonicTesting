namespace UltrasonicTesting
{
    public class AcousticWave
    {
        /// <summary>
        /// Амплитуда волны. Размерность [В].
        /// </summary>
        public double Amplitude { get; private set; }
        /// <summary>
        /// Частота волны. Размерность [Гц].
        /// </summary>
        public double Frequency { get; private set; }
        public AcousticWave(double amplitude, double frequency)
        {
            Amplitude = amplitude;
            Frequency = frequency;
        }
        /// <summary>
        /// Рассчитывает длину волны для конкретного материала. 
        /// </summary>
        /// <param name="material">Материал в котором распространяется звук.</param>
        /// <returns>Длину волны. Размерность [м].</returns>
        public double CalcWavelength(Material material)
        {
            if (material is null)
            {
                throw new System.ArgumentNullException(nameof(material));
            }
            double wavelength = material.SpeedOfSound / Frequency;
            return wavelength;
        }
        /// <summary>
        /// Изменение частоты.
        /// </summary>
        /// <param name="newFrequency">Новая частота.</param>
        public void СhangeFrequency(double newFrequency)
        {
            Frequency = newFrequency;
        }
        /// <summary>
        /// Изменение амплитуды.
        /// </summary>
        /// <param name="newAmplitude">Новая амплитуда.</param>
        public void ChangeAmplitude(double newAmplitude)
        {
            Amplitude = newAmplitude;
        }
    }
}
