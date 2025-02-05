using MeasureConversorByQuery.Models;
using MeasureConversorByQuery.ExtensionClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MeasureConversorByQuery.Enums.ConversorValues;
using static MeasureConversorByQuery.Enums.MeasureTags;
using MeasureConversorByQuery.Enums;

namespace MeasureConversorByQuery.MeasureClasses
{
    //NOTE : The class is public just for the single use of the data
    public class LenghtMeasure : MeasureExtension
    {
        // Constructor
        public List<Measure> _Result { get; set; }

        public override List<Measure> GetAllMeasures()
        {
            return LenghtMeasures.ToList();
        }
        public override MeasureExtension GetMeasuresByType(Enum measureType)
        {
            _Result = LenghtMeasures.Where(m => m.Unit.Equals(measureType)).ToList();

            return this;
        }

        public override MeasureExtension GetMeasuresByTag(MeasureTags.Tags measureTag)
        {
            _Result = LenghtMeasures.Where(m => m.Tag.Equals(measureTag)).ToList();
            return this;
        }

        public override Measure First()
        {
            return _Result.First();
        }

        public override Measure Last()
        {
            return _Result.Last();
        }

        public override Measure Single()
        {
            return _Result.Single();
        }

        // Measure List :: This list is "Internal" to avoid unwanted changes
        internal static List<Measure> LenghtMeasures = new List<Measure>()
        {
            //Metric
            new Measure{ Unit = Lenght.Yoctometers, Value = 1e-27, Prefix = "ym", Tag = Tags.MetricExtended},
            new Measure{ Unit = Lenght.Zeptometers, Value = 1e-24, Prefix = "zm", Tag = Tags.MetricExtended},
            new Measure{ Unit = Lenght.Attometers, Value = 1e-21, Prefix = "am", Tag = Tags.MetricExtended},
            new Measure{ Unit = Lenght.Femtometers, Value = 1e-18, Prefix = "fm", Tag = Tags.MetricExtended},
            new Measure{ Unit = Lenght.Picometers, Value = 1e-15, Prefix = "pm", Tag = Tags.MetricExtended},
            new Measure{ Unit = Lenght.Angstroms, Value = 1e-13, Prefix = "pm", Tag = Tags.Metric},
            new Measure{ Unit = Lenght.Nanometers, Value = 1e-12, Prefix = "nm", Tag = Tags.Metric},
            new Measure{ Unit = Lenght.Micrometers, Value = 1e-9, Prefix = "µm", Tag = Tags.Metric},
            new Measure{ Unit = Lenght.Milimeters, Value = 1e-6, Prefix = "mm", Tag = Tags.Metric},
            new Measure{ Unit = Lenght.Centimeters, Value = 1e-5, Prefix = "cm", Tag = Tags.Metric},
            new Measure{ Unit = Lenght.Decimeters, Value = 1e-4, Prefix = "dm", Tag = Tags.Metric},
            new Measure{ Unit = Lenght.Meters, Value = 1e-3, Prefix = "m", Tag = Tags.Metric},
            new Measure{ Unit = Lenght.Decameters, Value = 1e2, Prefix = "Dm", Tag = Tags.Metric},
            new Measure{ Unit = Lenght.Hectometers, Value = 1e-1, Prefix = "Hm", Tag = Tags.Metric},
            new Measure{ Unit = Lenght.Kilometers, Value = 1, Prefix = "Km", Tag = Tags.Metric},
            new Measure{ Unit = Lenght.Megameters, Value = 1e3, Prefix = "Mm", Tag = Tags.MetricExtended},
            new Measure{ Unit = Lenght.Gigameters, Value = 1e6, Prefix = "Gm", Tag = Tags.MetricExtended},
            new Measure{ Unit = Lenght.Terameters, Value = 1e9, Prefix = "Tm", Tag = Tags.MetricExtended},
            new Measure{ Unit = Lenght.Petameters, Value = 1e12, Prefix = "Pm", Tag = Tags.MetricExtended},
            new Measure{ Unit = Lenght.Exameters, Value = 1e15, Prefix = "Em", Tag = Tags.MetricExtended},
            new Measure{ Unit = Lenght.Zettameters, Value = 1e18, Prefix = "Zm", Tag = Tags.MetricExtended},
            new Measure{ Unit = Lenght.Yottameters, Value = 1e21, Prefix = "Ym", Tag = Tags.MetricExtended},

            //Imperial : Separation for readability only
            new Measure{ Unit = Lenght.Hands, Value = 0.0001016, Prefix = "hand", Tag = Tags.Imperial },
            new Measure{ Unit = Lenght.Inches, Value = 2.54e-5, Prefix = "in", Tag = Tags.Imperial },
            new Measure{ Unit = Lenght.Lines, Value = 2.1167e-6, Prefix = "line", Tag = Tags.Imperial },
            new Measure{ Unit = Lenght.Thous, Value = 2.54e-8, Prefix = "thou", Tag = Tags.Imperial },
            new Measure{ Unit = Lenght.Links, Value = 0.000201168, Prefix = "li", Tag = Tags.Imperial},
            new Measure{ Unit = Lenght.Foots, Value = 0.0003048, Prefix = "ft", Tag = Tags.Imperial},
            new Measure{ Unit = Lenght.Yards, Value = 0.0009144, Prefix = "yd", Tag = Tags.Imperial},
            new Measure{ Unit = Lenght.Fathoms, Value = 0.0018288, Prefix = "fath", Tag = Tags.Imperial},
            new Measure{ Unit = Lenght.Rods, Value = 0.0050292, Prefix = "rd", Tag = Tags.Imperial},
            new Measure{ Unit = Lenght.Miles, Value = 1.60936, Prefix = "mi", Tag = Tags.Imperial},
            new Measure{ Unit = Lenght.Chains, Value = 0.0201168, Prefix = "ch", Tag = Tags.Imperial},
            new Measure{ Unit = Lenght.Furlongs, Value = 0.201168, Prefix = "fl", Tag = Tags.Imperial},
            new Measure{ Unit = Lenght.Miles, Value = 1.60936, Prefix = "mi", Tag = Tags.Imperial},
            new Measure{ Unit = Lenght.NauticalMiles, Value = 1.852, Prefix = "nmi", Tag = Tags.Imperial},
            new Measure{ Unit = Lenght.Leagues, Value = 5.556, Prefix = "lea", Tag = Tags.Imperial},

            //Astronomical
            new Measure{ Unit = Lenght.Parsecs, Value = 3.086e13, Prefix = "pc", Tag = Tags.Astronomical},
            new Measure{ Unit = Lenght.LightYears, Value = 9.461e12, Prefix = "light year", Tag = Tags.Astronomical},
            new Measure{ Unit = Lenght.AstronomicalUnits, Value = 6.6845871226706e-9, Prefix = "AE", Tag = Tags.Astronomical},
            new Measure{ Unit = Lenght.LightMinutes, Value = 1.799e7, Prefix = "light minute", Tag = Tags.Astronomical},
            new Measure{ Unit = Lenght.LightSeconds, Value = 299_792, Prefix = "light second", Tag = Tags.Astronomical},
        };
    }
}
