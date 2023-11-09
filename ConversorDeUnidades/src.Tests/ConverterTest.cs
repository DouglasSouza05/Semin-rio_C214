namespace UnitTest.Aplication{

    [TestClass]
    public class UnitsConverterTest
    {
        UnitsConverter unitsConverter;

        [TestInitialize]
        public void setup()
        {
            unitsConverter = new UnitsConverter();
        }

        [TestMethod]
        public void TestCelsiusToFahrenheitConversion()
        {
            double celsius = 25; // Exemplo de temperatura em graus Celsius

            // Act
            double fahrenheit = unitsConverter.CelsiusToFahrenheit(celsius);

            // Assert
            double expectedFahrenheit = 77; // O valor esperado em graus Fahrenheit para 25°C

            Assert.AreEqual(expectedFahrenheit, fahrenheit, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestFahrenheitToCelsiusConversion()
        {
            double fahrenheit = 104; // Exemplo de temperatura em graus Fahrenheit

            // Act
            double celsius = unitsConverter.FahrenheitToCelsius(fahrenheit);

            // Assert
            double expectedCelsius = 0; // O valor esperado em graus Fahrenheit para 104

            Assert.AreEqual(expectedCelsius, celsius, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestCelsiustToKelvinConversion()
        {
            double celsius = 26.85; // Exemplo de temperatura em graus Celsius

            // Act
            double kelvin = unitsConverter.CelsiusToKelvin(celsius);

            // Assert
            double expectedKelvin = 300; // O valor esperado em graus Celsius para 26.15°C

            Assert.AreEqual(expectedKelvin, kelvin, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestKelvintToCelsiusConversion()
        {
            double kelvin = 300.15; // Exemplo de temperatura em graus Kelvin

            // Act
            double celsius = unitsConverter.KelvinToCelsius(kelvin);

            // Assert
            double expectedCelsius = 27; // O valor esperado em graus Kelvin para 300.15°C

            Assert.AreEqual(expectedCelsius, celsius, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestMetersToFeetConversion()
        {
            double meters = 1000; // Exemplo de metros

            // Act
            double feet = unitsConverter.MetersToFeet(meters);

            // Assert
            double expectedFeet = 3281; // O valor esperado em metros em 1000 metros

            Assert.AreEqual(expectedFeet, feet, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }       

        [TestMethod]
        public void TestMetersToKilometerConversion()
        {
            double meters = 3000; // Exemplo de metros

            // Act
            double kilometer = unitsConverter.MetersToKilometers(meters);

            // Assert
            double expectedKilometer = 3; // O valor esperado em metros em 3000 metros

            Assert.AreEqual(expectedKilometer, kilometer, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }  

        [TestMethod]
        public void TestKilometersToMetersConversion()
        {
            double kilometers = 3; // Exemplo de metros

            // Act
            double meter = unitsConverter.KilometersToMeters(kilometers);

            // Assert
            double expectedMeter = 3000; // O valor esperado em metros em 3000 metros

            Assert.AreEqual(expectedMeter, meter, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestMetersToMilesConversion()
        {
            double meters = 1609; // Exemplo de metros

            // Act
            double miles = unitsConverter.MetersToMiles(meters);

            // Assert
            double expectedMiles = 1; // O valor esperado em metros em 3000 metros

            Assert.AreEqual(expectedMiles, miles, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        } 

        [TestMethod]
        public void TestKilometersToMilesConversion()
        {
            double kilometers = 1609; // Exemplo de kilômetros

            // Act
            double miles = unitsConverter.KilometersToMiles(kilometers);

            // Assert
            double expectedMiles = 1000; // O valor esperado em metros em 3000 metros

            Assert.AreEqual(expectedMiles, miles, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestMeterspersecondToKilometersPerHourConversion()
        {
            double meterspersecond = 1600; // Exemplo de kilômetros

            // Act
            double kilometersperhour = unitsConverter.MetersPerSecondToKilometersPerHour(meterspersecond);

            // Assert
            double expectedKilometersperhour = 5760; // O valor esperado em metros por seguno 1600

            Assert.AreEqual(expectedKilometersperhour, kilometersperhour, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestKilometersPerHourToMetersPerSecondConversion()
        {
            double kilometerspersecond = 3600; // Exemplo de kilômetros

            // Act
            double meterspersecond = unitsConverter.KilometersPerHourToMetersPerSecond(kilometerspersecond);

            // Assert
            double expectedMeterspersecond = 1000; // O valor esperado em metros por seguno 1600

            Assert.AreEqual(expectedMeterspersecond, meterspersecond, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        } 

        [TestMethod]
        public void TestGramsToKilogramsConversion()
        {
            double grams = 5000; // Exemplo de kilômetros

            // Act
            double kilograms = unitsConverter.GramsToKilograms(grams);

            // Assert
            double expectedKilograms = 5; // O valor esperado em metros por seguno 1600

            Assert.AreEqual(expectedKilograms, kilograms, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestKilogramsToGramsConversion()
        {
            double kilograms = 5; // Exemplo de kilômetros

            // Act
            double grams = unitsConverter.KilogramsToGrams(kilograms);

            // Assert
            double expectedgrams = 5000; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedgrams, grams, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestKilogramsToPoundsConversion()
        {
            double kilograms = 5000; // Exemplo de kilômetros

            // Act
            double pounds = unitsConverter.KilogramsToPounds(kilograms);

            // Assert
            double expectedpounds = 11025; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedpounds, pounds, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestSecondsToHoursConversion()
        {
            double seconds = 3600; // Exemplo de kilômetros

            // Act
            double hours = unitsConverter.SecondsToHours(seconds);

            // Assert
            double expectedhours = 1; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedhours, hours, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestHoursToSecondsConversion()
        {
            double hours = 100; // Exemplo de kilômetros

            // Act
            double seconds = unitsConverter.HoursToSeconds(hours);

            // Assert
            double expectedseconds = 360000; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedseconds, seconds, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestDaysToMonthsConversion()
        {
            double days = 900; // Exemplo de dias

            // Act
            double months = unitsConverter.DaysToMonths(days);

            // Assert
            double expectedmonths = 29.58871684; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedmonths, months, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestLitersToGallonsConversion()
        {
            double liters = 1890; // Exemplo de dias

            // Act
            double gallons = unitsConverter.LitersToGallons(liters);

            // Assert
            double expectedgallons = 499.339498; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedgallons, gallons, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestGallonsToLitersConversion()
        {
            double gallons = 1670; // Exemplo de galões

            // Act
            double liters = unitsConverter.GallonsToLiters(gallons);

            // Assert
            double expectedliters = 6320.95; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedliters, liters, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestPascalsToPSIConversion()
        {
            double pascals = 9870; // Exemplo de pascals

            // Act
            double psi = unitsConverter.PascalsToPSI(pascals);

            // Assert
            double expectedpsi = 1.431472081; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedpsi, psi, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestPSIToPascalsConversion()
        {
            double psi = 850; // Exemplo de pascals

            // Act
            double pascals = unitsConverter.PSIToPascals(psi);

            // Assert
            double expectedpascals = 5860750; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedpascals, pascals, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }
    }

}