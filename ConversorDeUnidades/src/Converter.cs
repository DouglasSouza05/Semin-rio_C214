namespace Core.Aplication{

    public class UnitsConverter
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            return ((celsius * 9) / 5.0) + 32;
        }

        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5/9.0;
        }

        public double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        public double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        public double FahrenheitToKelvin(double fahrenheit)
        {
            return ((fahrenheit - 32) * 5/9.0) + 273.15;
        }

        public double KelvinToFahrenheit(double kelvin)
        {
            return ((kelvin - 273.15) * 9/5.0) + 32;
        }

        // ################################################

        public double MetersToKilometers(double meters)
        {
            return meters / 1000;
        }

        public double KilometersToMeters(double kilometers)
        {
            return kilometers * 1000;
        }

        public double MetersToFeet(double meters)
        {
            return meters * 3.281;
        }

        public double FeetToMeters(double meters)
        {
            return meters / 3.281;
        }

        public double KilometersToFeet(double kilometers)
        {
            return kilometers * 3281;
        }

        public double FeetToKilometers(double Feet)
        {
            return Feet / 3281;
        }

        // ################################################

        public double SecondsToHours(double seconds)
        {
            return seconds / 3600;
        }

        public double HoursToSeconds(double hours)
        {
            return hours * 3600;
        }

        public double SecondsToDays(double seconds)
        {
            return seconds / 86400;
        }

        public double DaysToSeconds(double days)
        {
            return days * 86400;
        }

        public double HoursToDays(double hours)
        {
            return hours / 24;
        }

        public double DaysToHours(double days)
        {
            return days * 24;
        }

        // ################################################

        public double GramsToKilograms(double grams)
        {
            return grams / 1000;
        }

        public double KilogramsToGrams(double kilograms)
        {
            return kilograms * 1000;
        }

        public double GramsToPounds(double grams)
        {
            return grams / 453.6;
        }

        public double PoundsToGrams(double grams)
        {
            return grams * 453.6;
        }

        public double KilogramsToPounds(double kilograms)
        {
            return kilograms * 2.205;
        }

        public double PoundsToKilograms(double Pounds)
        {
            return Pounds / 2.205;
        }
    }
}