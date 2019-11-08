using LitterBugApp.Enums;
using LitterBugApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LitterBugApp.Services.Interfaces
{
    public interface ICalculationService
    {
        decimal CalculateCO2(BaseUnitModel baseUnitModel, decimal amount);

    }
}
