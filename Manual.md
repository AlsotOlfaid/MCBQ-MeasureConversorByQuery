# MCBQ - Manual
## Conversor Usage
### Create Conversor
To create a conversor you just need to create a Conversor instance just like another class, with the diference that the conversor is going to need a generic Enum value. 
You can get this value from the class Enum.ConversorValues, where you can find enums like Time, Lenght, Weight, and others. This generic values are gonna declarate the typoe of conversor you are going to use.
(If you put the generic "Time", the conversor is going to convert time units as seconds, minutes, etc).

```C#
using MeasureConversorByQuery;
using static MeasureConversorByQuery.Enums.ConversorValues;

Conversor<Lenght> conversor = new Conversor<Lenght>();
```

### Make a conversion
Using your instance, you can now convert through all the values from the specified generic Enum, using the methods `Convert()`, `From()`, `To()`, and a return method as `AsString()`.

```C#
conversor.Convert(2).From(Lenght.Meters).To(Lenght.Inches).AsString();

//Result : 78.74015748031496
```

- Convert(double value) : accepts the value to convert
- From(TEnum fromMeasure) : asigns a initial measure unit to the value
- To(TEnum toMeasure) : asings the final measure unit

### Return Methods
- AsString() : Returns the values as a string
- AsStringWithPrefix() : Return the value as string with the prefix of the measure at the end
- AsDouble() : Returns the value as a double
- AsInt() : Round and return the value as an integer

### Format the result as string :: THIS CAN CHANGE IN THE FUTURE
The returned value of the AsString() methods, are in a `'G'` format, wich means that the result is going to be as large as the result is, but if you want to change that,
you can do it using the method `Format()` and put as a parameter the format you want to use.

```C#
conversor.Convert(2).From(Lenght.Meters).To(Lenght.Inches).Format("N4").AsStringWithPrefix();

//Result : 78.7402 in
```
