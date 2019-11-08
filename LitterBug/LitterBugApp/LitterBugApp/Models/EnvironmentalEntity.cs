using LitterBugApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LitterBugApp.Models
{
    public class EnvironmentalEntity : BaseUnitModel
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public Image TitleImage { get; set; }
        public decimal AssociatedCO2CostPerUnit { get; set; }
        public Categories Category { get; set; }
        public List<EnvironmentalEntity> FactList { get; set;}
    }
}
