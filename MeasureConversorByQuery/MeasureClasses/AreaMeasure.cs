using MeasureConversorByQuery.Enums;
using MeasureConversorByQuery.Models;
using MeasureConversorByQuery.ExtensionClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MeasureConversorByQuery.Enums.ConversorValues;
using static MeasureConversorByQuery.Enums.MeasureTags;

namespace MeasureConversorByQuery.MeasureClasses
{
    public class AreaMeasure : MeasureExtension
    {
        //Constructor
        public override Measure GetMeasureByType(Enum measureType)
        {
            return AreaMeasures.Where(m => m.Unit.Equals(measureType)).Single();
        }

        //General static Data List
        public static List<Measure> AreaMeasures = new List<Measure>()
        {
            //Metric
            new Measure{ Unit = Area.SquareNanometers, Value = 1e-18, Prefix = "nm²", Tag = Tags.Metric},
            new Measure{ Unit = Area.SquareMicrometers, Value = 1e-12, Prefix = "µm²", Tag = Tags.Metric}, 
            new Measure{ Unit = Area.SquareMillimeters, Value = 1e-6, Prefix = "mm²", Tag = Tags.Metric},
            new Measure{ Unit = Area.SquareCentimeters, Value = 0.0001, Prefix = "cm²", Tag = Tags.Metric},
            new Measure{ Unit = Area.SquareDecimeters, Value = 0.01, Prefix = "dm²", Tag = Tags.Metric},
            new Measure{ Unit = Area.SquareMeters, Value = 1, Prefix = "m²", Tag = Tags.Metric},
            new Measure{ Unit = Area.Areas, Value = 0.01, Prefix = "a", Tag = Tags.Metric},
            new Measure{ Unit = Area.Hectares, Value = 1e4, Prefix = "Ha", Tag = Tags.Metric},
            new Measure{ Unit = Area.SquareKilometers, Value = 1e6, Prefix = "Km²", Tag = Tags.Metric},

            //Imperial
            new Measure{ Unit = Area.Townships, Value = 9.324e7, Prefix = "township", Tag = Tags.Imperial},
            new Measure{ Unit = Area.SquareMiles, Value = 2.59e6, Prefix = "mi²", Tag = Tags.Imperial},
            new Measure{ Unit = Area.Homesteads, Value = 647497.027584, Prefix = "homestead", Tag = Tags.Imperial},
            new Measure{ Unit = Area.Acres, Value = 4046.86, Prefix = "ac", Tag = Tags.Imperial},
            new Measure{ Unit = Area.Roods, Value = 1011.7141056, Prefix = "rood", Tag = Tags.Imperial},
            new Measure{ Unit = Area.Squares, Value = 9.290304, Prefix = "squares", Tag = Tags.Imperial},
            new Measure{ Unit = Area.SquareRods, Value = 25.2929, Prefix = "rd²", Tag = Tags.Imperial},
            new Measure{ Unit = Area.SquareYards, Value = 0.836127, Prefix = "yd²", Tag = Tags.Imperial},
            new Measure{ Unit = Area.SquareFoots, Value = 0.092903, Prefix = "ft²", Tag = Tags.Imperial},
            new Measure{ Unit = Area.SquareInches, Value = 0.00064516, Prefix = "in²", Tag = Tags.Imperial},
        };
    }
}
