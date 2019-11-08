using LitterBugApp.Enums;
using LitterBugApp.Models;
using LitterBugApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LitterBugApp.Services
{
    public class CalculationService : ICalculationService
    {
        public decimal CalculateCO2(EnvironmentalEntity entity, decimal amount)
        {
            if (entity != null && amount >= 0)
            {
                if (entity.Category == Categories.Food)
                {
                    return entity.AssociatedCO2CostPerUnit * amount;
                }
            }

            return 0;
        }
    }
}
