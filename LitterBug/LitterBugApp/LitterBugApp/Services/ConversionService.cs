using LitterBugApp.Enums;
using LitterBugApp.Models;
using LitterBugApp.Services.Interfaces;

namespace LitterBugApp.Services
{
    public class ConversionService : IConversionService
    {
        public decimal ConvertUnits<T>(T fromUnit, decimal amount, T toUnit) where T : BaseUnitModel
        {
            if(fromUnit == null || toUnit == null || amount <= 0)
            {
                return 0;
            }

            if (fromUnit.UnitType != toUnit.UnitType)
            {
                return 0;
            }

            var unitType = fromUnit.UnitType;
            decimal result = 0;
            
            //Same unit type
            switch(unitType)
            {
                case UnitType.Energy:
                    //TODO
                    break;
                case UnitType.Generic:
                    //TODO
                    break;
                case UnitType.LengthDistance:
                    //TODO
                    break;
                case UnitType.Volume:
                    //TODO
                    break;
                case UnitType.WeightMass:
                    //TODO
                    break;
                default:
                    return 0;
            }

            return result;
        }
    }
}
