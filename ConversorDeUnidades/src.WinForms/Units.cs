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
            } else if (fromUnit == "Feet" && toUnit == "Kilometers") {
                return unitsConverter.FeetToKilometers(value);
            } else {
                return value;
            }
        }

        public double TimeConvertUnits(string fromUnit, string toUnit, double value) {

            if (fromUnit == "Seconds" && toUnit == "Hours") {
                return unitsConverter.SecondsToHours(value);
            } else if (fromUnit == "Hours" && toUnit == "Seconds") {
                return unitsConverter.HoursToSeconds(value);
            } else if (fromUnit == "Seconds" && toUnit == "Days") {
                return unitsConverter.SecondsToDays(value);
            } else if (fromUnit == "Days" && toUnit == "Seconds") {
                return unitsConverter.DaysToSeconds(value);
            } else if (fromUnit == "Hours" && toUnit == "Days") {
                return unitsConverter.HoursToDays(value);
            } else if (fromUnit == "Days" && toUnit == "Hours") {
                return unitsConverter.DaysToHours(value);
            } else {
                return value;
            }
        }

        public double MassConvertUnits(string fromUnit, string toUnit, double value) {

            if (fromUnit == "Grams" && toUnit == "Kilograms") {
                return unitsConverter.GramsToKilograms(value);
            } else if (fromUnit == "Kilograms" && toUnit == "Grams") {
                return unitsConverter.KilogramsToGrams(value);
            } else if (fromUnit == "Grams" && toUnit == "Pounds") {
                return unitsConverter.GramsToPounds(value);
            } else if (fromUnit == "Pounds" && toUnit == "Grams") {
                return unitsConverter.PoundsToGrams(value);
            } else if (fromUnit == "Kilograms" && toUnit == "Pounds") {
                return unitsConverter.KilogramsToPounds(value);
            } else if (fromUnit == "Pounds" && toUnit == "Kilograms") {
                return unitsConverter.PoundsToKilograms(value);
            } else {
                return value;
            }
        }
    }
}