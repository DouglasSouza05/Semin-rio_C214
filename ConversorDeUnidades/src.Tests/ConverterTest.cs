namespace UnitTest.Aplication{

    [TestClass]
    public class UnitsConverterTest
    {
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
    }

}