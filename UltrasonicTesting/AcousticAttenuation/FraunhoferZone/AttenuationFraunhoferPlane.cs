using System;
using UltrasonicTesting.Models;

namespace UltrasonicTesting.Attenuation
{
    public sealed class AttenuationFraunhoferPlane : AcousticAttenuation, IAcousticAttenuationСalculate
    {
        public double Сalculate()
        {
            double wavelengthTO = Converter.AcousticWave.CalcWavelength(TestObject.Material);
            double exp = Math.Exp(-2 * TestObject.Thickness * TestObject.Material.FSPL);
            double acousticAttenuation = Converter.Area / (2 * wavelengthTO * TestObject.Thickness) * IntensityTransmittance * 1 * exp;
            return acousticAttenuation;
        }
        public AttenuationFraunhoferPlane(PiezoelectricityConverter converter, TestObject testObject) : base(converter, testObject){}
    }
}
