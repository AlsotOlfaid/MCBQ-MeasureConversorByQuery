using MeasureConversorByQuery.Models;
using MeasureConversorByQuery.ExtensionClasses;
using static MeasureConversorByQuery.Enums.ConversorValues;
using static MeasureConversorByQuery.Enums.MeasureTags;

namespace MeasureConversorByQuery.MeasureClasses
{
    internal class WeightMeasure : MeasureExtension
    {
        public override Measure GetMeasureByType(Enum measureType)
        {
            return WeightMeasures.Where(m => m.Unit.Equals(measureType)).Single();
        }

        public static List<Measure> WeightMeasures = new List<Measure>()
        {
            new Measure{ Unit = Weight.Yoctograms, Value = 1e-27, Prefix = "yg", Tag = Tags.MetricExtended},
            new Measure{ Unit = Weight.Zeptograms, Value = 1e-24, Prefix = "zg", Tag = Tags.MetricExtended},
            new Measure{ Unit = Weight.Attograms, Value = 1e-21, Prefix = "ag", Tag = Tags.MetricExtended},
            new Measure{ Unit = Weight.Femtograms, Value = 1e-18, Prefix = "fg", Tag = Tags.MetricExtended},
            new Measure{ Unit = Weight.Picograms, Value = 1e-15, Prefix = "pg", Tag = Tags.MetricExtended},
            new Measure{ Unit = Weight.Nanograms, Value = 1e-12, Prefix = "ng", Tag = Tags.Metric},
            new Measure{ Unit = Weight.Micrograms, Value = 1e-9, Prefix = "µg", Tag = Tags.Metric},
            new Measure{ Unit = Weight.Miligrams, Value = 1e-6, Prefix = "mg", Tag = Tags.Metric},
            new Measure{ Unit = Weight.Grains, Value = 6.47989e-5, Prefix = "grains", Tag = Tags.Imperial},
            new Measure{ Unit = Weight.Centigrams, Value = 1e-5, Prefix = "cg", Tag = Tags.Metric},
            new Measure{ Unit = Weight.Carats, Value = 0.0002, Prefix = "c", Tag = Tags.Metric},
            new Measure{ Unit = Weight.Decigrams, Value = 1e-4, Prefix = "dg", Tag = Tags.Metric},
            new Measure{ Unit = Weight.Grams, Value = 1e-3, Prefix = "g", Tag = Tags.Metric},
            new Measure{ Unit = Weight.Drams, Value = 0.00177185, Prefix = "dr", Tag = Tags.Imperial},
            new Measure{ Unit = Weight.ShortHundredweights, Value = 0.0220462, Prefix = "shw", Tag = Tags.Imperial},
            new Measure{ Unit = Weight.Hundredweights, Value = 0.0196841, Prefix = "hw", Tag = Tags.Imperial},
            new Measure{ Unit = Weight.Ounces, Value = 0.0283495, Prefix = "oz", Tag = Tags.Imperial},
            new Measure{ Unit = Weight.Pounds, Value = 0.453592, Prefix = "lb", Tag = Tags.Imperial},
            new Measure{ Unit = Weight.Decagrams, Value = 1e-2, Prefix = "dag", Tag = Tags.Metric},
            new Measure{ Unit = Weight.Hectograms, Value = 1e-1, Prefix = "hg", Tag = Tags.Metric},
            new Measure{ Unit = Weight.Stones, Value = 6.35, Prefix = "stones", Tag = Tags.Imperial},
            new Measure{ Unit = Weight.Kilograms, Value = 1, Prefix = "Kg", Tag = Tags.Metric},
            new Measure{ Unit = Weight.ShortTons, Value = 907.185, Prefix = "Yt", Tag = Tags.Imperial},
            new Measure{ Unit = Weight.Tons, Value = 1e3, Prefix = "T", Tag = Tags.Metric},
            new Measure{ Unit = Weight.LongTons, Value = 1016.05, Prefix = "Yt", Tag = Tags.Imperial},
            new Measure{ Unit = Weight.Gigatons, Value = 1e6, Prefix = "Gt", Tag = Tags.MetricExtended},
            new Measure{ Unit = Weight.Teratons, Value = 1e9, Prefix = "Tt", Tag = Tags.MetricExtended},
            new Measure{ Unit = Weight.Petatons, Value = 1e12, Prefix = "Pt", Tag = Tags.MetricExtended},
            new Measure{ Unit = Weight.Exatons, Value = 1e15, Prefix = "Et", Tag = Tags.MetricExtended},
            new Measure{ Unit = Weight.Zettatons, Value = 1e18, Prefix = "Zt", Tag = Tags.MetricExtended},
            new Measure{ Unit = Weight.Yottatons, Value = 1e21, Prefix = "Yt", Tag = Tags.MetricExtended},
            new Measure{ Unit = Weight.Ronnatons, Value = 1e27, Prefix = "Rt", Tag = Tags.MetricExtended},
            new Measure{ Unit = Weight.Quettatons, Value = 1e30, Prefix = "Qt", Tag = Tags.MetricExtended},
        };

        
    }
}
