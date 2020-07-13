using UltrasonicTesting.Models;

namespace UltrasonicTesting
{
    /// <summary>
    /// Пьезоэлектрический Преобразователь(ПЕП).
    /// </summary>
    public abstract class PiezoelectricityConverter
    {
        /// <summary>
        /// Высота Пьезоэлектрического Преобразователя(ПЕП). Размерность [м].
        /// </summary>
        public abstract double Thickness { get; }
        /// <summary>
        /// Площадь поверхности Пьезоэлектрического Преобразователя. Размерность [м²].
        /// </summary>
        public abstract double Area { get; }
        /// <summary>
        /// Материал ПЕП
        /// </summary>
        public Material Material { get; private set; }
        public AcousticWave AcousticWave { get; private set; }
        /// <summary>
        /// Конструктор для инициализации материала ПЕП.
        /// </summary>
        /// <param name="materialPEC">Материал ПЕП.</param>
        protected PiezoelectricityConverter(Material materialPEC, AcousticWave acousticWave)
        {
            Material = materialPEC ?? throw new System.ArgumentNullException(nameof(materialPEC));
            AcousticWave = acousticWave ?? throw new System.ArgumentNullException(nameof(acousticWave));
        }
        /// <summary>
        /// Расчет длинны Ближней зоны(зона Френеля). Размерность [м].
        /// </summary>
        public abstract double CalcFresnelDistance(Material testObjectMaterial);
        /// <summary>
        /// Расчет длинны Дальней зоны(зона Фраунгофера). Размерность [м].
        /// </summary>
        public abstract double CalcFraunhoferDistance(Material testObjectMaterial);
    }
}
