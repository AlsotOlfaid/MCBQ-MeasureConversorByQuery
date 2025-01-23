using MeasureConversorByQuery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeasureConversorByQuery.Enums
{
    public class ConversorValues
    {
        public enum Weight
        {
            Yoctograms,
            Zeptograms,
            Attograms,
            Femtograms,
            Picograms,
            Nanograms,
            Micrograms,
            Miligrams,
            Grains,
            Centigrams,
            Carats,
            Decigrams,
            Grams,
            Drams,
            Hundredweights,
            ShortHundredweights,
            Ounces,
            Pounds,
            Decagrams,
            Hectograms,
            Stones,
            Kilograms, //Middle point
            ShortTons,
            Tons,
            LongTons,
            Gigatons,
            Teratons,
            Petatons,
            Exatons,
            Zettatons,
            Yottatons,
            Ronnatons,
            Quettatons,
        }

        public enum Lenght
        {
            //Metric
            Yoctometers,
            Zeptometers,
            Attometers,
            Femtometers,
            Picometers,
            Angstroms,
            Nanometers,
            Micrometers,
            Milimeters,
            Centimeters,
            Decimeters,
            Meters,  
            Decameters,
            Hectometers,
            Kilometers, // Middle
            Megameters,
            Gigameters,
            Terameters,
            Petameters,
            Exameters,
            Zettameters,
            Yottameters,

            //Imperial
            Thous,
            Lines,
            Inches,
            Hands,
            Links,
            Foots,
            Yards,
            Rods,
            Fathoms,
            Chains,
            Furlongs,
            Miles,
            NauticalMiles,
            Leagues,

            //Astronomical
            Parsecs,
            LightYears,
            AstronomicalUnits,
            LightMinutes,
            LightSeconds,
        }

        public enum Time
        {
            //Metric
            PlankTimes,
            Quectoseconds,
            Rontoseconds,
            Yoctoseconds,
            Zeposeconds,
            Attoseconds,
            Femtoseconds,
            Svedbergs,
            Picosencods,
            Nanosecods,
            Ticks,
            Microseconds,
            Miliseconds,
            Seconds, // Middle point
            Minutes,
            Moments,
            Hours,
            Days,
            Weeks,
            Months,
            Years,
            Lustrums,
            Mileniums,

        }

        public enum Volume
        {
            //Metric
            Yoctoliters,
            Zeptoliters,
            Attoliters,
            Femtoliters,
            Picoliters,
            Nanoliters,
            Microliters,
            Milliliters,
            Centiliters,
            Deciliters,
            Liters,    //Middle point
            Decaliters,
            Hectoliters,
            Kiloliters,
            Megaliters,
            Gigaliters,
            Teraliters,
            Petaliters,
            Exaliters,
            Zettaliters,
            Yottaliters,

            //People are more used to this expressions, but they're the same as the others (Ex: kiloliters == CubitMeters)
            CubicDecimeters,
            CubicCentimeters,
            CubicMeters,
            CubicMillimeters,
            CubicKilometers,

            //Imperial
            Barrels,
            Bushels,
            Pecks,
            Gallons,
            Quarts,
            Pints,
            FluidOunces,
        }

        public enum Area
        {
            //Metric
            SquareDecimeters,
            SquareCentimeters,
            SquareMillimeters,
            SquareMicrometers,
            SquareNanometers,
            SquareMeters,       //Middle point
            Areas,
            Hectares,
            SquareKilometers,

            //Imperial
            Townships,
            SquareMiles,
            Homesteads,
            Acres,
            Roods,
            SquareRods,
            Squares,
            SquareYards,
            SquareFoots,
            SquareInches,
        }
        
    }
}
