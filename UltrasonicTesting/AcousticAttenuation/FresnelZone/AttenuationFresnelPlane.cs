using System;
using UltrasonicTesting.Models;

namespace UltrasonicTesting.Attenuation
{
    public sealed class AttenuationFresnelPlane : AcousticAttenuation
    {
        public override double Сalculate()
        {
            double exp = Math.Exp(-2 * TestObject.Thickness * TestObject.Material.FSPL);
            double acousticAttenuation = 0.8 * IntensityTransmittance * exp * 1;
            return acousticAttenuation;
        }
        public AttenuationFresnelPlane(PiezoelectricityConverter converter, TestObject testObject) : base(converter, testObject) { }
    }
}
