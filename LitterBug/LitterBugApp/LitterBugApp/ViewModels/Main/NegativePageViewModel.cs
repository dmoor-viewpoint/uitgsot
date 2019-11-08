using LitterBugApp.Models;
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

        public NegativePageViewModel()
        {
            EnvironmentalEntities = new List<EnvironmentalEntity>
            {
                new EnvironmentalEntity
                {
                    Title = "Beef Consumption",
                    Type = "Cow",
                    TitleImage = new Xamarin.Forms.Image { Source = "cow.png"},
                    Category = string.Format("How often do you have {0}", "Beef"),
                    FactList = new List<EnvironmentalEntity>
                    {
                        new EnvironmentalEntity { Title = "Can power 52 homes for a year" },
                        new EnvironmentalEntity { Title = "Is the same as travelling 500 miles in a car" },
                        new EnvironmentalEntity { Title = "Undoes the effect of 27 Trees" }
                    }
                },
                new EnvironmentalEntity
                {
                    Title = "Beef",
                    Type = "Cow",
                    TitleImage = new Xamarin.Forms.Image { Source = "cow.png"},
                    Category = string.Format("How often do you have {0}", "Beef"),
                    FactList = new List<EnvironmentalEntity>
                    {
                        new EnvironmentalEntity { Title = "Can power 52 homes for a year" },
                        new EnvironmentalEntity { Title = "Is the same as travelling 500 miles in a car" },
                        new EnvironmentalEntity { Title = "Undoes the effect of 27 Trees" }
                    }
                },
                new EnvironmentalEntity
                {
                    Title = "Beef",
                    Type = "Cow",
                    TitleImage = new Xamarin.Forms.Image { Source = "cow.png"},
                    Category = string.Format("How often do you have {0}", "Beef"),
                    FactList = new List<EnvironmentalEntity>
                    {
                        new EnvironmentalEntity { Title = "Can power 52 homes for a year" },
                        new EnvironmentalEntity { Title = "Is the same as travelling 500 miles in a car" },
                        new EnvironmentalEntity { Title = "Undoes the effect of 27 Trees" }
                    }
                },
                new EnvironmentalEntity
                {
                    Title = "Beef",
                    Type = "Cow",
                    TitleImage = new Xamarin.Forms.Image { Source = "cow.png"},
                    Category = string.Format("How often do you have {0}", "Beef"),
                    FactList = new List<EnvironmentalEntity>
                    {
                        new EnvironmentalEntity { Title = "Can power 52 homes for a year" },
                        new EnvironmentalEntity { Title = "Is the same as travelling 500 miles in a car" },
                        new EnvironmentalEntity { Title = "Undoes the effect of 27 Trees" }
                    }
                }
            };
        }
    }
}
