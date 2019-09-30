using System;

namespace csharp_core
{
    public class Parrot
    {
        readonly ParrotType _type;
        readonly int _numberOfCoconuts;
        readonly double _voltage;
        readonly bool _isNailed;

        public Parrot(ParrotType type, int numberOfCoconuts, double voltage, bool isNailed)
        {
            _type = type;
            _numberOfCoconuts = numberOfCoconuts;
            _voltage = voltage;
            _isNailed = isNailed; 
        }

        public double GetSpeed()
        {
            switch (_type)
            {
                case ParrotType.EUROPEAN:
                    return GetBaseSpeed();
                case ParrotType.AFRICAN:
                    return Math.Max(0, GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts);
                case ParrotType.NORWEGIAN_BLUE:
                    return (_isNailed) ? 0 : GetBaseSpeed(_voltage);
            }

            throw new Exception("Should be unreachable");
        }

        private double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
        }

        private double GetLoadFactor()
        {
            return 9.0;
        }

        private double GetBaseSpeed()
        {
            return 12.0;
        }
    }
}