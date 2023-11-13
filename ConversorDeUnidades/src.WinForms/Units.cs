using Core.Aplication;

namespace WinForms.Aplication {

    public class Units {

        UnitsConverter unitsConverter = new UnitsConverter();

        public double TempConvertUnits(string fromUnit, string toUnit, double value) {

            if (fromUnit == "Celsius" && toUnit == "Fahrenheit") {
                return unitsConverter.CelsiusToFahrenheit(value);
            } else if (fromUnit == "Fahrenheit" && toUnit == "Celsius") {
                return unitsConverter.FahrenheitToCelsius(value);
            } else if (fromUnit == "Celsius" && toUnit == "Kelvin") {
                return unitsConverter.CelsiusToKelvin(value);
            } else if (fromUnit == "Kelvin" && toUnit == "Celsius") {
                return unitsConverter.KelvinToCelsius(value);
            } else if (fromUnit == "Fahrenheit" && toUnit == "Kelvin") {
                return unitsConverter.FahrenheitToKelvin(value);
            } else if (fromUnit == "Kelvin" && toUnit == "Fahrenheit") {
                return unitsConverter.KelvinToFahrenheit(value);
            } else {
                return value;
            }
        }

        public double LengthConvertUnits(string fromUnit, string toUnit, double value) {

            if (fromUnit == "Meters" && toUnit == "Kilometers") {
                return unitsConverter.MetersToKilometers(value);
            } else if (fromUnit == "Kilometers" && toUnit == "Meters") {
                return unitsConverter.KilometersToMeters(value);
            } else if (fromUnit == "Meters" && toUnit == "Feet") {
                return unitsConverter.MetersToFeet(value);
            } else if (fromUnit == "Feet" && toUnit == "Meters") {
                return unitsConverter.FeetToMeters(value);
            } else if (fromUnit == "Kilometers" && toUnit == "Feet") {
                return unitsConverter.KilometersToFeet(value);
            } else if (fromUnit == "Kelvin" && toUnit == "Fahrenheit") {
                return unitsConverter.FeetToKilometers(value);
            } else {
                return value;
            }
        }

        // public double TimeConvertUnits(string fromUnit, string toUnit, double value) {

        //     if (fromUnit == "Celsius" && toUnit == "Fahrenheit") {
        //         return unitsConverter.CelsiusToFahrenheit(value);
        //     } else if (fromUnit == "Fahrenheit" && toUnit == "Celsius") {
        //         return unitsConverter.FahrenheitToCelsius(value);
        //     } else if (fromUnit == "Celsius" && toUnit == "Kelvin") {
        //         return unitsConverter.CelsiusToKelvin(value);
        //     } else if (fromUnit == "Kelvin" && toUnit == "Celsius") {
        //         return unitsConverter.KelvinToCelsius(value);
        //     } else if (fromUnit == "Fahrenheit" && toUnit == "Kelvin") {
        //         return unitsConverter.FahrenheitToKelvin(value);
        //     } else if (fromUnit == "Kelvin" && toUnit == "Fahrenheit") {
        //         return unitsConverter.KelvinToFahrenheit(value);
        //     } else {
        //         return value;
        //     }
        // }

        // public double MassConvertUnits(string fromUnit, string toUnit, double value) {

        //     if (fromUnit == "Celsius" && toUnit == "Fahrenheit") {
        //         return unitsConverter.CelsiusToFahrenheit(value);
        //     } else if (fromUnit == "Fahrenheit" && toUnit == "Celsius") {
        //         return unitsConverter.FahrenheitToCelsius(value);
        //     } else if (fromUnit == "Celsius" && toUnit == "Kelvin") {
        //         return unitsConverter.CelsiusToKelvin(value);
        //     } else if (fromUnit == "Kelvin" && toUnit == "Celsius") {
        //         return unitsConverter.KelvinToCelsius(value);
        //     } else if (fromUnit == "Fahrenheit" && toUnit == "Kelvin") {
        //         return unitsConverter.FahrenheitToKelvin(value);
        //     } else if (fromUnit == "Kelvin" && toUnit == "Fahrenheit") {
        //         return unitsConverter.KelvinToFahrenheit(value);
        //     } else {
        //         return value;
        //     }
        // }

    }
}