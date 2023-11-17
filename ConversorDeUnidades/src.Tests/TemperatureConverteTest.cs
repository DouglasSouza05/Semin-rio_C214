namespace UnitTest.Aplication{
    
    [TestClass]
    [TestCategory("temperature")]
    public class TemperatureConverterTest
    {
        UnitsConverter temperatureConverter;
        
        public TemperatureConverterTest()
        {
            temperatureConverter = new UnitsConverter();
        }
        
        [TestMethod]
        [DataRow(40,104)]
        [DataRow(0,32)]
        [DataRow(25,77)]
        public void TestCelsiusToFahrenheitConversion(double celsius, double expectedFahrenheit)
        {
            // Act
            double fahrenheit = temperatureConverter.CelsiusToFahrenheit(celsius);

            Assert.AreEqual(expectedFahrenheit, fahrenheit, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        [DataRow(0,104)]
        [DataRow(32,32)]
        [DataRow(25,40)]
        public void TestCelsiusToFahrenheitConversionNotEqual(double celsius, double expectedFahrenheit)
        {
            // Act
            double fahrenheit = temperatureConverter.CelsiusToFahrenheit(celsius);

            Assert.AreNotEqual(expectedFahrenheit, fahrenheit, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DataRow(104,40)]
        [DataRow(32,0)]
        [DataRow(77,25)]
        public void TestFahrenheitToCelsiusConversion(double fahrenheit, double expectedCelsius)
        {
            // Act
            double celsius = temperatureConverter.FahrenheitToCelsius(fahrenheit);

            Assert.AreEqual(expectedCelsius, celsius, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DataRow(0,273.15)]
        [DataRow(20,293.15)]
        [DataRow(-30,243.15)]
        public void TestCelsiustToKelvinConversion(double celsius, double expectedKelvin)
        {
            // Act
            double kelvin = temperatureConverter.CelsiusToKelvin(celsius);

            Assert.AreEqual(expectedKelvin, kelvin, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DataRow(273.15,0)]
        [DataRow(303.15,30)]
        [DataRow(20,-253.15)]
        public void TestKelvintToCelsiusConversion(double kelvin, double expectedCelsius)
        {
            // Act
            double celsius = temperatureConverter.KelvinToCelsius(kelvin);

            Assert.AreEqual(expectedCelsius, celsius, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DataRow(273.15,33)]
        [DataRow(303.15,65)]
        [DataRow(0,-253.15)]
        public void TestKelvintToCelsiusConversionNotEqual(double kelvin, double expectedCelsius)
        {
            // Act
            double celsius = temperatureConverter.KelvinToCelsius(kelvin);

            Assert.AreNotEqual(expectedCelsius, celsius, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DataRow(104,313.15)]
        [DataRow(32,273.15)]
        [DataRow(0,255.372)]
        public void TestFahrenheitToKelvinConversion(double fahrenheit, double expectedkelvin)
        {
            // Act
            double kelvin = temperatureConverter.FahrenheitToKelvin(fahrenheit);

            Assert.AreEqual(expectedkelvin, kelvin, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DataRow(273.15,32)]
        [DataRow(313.15,104)]
        [DataRow(20,-423.67)]
        public void TestKelvintToFahrenheitConversion(double kelvin, double expectedFahrenheit)
        {
            // Act
            double Fahrenheit = temperatureConverter.KelvinToFahrenheit(kelvin);

            Assert.AreEqual(expectedFahrenheit, Fahrenheit, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }
    }
}