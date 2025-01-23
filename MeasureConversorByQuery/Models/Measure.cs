using MeasureConversorByQuery.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasureConversorByQuery.Models
{
    public class Measure
    {
        public Enum Unit { get; set; }
        public double Value { get; set; }
        public string Prefix { get; set; }
        public MeasureTags.Tags Tag { get; set; }
    }
}
