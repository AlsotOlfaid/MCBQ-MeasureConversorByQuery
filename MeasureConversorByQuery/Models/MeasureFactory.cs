using MeasureConversorByQuery.ExtensionClasses;
using MeasureConversorByQuery.MeasureClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MeasureConversorByQuery.Enums.ConversorValues;

namespace MeasureConversorByQuery.Models
{
    internal class MeasureFactory
    {
        public static MeasureExtension Create<TEnum>() where TEnum : Enum
        {
           return typeof(TEnum) switch
           {
                Type t when t == typeof(Time) => new TimeMeasure(),
                Type t when t == typeof(Weight) => new WeightMeasure(),
                Type t when t == typeof(Volume) => new VolumeMeasure(),
                Type t when t == typeof(Area) => new AreaMeasure(),
                Type t when t == typeof(Lenght) => new LenghtMeasure(),
           };

            throw new ArgumentException($"No measure defined yet for {typeof(TEnum).Name}");
        }
    }
}
