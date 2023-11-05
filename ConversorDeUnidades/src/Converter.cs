public class UnitsConverter
{
    public double CelsiusToFahrenheit(double celsius)
    {
        return ((celsius * 9) / 5) + 32;
    }

    public double MetersToKilometers(double meters)
    {
        return meters / 1000;
    }

    public double MetersPerSecondToKilometersPerHour(double metersPerSecond)
    {
        return metersPerSecond * 3.6;
    }

    public double GramsToKilograms(double grams)
    {
        return grams / 1000;
    }

    public double SecondsToHours(double seconds)
    {
        return seconds / 3600;
    }

    public double DaysToMonths(double days)
    {
        // Conversão aproximada
        return days / 30.417;
    }

    public double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    public double KilometersToMiles(double kilometers)
    {
        return kilometers * 0.621371;
    }

    public double KilometersPerHourToMetersPerSecond(double kilometersPerHour)
    {
        return kilometersPerHour / 3.6;
    }

    public double KilogramsToPounds(double kilograms)
    {
        return kilograms * 2.20462;
    }

    public double MetersToFeet(double meters)
    {
        return meters * 3.28084;
    }

    public double LitersToGallons(double liters)
    {
        return liters * 0.264172;
    }

    public double PascalsToPSI(double pascals)
    {
        return pascals * 0.00014503773773375;
    }
}