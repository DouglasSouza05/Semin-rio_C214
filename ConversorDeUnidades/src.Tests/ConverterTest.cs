namespace UnitTest.Aplication{

    [TestClass]
    public class UnitsConverterTest
    {
        UnitsConverter unitsConverter;

        public UnitsConverterTest()
        {
            unitsConverter = new UnitsConverter();
        }

        // [TestInitialize]
        // public void Setup()
        // {
        //     unitsConverter = new UnitsConverter();
        // }

        [TestMethod]
        [DataRow(40,104)]
        [DataRow(0,32)]
        [DataRow(25,77)]
        [TestCategory("temperature")]
        public void TestCelsiusToFahrenheitConversion(double celsius, double expectedFahrenheit)
        {
            // Act
            double fahrenheit = unitsConverter.CelsiusToFahrenheit(celsius);

            Assert.AreEqual(expectedFahrenheit, fahrenheit, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DataRow(104,40)]
        [DataRow(32,0)]
        [DataRow(77,25)]
        [TestCategory("temperature")]
        public void TestFahrenheitToCelsiusConversion(double fahrenheit, double expectedCelsius)
        {
            // Act
            double celsius = unitsConverter.FahrenheitToCelsius(fahrenheit);

            Assert.AreEqual(expectedCelsius, celsius, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DataRow(0,273.15)]
        [DataRow(20,293.15)]
        [DataRow(-30,243.15)]
        [TestCategory("temperature")]
        public void TestCelsiustToKelvinConversion(double celsius, double expectedKelvin)
        {
            // Act
            double kelvin = unitsConverter.CelsiusToKelvin(celsius);

            Assert.AreEqual(expectedKelvin, kelvin, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DataRow(273.15,0)]
        [DataRow(303.15,30)]
        [DataRow(20,-253.15)]
        [TestCategory("temperature")]
        public void TestKelvintToCelsiusConversion(double kelvin, double expectedCelsius)
        {
            // Act
            double celsius = unitsConverter.KelvinToCelsius(kelvin);

            Assert.AreEqual(expectedCelsius, celsius, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DataRow(104,313.15)]
        [DataRow(32,273.15)]
        [DataRow(0,255.372)]
        [TestCategory("temperature")]
        public void TestFahrenheitToKelvinConversion(double fahrenheit, double expectedkelvin)
        {
            // Act
            double kelvin = unitsConverter.FahrenheitToKelvin(fahrenheit);

            Assert.AreEqual(expectedkelvin, kelvin, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DataRow(273.15,32)]
        [DataRow(313.15,104)]
        [DataRow(20,-423.67)]
        [TestCategory("temperature")]
        public void TestKelvintToFahrenheitConversion(double kelvin, double expectedFahrenheit)
        {
            // Act
            double Fahrenheit = unitsConverter.KelvinToFahrenheit(kelvin);

            Assert.AreEqual(expectedFahrenheit, Fahrenheit, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        //---------------------------------------------------------------------------------------------------

        [TestMethod]
        [DynamicData(nameof(MetersToKilometersData), DynamicDataSourceType.Method)]
        [TestCategory("length")]
        public void TestMetersToKilometerConversion(double meters, double expectedKilometers)
        {
            // Act
            double kilometers = unitsConverter.MetersToKilometers(meters);

            Assert.AreEqual(expectedKilometers, kilometers, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }  

        [TestMethod]
        [DynamicData(nameof(KilometersToMetersData), DynamicDataSourceType.Method)]
        [TestCategory("length")]
        public void TestKilometersToMetersConversion(double kilometers, double expectedMeters)
        {
            // Act
            double meters = unitsConverter.KilometersToMeters(kilometers);

            Assert.AreEqual(expectedMeters, meters, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DynamicData(nameof(MetersToFeetData), DynamicDataSourceType.Method)]
        [TestCategory("length")]
        public void TestMetersToFeetConversion(double meters, double expectedFeet)
        {
            // Act
            double feet = unitsConverter.MetersToFeet(meters);

            Assert.AreEqual(expectedFeet, feet, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DynamicData(nameof(FeetToMetersData), DynamicDataSourceType.Method)]
        [TestCategory("length")]
        public void TestFeetToMetersConversion(double feet, double expectedMeters)
        {
            // Act
            double meters = unitsConverter.FeetToMeters(feet);

            Assert.AreEqual(expectedMeters, meters, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DynamicData(nameof(KilometersToFeetData), DynamicDataSourceType.Method)]
        [TestCategory("length")]
        public void TestKilometersToFeetConversion(double kilometers, double expectedFeet)
        {
            // Act
            double feet = unitsConverter.KilometersToFeet(kilometers);

            Assert.AreEqual(expectedFeet, feet, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DynamicData(nameof(FeetToKilometersData), DynamicDataSourceType.Method)]
        [TestCategory("length")]
        public void TestFeetToKilometersConversion(double feet, double expectedKilometers)
        {
            // Act
            double kilometers = unitsConverter.FeetToKilometers(feet);

            Assert.AreEqual(expectedKilometers, kilometers, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }          

        //--------------------------------------------------------------------------------------------

        [TestMethod]
        [TestCategory("mass")]
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
        [TestCategory("mass")]
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
        [TestCategory("mass")]
        public void TestKilogramsToPoundsConversion()
        {
            double kilograms = 5000; // Exemplo de kilômetros

            // Act
            double pounds = unitsConverter.KilogramsToPounds(kilograms);

            // Assert
            double expectedpounds = 11025; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedpounds, pounds, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        //--------------------------------------------------------------------------------------------------

        [TestMethod]
        [TestCategory("time")]
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
        [TestCategory("time")]
        public void TestHoursToSecondsConversion()
        {
            double hours = 100; // Exemplo de kilômetros

            // Act
            double seconds = unitsConverter.HoursToSeconds(hours);

            // Assert
            double expectedseconds = 360000; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedseconds, seconds, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        //--------------------------------------------------------------------------------------------
        private static IEnumerable<object[]> MetersToFeetData()
        {
            return new[]
            {
                new object[] { 1000, 3281 },
                new object[] { 50, 164.05 },
                new object[] { 1, 3.281 }
            };
        }

        private static IEnumerable<object[]> FeetToMetersData()
        {
            return new[]
            {
                new object[] { 3281, 1000 },
                new object[] { 164.05, 50 },
                new object[] { 3.281, 1 }
            };
        }

        private static IEnumerable<object[]> KilometersToFeetData()
        {
            return new[]
            {
                new object[] { 1, 3281 },
                new object[] { 5, 16405 },
                new object[] { 10, 32810 }
            };
        }

        private static IEnumerable<object[]> FeetToKilometersData()
        {
            return new[]
            {
                new object[] { 3281, 1 },
                new object[] { 16405, 5 },
                new object[] { 32810, 10 }
            };
        }
        
        private static IEnumerable<object[]> MetersToKilometersData()
        {
            return new[]
            {
                new object[] { 1000, 1 },
                new object[] { 500, 0.5 },
                new object[] { 20000, 20 }
            };
        }

        private static IEnumerable<object[]> KilometersToMetersData()
        {
            return new[]
            {
                new object[] { 1, 1000 },
                new object[] { 0.4, 400 },
                new object[] { 50, 50000 }
            };
        }
    }
}