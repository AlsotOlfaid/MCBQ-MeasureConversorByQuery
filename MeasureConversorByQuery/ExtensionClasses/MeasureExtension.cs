using MeasureConversorByQuery.MeasureClasses;
using MeasureConversorByQuery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasureConversorByQuery.ExtensionClasses
{
    public abstract class MeasureExtension
    {
        public abstract Measure GetMeasureByType(Enum measureType);
    }
}
