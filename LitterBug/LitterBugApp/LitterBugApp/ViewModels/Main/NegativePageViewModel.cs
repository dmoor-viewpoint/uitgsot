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
        public List<NegativeEntity> NegativeEntities { get; set; }

        public NegativePageViewModel()
        {
            NegativeEntities = new List<NegativeEntity>
            {
                new NegativeEntity
                {
                    Name = "Beef",
                    Type = "Cow",
                    MeasurementMetric = 4,
                    Image = new Xamarin.Forms.Image { Source = "cow.png"},
                    TestList = new List<NegativeEntity>
                    {
                     new NegativeEntity
                     {
                         Name = "Test 1s"
                     },
                     new NegativeEntity
                     {
                         Name = "Test 2s"
                     },
                     new NegativeEntity
                     {
                         Name = "Test 3s"
                     }
                    }
                },
                new NegativeEntity
                {
                    Name = "Beef",
                    Type = "Cow",
                    MeasurementMetric = 4,
                    Image = new Xamarin.Forms.Image { Source = "cow.png"},
                                        TestList = new List<NegativeEntity>
                    {
                     new NegativeEntity
                     {
                         Name = "Test 1s"
                     },
                     new NegativeEntity
                     {
                         Name = "Test 2s"
                     },
                     new NegativeEntity
                     {
                         Name = "Test 3s"
                     }
                    }
                },
                new NegativeEntity
                {
                    Name = "Beef",
                    Type = "Cow",
                    MeasurementMetric = 4,
                    Image = new Xamarin.Forms.Image { Source = "cow.png"},
                                        TestList = new List<NegativeEntity>
                    {
                     new NegativeEntity
                     {
                         Name = "Test 1s"
                     },
                     new NegativeEntity
                     {
                         Name = "Test 2s"
                     },
                     new NegativeEntity
                     {
                         Name = "Test 3s"
                     }
                    }
                },
                new NegativeEntity
                {
                    Name = "Beef",
                    Type = "Cow",
                    MeasurementMetric = 4,
                    Image = new Xamarin.Forms.Image { Source = "cow.png"},
                                        TestList = new List<NegativeEntity>
                    {
                     new NegativeEntity
                     {
                         Name = "Test 1s"
                     },
                     new NegativeEntity
                     {
                         Name = "Test 2s"
                     },
                     new NegativeEntity
                     {
                         Name = "Test 3s"
                     }
                    }
                }
            };
        }
    }
}
