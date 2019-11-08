using LitterBugApp.Models;
using LitterBugApp.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LitterBugApp.ViewModels.Main
{
    public class NegativePageViewModel : BindableBase
    {
        public List<EnvironmentalEntity> EnvironmentalEntities { get; set; }
        private ICalculationService _calculationService { get; set; }
        public EnvironmentalEntity EnvironmentalEntity { get; set; }
        private decimal amountEntered;
        public decimal AmountEntered
        {
            get { return amountEntered; }
            set
            {
                if (amountEntered != value)
                {
                    amountEntered = value;
                    RaisePropertyChanged("AmountEntered");
                    AmountChanged();
                }
            }
        }
        private string kilosPerWeek;
        public string KilosPerWeek
        {
            get { return kilosPerWeek; }
            set
            {
                if (kilosPerWeek != value)
                {
                    kilosPerWeek = value;
                    RaisePropertyChanged("KilosPerWeek");
                }
            }
        }
        private string kilosPerYear;
        public string KilosPerYear
        {
            get { return kilosPerYear; }
            set
            {
                if (kilosPerYear != value)
                {
                    kilosPerYear = value;
                    RaisePropertyChanged("KilosPerYear");
                }
            }
        }
        private string kilosPerLife;
        public string KilosPerLife
        {
            get { return kilosPerLife; }
            set
            {
                if (kilosPerLife != value)
                {
                    kilosPerLife = value;
                    RaisePropertyChanged("KilosPerLife");
                }
            }
        }


        private void AmountChanged()
        {
            if (AmountEntered != 0)
            {
                KilosPerWeek = "0";
                    KilosPerYear = "0";
                KilosPerLife = "0";
            }
            var x = _calculationService.CalculateCO2(EnvironmentalEntity, AmountEntered);
            KilosPerWeek = x + "kg";
            var perYear = x * 52;
            KilosPerYear = perYear + "kg";
            var perLife = x * 4160;
            KilosPerLife = perLife + "kg";
        }

        public NegativePageViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
            KilosPerWeek = "0";
            KilosPerYear = "0";
            KilosPerLife = "0";
            EnvironmentalEntities = new List<EnvironmentalEntity>
            {
                new EnvironmentalEntity
                {
                    Title = "Beef Consumption",
                    Type = string.Format("How often do you have {0}", "Beef"),
                    TitleImage = new Xamarin.Forms.Image { Source = "cow.png"},
                    AssociatedCO2CostPerUnit = 27,
                    FactList = new List<EnvironmentalEntity>
                    {
                        new EnvironmentalEntity { Title = "Can power 52 homes for a year" },
                        new EnvironmentalEntity { Title = "Is the same as travelling 500 miles in a car" },
                        new EnvironmentalEntity { Title = "Undoes the effect of 27 Trees" }
                    }
                }
          
            };

            EnvironmentalEntity = EnvironmentalEntities.FirstOrDefault();
        }
    }
}
