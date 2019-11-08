using LitterBugApp.Enums;

namespace LitterBugApp.Models
{
    public abstract class BaseUnitModel
    {
        public readonly string UnitName;
        public readonly UnitType UnitType;
        public decimal UnitAmount { get; set; }
    }
}
