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

            double fahrenheit = 41; // Exemplo de temperatura em graus Fahrenheit

            // Act
            double celsius = unitsConverter.FahrenheitToCelsius(fahrenheit);

            // Assert
            double expectedCelsius = 0.55; // O valor esperado em graus Celsius para 41°C

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
    }

}