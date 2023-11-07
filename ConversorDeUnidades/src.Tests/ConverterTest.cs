namespace UnitTest.Aplication{

    [TestClass]
    public class UnitsConverterTest
    {

        // Teste 1:
        [TestMethod]
        public void TestCelsiusToFahrenheitConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double celsius = 25; // Exemplo de temperatura em graus Celsius

            // Act
            double fahrenheit = unitsConverter.CelsiusToFahrenheit(celsius);

            // Assert
            double expectedFahrenheit = 77; // O valor esperado em graus Fahrenheit para 25°C

            Assert.AreEqual(expectedFahrenheit, fahrenheit, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        
        // Teste 2:
        [TestMethod]
        public void TestFahrenheitToCelsiusConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double fahrenheit = 104; // Exemplo de temperatura em graus Fahrenheit

            // Act
            double celsius = unitsConverter.FahrenheitToCelsius(fahrenheit);

            // Assert
            double expectedCelsius = 0; // O valor esperado em graus Fahrenheit para 104

            Assert.AreEqual(expectedCelsius, celsius, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        // Teste 3:
        [TestMethod]
        public void TestCelsiustToKelvinConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double celsius = 26.85; // Exemplo de temperatura em graus Celsius

            // Act
            double kelvin = unitsConverter.CelsiusToKelvin(celsius);

            // Assert
            double expectedKelvin = 300; // O valor esperado em graus Celsius para 26.15°C

            Assert.AreEqual(expectedKelvin, kelvin, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        // Teste 4:
        [TestMethod]
        public void TestKelvintToCelsiusConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double kelvin = 300.15; // Exemplo de temperatura em graus Kelvin

            // Act
            double celsius = unitsConverter.KelvinToCelsius(kelvin);

            // Assert
            double expectedCelsius = 27; // O valor esperado em graus Kelvin para 300.15°C

            Assert.AreEqual(expectedCelsius, celsius, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        // Teste 5:
        [TestMethod]
        public void TestMetersToFeetConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double meters = 1000; // Exemplo de metros

            // Act
            double feet = unitsConverter.MetersToFeet(meters);

            // Assert
            double expectedFeet = 3281; // O valor esperado em metros em 1000 metros

            Assert.AreEqual(expectedFeet, feet, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }       

        // Teste 6:
        [TestMethod]
        public void TestMetersToKilometerConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double meters = 3000; // Exemplo de metros

            // Act
            double kilometer = unitsConverter.MetersToKilometers(meters);

            // Assert
            double expectedKilometer = 3; // O valor esperado em metros em 3000 metros

            Assert.AreEqual(expectedKilometer, kilometer, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }  

        // Teste 7:
        [TestMethod]
        public void TestKilometersToMetersConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double kilometers = 3; // Exemplo de metros

            // Act
            double meter = unitsConverter.KilometersToMeters(kilometers);

            // Assert
            double expectedMeter = 3000; // O valor esperado em metros em 3000 metros

            Assert.AreEqual(expectedMeter, meter, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        // Teste 8:
        [TestMethod]
        public void TestMetersToMilesConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double meters = 1609; // Exemplo de metros

            // Act
            double miles = unitsConverter.MetersToMiles(meters);

            // Assert
            double expectedMiles = 1; // O valor esperado em metros em 3000 metros

            Assert.AreEqual(expectedMiles, miles, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        } 

        // Teste 9:
        [TestMethod]
        public void TestKilometersToMilesConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double kilometers = 1609; // Exemplo de kilômetros

            // Act
            double miles = unitsConverter.KilometersToMiles(kilometers);

            // Assert
            double expectedMiles = 1000; // O valor esperado em metros em 3000 metros

            Assert.AreEqual(expectedMiles, miles, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        // Teste 10:
        [TestMethod]
        public void TestMeterspersecondToKilometersPerHourConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double meterspersecond = 1600; // Exemplo de kilômetros

            // Act
            double kilometersperhour = unitsConverter.MetersPerSecondToKilometersPerHour(meterspersecond);

            // Assert
            double expectedKilometersperhour = 5760; // O valor esperado em metros por seguno 1600

            Assert.AreEqual(expectedKilometersperhour, kilometersperhour, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        // Teste 11:
        [TestMethod]
        public void TestKilometersPerHourToMetersPerSecondConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double kilometerspersecond = 3600; // Exemplo de kilômetros

            // Act
            double meterspersecond = unitsConverter.KilometersPerHourToMetersPerSecond(kilometerspersecond);

            // Assert
            double expectedMeterspersecond = 1000; // O valor esperado em metros por seguno 1600

            Assert.AreEqual(expectedMeterspersecond, meterspersecond, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        } 

        // Teste 12:
        [TestMethod]
        public void TestGramsToKilogramsConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double grams = 5000; // Exemplo de kilômetros

            // Act
            double kilograms = unitsConverter.GramsToKilograms(grams);

            // Assert
            double expectedKilograms = 5; // O valor esperado em metros por seguno 1600

            Assert.AreEqual(expectedKilograms, kilograms, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        // Teste 13:
        [TestMethod]
        public void TestKilogramsToGramsConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double kilograms = 5; // Exemplo de kilômetros

            // Act
            double grams = unitsConverter.KilogramsToGrams(kilograms);

            // Assert
            double expectedgrams = 5000; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedgrams, grams, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        // Teste 14:
        [TestMethod]
        public void TestKilogramsToPoundsConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double kilograms = 5000; // Exemplo de kilômetros

            // Act
            double pounds = unitsConverter.KilogramsToPounds(kilograms);

            // Assert
            double expectedpounds = 11025; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedpounds, pounds, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        // Teste 15:
        [TestMethod]
        public void TestSecondsToHoursConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double seconds = 3600; // Exemplo de kilômetros

            // Act
            double hours = unitsConverter.SecondsToHours(seconds);

            // Assert
            double expectedhours = 1; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedhours, hours, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        // Teste 16:
        [TestMethod]
        public void TestHoursToSecondsConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double hours = 100; // Exemplo de kilômetros

            // Act
            double seconds = unitsConverter.HoursToSeconds(hours);

            // Assert
            double expectedseconds = 360000; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedseconds, seconds, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        // Teste 17:
        [TestMethod]
        public void TestDaysToMonthsConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double days = 900; // Exemplo de dias

            // Act
            double months = unitsConverter.DaysToMonths(days);

            // Assert
            double expectedmonths = 29.58871684; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedmonths, months, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        // Teste 18:
        [TestMethod]
        public void TestLitersToGallonsConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double liters = 1890; // Exemplo de dias

            // Act
            double gallons = unitsConverter.LitersToGallons(liters);

            // Assert
            double expectedgallons = 499.339498; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedgallons, gallons, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        // Teste 19:
        [TestMethod]
        public void TestGallonsToLitersConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double gallons = 1670; // Exemplo de galões

            // Act
            double liters = unitsConverter.GallonsToLiters(gallons);

            // Assert
            double expectedliters = 6320.95; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedliters, liters, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        // Teste 20:
        [TestMethod]
        public void TestPascalsToPSIConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double pascals = 9870; // Exemplo de pascals

            // Act
            double psi = unitsConverter.PascalsToPSI(pascals);

            // Assert
            double expectedpsi = 1.431472081; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedpsi, psi, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        // Teste 21:
        [TestMethod]
        public void TestPSIToPascalsConversion()
        {

            UnitsConverter unitsConverter = new UnitsConverter();

            double psi = 850; // Exemplo de pascals

            // Act
            double pascals = unitsConverter.PSIToPascals(psi);

            // Assert
            double expectedpascals = 5860750; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedpascals, pascals, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }
    }

}