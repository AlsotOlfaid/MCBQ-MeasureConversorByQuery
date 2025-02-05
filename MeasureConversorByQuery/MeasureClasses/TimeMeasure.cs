using MeasureConversorByQuery.Enums;
using MeasureConversorByQuery.Models;
using MeasureConversorByQuery.ExtensionClasses;
using static MeasureConversorByQuery.Enums.ConversorValues;
using static MeasureConversorByQuery.Enums.MeasureTags;
using static MeasureConversorByQuery.Enums.MeasureTypeEnums;

namespace MeasureConversorByQuery.MeasureClasses
{
    public class TimeMeasure : MeasureExtension
    {
        public List<Measure> _Result { get; set; }

        public override List<Measure> GetAllMeasures()
        {
            return TimeMeasures.ToList();
        }

        public override MeasureExtension GetMeasuresByType(Enum measureType)
        {
            _Result = TimeMeasures.Where(m => m.Unit.Equals(measureType)).ToList();

            return this;
        }

        public override MeasureExtension GetMeasuresByTag(MeasureTags.Tags measureTag)
        {
            _Result = TimeMeasures.Where(m => m.Tag.Equals(measureTag)).ToList();
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


        internal static List<Measure> TimeMeasures = new List<Measure>()
        {
            new Measure{ Unit = Time.PlankTimes, Value = 5.39e-44, Prefix = "tp", Tag = Tags.Physics},
            new Measure{ Unit = Time.Quectoseconds, Value = 1e-30, Prefix = "qs", Tag = Tags.Metric},
            new Measure{ Unit = Time.Rontoseconds, Value = 1e-28, Prefix = "rs", Tag = Tags.Metric},
            new Measure{ Unit = Time.Yoctoseconds, Value = 1e-24, Prefix = "ys", Tag = Tags.Metric},
            new Measure{ Unit = Time.Zeposeconds, Value = 1e-21, Prefix = "zs", Tag = Tags.Metric},
            new Measure{ Unit = Time.Attoseconds, Value = 1e-18, Prefix = "as", Tag = Tags.Metric},
            new Measure{ Unit = Time.Femtoseconds, Value = 1e-15, Prefix = "fs", Tag = Tags.Metric},
            new Measure{ Unit = Time.Svedbergs, Value = 1e-13, Prefix = "sv", Tag = Tags.Chemistry},
            new Measure{ Unit = Time.Picosencods, Value = 1e-12, Prefix = "ps", Tag = Tags.Metric},
            new Measure{ Unit = Time.Nanosecods, Value = 1e-9, Prefix = "ns", Tag = Tags.Metric},
            new Measure{ Unit = Time.Ticks, Value = 1e-7, Prefix = "tck", Tag = Tags.Metric},
            new Measure{ Unit = Time.Microseconds, Value = 1e-6, Prefix = "µs", Tag = Tags.Metric},
            new Measure{ Unit = Time.Miliseconds, Value = 1e-3, Prefix = "ms", Tag = Tags.Metric},
            new Measure{ Unit = Time.Seconds, Value = 1, Prefix = "s" , Tag = Tags.Metric},
            new Measure{ Unit = Time.Minutes, Value = 60, Prefix = "min", Tag = Tags.Metric},
            new Measure{ Unit = Time.Moments, Value = 90, Prefix = "m", Tag = Tags.Metric},
            new Measure{ Unit = Time.Hours, Value = 3600, Prefix = "h", Tag = Tags.Metric},
            new Measure{ Unit = Time.Days, Value = 86400, Prefix = "d", Tag = Tags.Metric},
            new Measure{ Unit = Time.Weeks, Value = 604800, Prefix = "w", Tag = Tags.Metric},
            new Measure{ Unit = Time.Months, Value = 2.628e6, Prefix = "Mo", Tag = Tags.Metric},
            new Measure{ Unit = Time.Years, Value = 3.154e7, Prefix = "Y", Tag = Tags.Metric},
            new Measure{ Unit = Time.Lustrums, Value = 90, Prefix = "m", Tag = Tags.Astronomical},
            new Measure{ Unit = Time.Mileniums, Value = 3.154e10, Prefix = "mil", Tag = Tags.Astronomical},
        };
    }
}
