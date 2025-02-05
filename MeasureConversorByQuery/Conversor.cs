using MeasureConversorByQuery.Enums;
using MeasureConversorByQuery.ExtensionClasses;
using MeasureConversorByQuery.MeasureClasses;
using MeasureConversorByQuery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MeasureConversorByQuery.Enums.ConversorValues;
using static MeasureConversorByQuery.MeasureClasses.TimeMeasure;

namespace MeasureConversorByQuery
{
    public class Conversor<TEnum> where TEnum : Enum
    {
        //Propertie to storage the selected measure from the factory
        private readonly MeasureExtension SelectedMeasure;
        
        //Contructor
        public Conversor()
        {
            SelectedMeasure = MeasureFactory.Create<TEnum>();
        }

        //Properties
        protected double _Value { get; set; }
        protected TEnum _FromMeasure { get; set; }
        protected double _Result { get; set; }
        protected string _Prefix { get; set; }
        protected string _Format { get; set; } = "G";


        //Chained Methods
        public Conversor<TEnum> Convert(double value)
        {
            _Value = value;
            return this;
        }

        public Conversor<TEnum> From(TEnum fromMeasure)
        {
            _FromMeasure = fromMeasure;
            return this;
        }

        public Conversor<TEnum> Format(string format)
        {
            _Format = format;
            return this;
        }

        public Conversor<TEnum> To(TEnum toMeasure)
        {
            Measure selectedFromMeasure = SelectedMeasure.GetMeasuresByType(_FromMeasure).Single();
            Measure selectedToMeasure = SelectedMeasure.GetMeasuresByType(toMeasure).Single();

            //Conversion to SqM
            double valueInSqM = _Value * selectedFromMeasure.Value;
            _Result = valueInSqM / selectedToMeasure.Value;
            _Prefix = selectedToMeasure.Prefix;

            return this;
        }


        //Return Methods
        public string AsString()
        {
            return _Result.ToString(_Format);
        }

        public string AsStringWithPrefix()
        {
            return _Result.ToString(_Format) + $" {_Prefix}";
        }

        public double AsDouble()
        {
            return _Result;
        }

        public int AsInt()
        {
            return (int)_Result;
        }
    }
}
