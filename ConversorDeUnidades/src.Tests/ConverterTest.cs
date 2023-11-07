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
            double kilograms = unitsConverter.KilometersPerHourToMetersPerSecond(grams);

            // Assert
            double expectedKilograms = 1388.888888888889; // O valor esperado em metros por seguno 1600

            Assert.AreEqual(expectedKilograms, kilograms, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }
    }

}