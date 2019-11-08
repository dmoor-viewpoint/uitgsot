using LitterBugApp.Models;

namespace LitterBugApp.Services.Interfaces
{
    public interface IConversionService
    {
        decimal ConvertUnits<T>(T fromUnit, decimal amount, T toUnit) where T : BaseUnitModel;

    }
}
