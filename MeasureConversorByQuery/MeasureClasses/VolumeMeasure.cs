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
    public class VolumeMeasure : MeasureExtension
    {
        public List<Measure> _Result { get; set; }

        public override List<Measure> GetAllMeasures()
        {
            return VolumeMeasures.ToList();
        }
        public override MeasureExtension GetMeasuresByType(Enum measureType)
        {
            _Result = VolumeMeasures.Where(m => m.Unit.Equals(measureType)).ToList();

            return this;
        }

        public override MeasureExtension GetMeasuresByTag(MeasureTags.Tags measureTag)
        {
            _Result = VolumeMeasures.Where(m => m.Tag.Equals(measureTag)).ToList();
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

        // Data List
        internal static List<Measure> VolumeMeasures = new List<Measure>()
        {
            new Measure{ Unit = Volume.Yoctoliters, Value = 1e-24, Prefix = "yL", Tag = Tags.MetricExtended},
            new Measure{ Unit = Volume.Zeptoliters, Value = 1e-21, Prefix = "zL", Tag = Tags.MetricExtended},
            new Measure{ Unit = Volume.Attoliters, Value = 1e-18, Prefix = "aL", Tag = Tags.MetricExtended},
            new Measure{ Unit = Volume.Femtoliters, Value = 1e-15, Prefix = "fL", Tag = Tags.MetricExtended},
            new Measure{ Unit = Volume.Picoliters, Value = 1e-12, Prefix = "pL", Tag = Tags.MetricExtended},
            new Measure{ Unit = Volume.Nanoliters, Value = 1e-9, Prefix = "nL", Tag = Tags.Metric},
            new Measure{ Unit = Volume.Microliters, Value = 1e-6, Prefix = "µL", Tag = Tags.Metric},
            new Measure{ Unit = Volume.Milliliters, Value = 1e-3, Prefix = "mL", Tag = Tags.Metric},
            new Measure{ Unit = Volume.Centiliters, Value = 1e-2, Prefix = "cL", Tag = Tags.Metric},
            new Measure{ Unit = Volume.Deciliters, Value = 1e-1, Prefix = "dL", Tag = Tags.Metric},
            new Measure{ Unit = Volume.Liters, Value = 1, Prefix = "L", Tag = Tags.Metric},
            new Measure{ Unit = Volume.Decaliters, Value = 1e1, Prefix = "daL", Tag = Tags.Metric},
            new Measure{ Unit = Volume.Hectoliters, Value = 1e2, Prefix = "hL", Tag = Tags.Metric},
            new Measure{ Unit = Volume.Kiloliters, Value = 1e3, Prefix = "KL", Tag = Tags.Metric},
            new Measure{ Unit = Volume.Megaliters, Value = 1e6, Prefix = "ML", Tag = Tags.MetricExtended},
            new Measure{ Unit = Volume.Gigaliters, Value = 1e9, Prefix = "GL", Tag = Tags.MetricExtended},
            new Measure{ Unit = Volume.Teraliters, Value = 1e12, Prefix = "TL", Tag = Tags.MetricExtended},
            new Measure{ Unit = Volume.Petaliters, Value = 1e15, Prefix = "Pl", Tag = Tags.MetricExtended},
            new Measure{ Unit = Volume.Exaliters, Value = 1e18, Prefix = "El", Tag = Tags.MetricExtended},
            new Measure{ Unit = Volume.Zettaliters, Value = 1e21, Prefix = "Zl", Tag = Tags.MetricExtended},
            new Measure{ Unit = Volume.Yoctoliters, Value = 1e24, Prefix = "Yl", Tag = Tags.MetricExtended},

            new Measure{ Unit = Volume.CubicKilometers, Value = 1e12, Prefix = "m", Tag = Tags.Metric},
            new Measure{ Unit = Volume.CubicMillimeters, Value = 1e6, Prefix = "mm", Tag = Tags.Metric},
            new Measure{ Unit = Volume.CubicMeters, Value = 1e3, Prefix = "m", Tag = Tags.Metric},
            new Measure{ Unit = Volume.CubicCentimeters, Value = 1e-3, Prefix = "m", Tag = Tags.Metric},
            new Measure{ Unit = Volume.CubicDecimeters, Value = 1, Prefix = "m", Tag = Tags.Metric},


        };


    }
}
