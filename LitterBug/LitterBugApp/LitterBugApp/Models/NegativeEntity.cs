using Realms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace LitterBugApp.Models
{
    public class NegativeEntity : RealmObject
    {
        public string Name { get; set; }
        public string Type { get; set; }
        [Ignored]
        public Image Image { get; set; }
        public long MeasurementMetric { get; set; }
        [Ignored]
        public Dictionary<int, string> KeyFacts { get; set; }
        [Ignored]
        public List<NegativeEntity> TestList { get; set; }
    }
}
