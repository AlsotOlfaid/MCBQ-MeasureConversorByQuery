using MeasureConversorByQuery.Enums;
using MeasureConversorByQuery.MeasureClasses;
using MeasureConversorByQuery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MeasureConversorByQuery.ExtensionClasses
{
    public abstract class MeasureExtension
    {
        //Initializers
        public abstract List<Measure> GetAllMeasures();
        public abstract MeasureExtension GetMeasuresByType(Enum measureType);
        public abstract MeasureExtension GetMeasuresByTag(MeasureTags.Tags measureTag);

        //Middle use
        //public abstract MeasureExtension OrderBy<T>(Predicate<T> parameter);


        //Final Methods
        public abstract Measure First();
        public abstract Measure Last();
        public abstract Measure Single();
    }
}
