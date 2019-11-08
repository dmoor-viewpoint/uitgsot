using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LitterBugApp.Models
{
    public class EnvironmentalEntity
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public Image TitleImage { get; set; }
        public string Category { get; set; }
        public List<EnvironmentalEntity> FactList { get; set;}
    }
}
