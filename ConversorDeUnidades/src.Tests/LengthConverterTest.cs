namespace UnitTest.Aplication{
    
    [TestClass]
    [TestCategory("length")]
    public class LengthConverterTest
    {
         UnitsConverter lengthConverter;
        
        public LengthConverterTest()
        {
            lengthConverter = new UnitsConverter();
        }

        [TestMethod]
        [DynamicData(nameof(MetersToKilometersData), DynamicDataSourceType.Method)]
        public void TestMetersToKilometerConversion(double meters, double expectedKilometers)
        {
            // Act
            double kilometers = lengthConverter.MetersToKilometers(meters);

            Assert.AreEqual(expectedKilometers, kilometers, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }  

        [TestMethod]
        [DynamicData(nameof(KilometersToMetersData), DynamicDataSourceType.Method)]
        public void TestKilometersToMetersConversion(double kilometers, double expectedMeters)
        {
            // Act
            double meters = lengthConverter.KilometersToMeters(kilometers);

            Assert.AreEqual(expectedMeters, meters, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DynamicData(nameof(MetersToFeetData), DynamicDataSourceType.Method)]
        public void TestMetersToFeetConversion(double meters, double expectedFeet)
        {
            // Act
            double feet = lengthConverter.MetersToFeet(meters);

            Assert.AreEqual(expectedFeet, feet, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DynamicData(nameof(FeetToMetersData), DynamicDataSourceType.Method)]
        public void TestFeetToMetersConversion(double feet, double expectedMeters)
        {
            // Act
            double meters = lengthConverter.FeetToMeters(feet);

            Assert.AreEqual(expectedMeters, meters, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DynamicData(nameof(KilometersToFeetData), DynamicDataSourceType.Method)]
        public void TestKilometersToFeetConversion(double kilometers, double expectedFeet)
        {
            // Act
            double feet = lengthConverter.KilometersToFeet(kilometers);

            Assert.AreEqual(expectedFeet, feet, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [DataTestMethod]
        [DynamicData(nameof(FeetToKilometersData), DynamicDataSourceType.Method)]
        public void TestFeetToKilometersConversion(double feet, double expectedKilometers)
        {
            // Act
            double kilometers = lengthConverter.FeetToKilometers(feet);

            Assert.AreEqual(expectedKilometers, kilometers, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

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