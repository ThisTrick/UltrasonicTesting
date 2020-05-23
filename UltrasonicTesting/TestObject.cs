using System;

namespace UltrasonicTesting
{
    /// <summary>
    /// Объект Контроля(ОК).
    /// </summary>
    public class TestObject
    {
        /// <summary>
        /// Материал Объекта Контроля(ОК).
        /// </summary>
        public Material Material { get; private set; }
        /// <summary>
        /// Толщина Объекта Контроля(ОК).
        /// </summary>
        public double Thickness { get; private set; }
        public TestObject(Material material, double thickness)
        {
            Material = material ?? throw new ArgumentNullException(nameof(material));
            if (thickness <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(thickness), thickness, "Должен быть больше нуля.");
            }
            Thickness = thickness;
        }
    }
}
