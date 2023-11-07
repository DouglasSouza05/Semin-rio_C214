namespace Aplication{

    public class UnitsConverter
    {
        // Fórmula 1:
        public double CelsiusToFahrenheit(double celsius)
        {
            return ((celsius * 9) / 5) + 32;
        }

        // Fórmula 2:
        public double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * (5/9);
        }

        // Fórmula 3:
        public double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }
    
        // Fórmula 4:
        public double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        // Fórmula 5:
        public double MetersToFeet(double meters)
        {
            return meters * 3.281;
        }

        // Fórmula 6:
        public double MetersToKilometers(double meters)
        {
            return meters / 1000;
        }

        // Fórmula 7:
        public double KilometersToMeters(double kilometers)
        {
            return kilometers * 1000;
        }

        // Fórmula 8:
        public double MetersToMiles(double meters)
        {
            return meters / 1609;
        }

        // Fórmula 9:
        public double KilometersToMiles(double kilometers)
        {
            return kilometers / 1.609;
        }

        // Fórmula 10:
        public double MetersPerSecondToKilometersPerHour(double metersPerSecond)
        {
            return metersPerSecond * 3.6;
        }

        // Fórmula 11:
        public double KilometersPerHourToMetersPerSecond(double kilometersPerHour)
        {
            return kilometersPerHour / 3.6;
        }

        // Fórmula 12:
        public double GramsToKilograms(double grams)
        {
            return grams / 1000;
        }

        // Fórmula 13:
        public double KilogramsToGrams(double kilograms)
        {
            return kilograms * 1000;
        }

        // Fórmula 14:
        public double KilogramsToPounds(double kilograms)
        {
            return kilograms * 2.205;
        }

        // Fórmula 15:
        public double SecondsToHours(double seconds)
        {
            return seconds / 3600;
        }

        public double HoursToSeconds(double hours)
        {
            return hours * 3600;
        }

        public double DaysToMonths(double days)
        {
            // Conversão aproximada
            return days / 30.417;
        }

        public double LitersToGallons(double liters)
        {
            return liters / 3.785;
        }

        public double GallonsToLiters(double gallons)
        {
            return gallons * 3.785;
        }

        public double PascalsToPSI(double pascals)
        {
            return pascals / 6895;
        }
    }
}