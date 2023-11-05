public class UnitsConverter
{
    public double CelsiusToFahrenheit(double celsius)
    {
        return ((celsius * 9) / 5) + 32;
    }

    public double MetersToFeet(double meters)
    {
        return meters * 3.281;
    }

    public double MetersToKilometers(double meters)
    {
        return meters / 1000;
    }

    public double KilometersToMiles(double kilometers)
    {
        return kilometers / 1.609;
    }

    public double MetersPerSecondToKilometersPerHour(double metersPerSecond)
    {
        return metersPerSecond * 3.6;
    }

    public double KilometersPerHourToMetersPerSecond(double kilometersPerHour)
    {
        return kilometersPerHour / 3.6;
    }

    public double GramsToKilograms(double grams)
    {
        return grams / 1000;
    }

    public double KilogramsToPounds(double kilograms)
    {
        return kilograms * 2.205;
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

    public double LitersToGallons(double liters)
    {
        return liters / 3.785;
    }

    public double PascalsToPSI(double pascals)
    {
        return pascals / 6895;
    }
}