namespace UnitTest.Aplication{
    
    [TestClass]
    [TestCategory("mass")]
    public class MassConverterTest
    {
         UnitsConverter massConverter;
        
        public MassConverterTest()
        {
            massConverter = new UnitsConverter();
        }

        [TestMethod]
        public void TestGramsToKilogramsConversion()
        {
            double grams = 5000; // Exemplo de kilômetros

            // Act
            double kilograms = massConverter.GramsToKilograms(grams);

            // Assert
            double expectedKilograms = 5; // O valor esperado em metros por seguno 1600

            Assert.AreEqual(expectedKilograms, kilograms, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestKilogramsToGramsConversion()
        {
            double kilograms = 5; // Exemplo de kilômetros

            // Act
            double grams = massConverter.KilogramsToGrams(kilograms);

            // Assert
            double expectedgrams = 5000; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedgrams, grams, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestGramsToPoundsConversion()
        {
            double grams = 1000; // Exemplo de kilômetros

            // Act
            double Pounds = massConverter.GramsToPounds(grams);

            // Assert
            double expectedPounds = 2.205; // O valor esperado em metros por seguno 1600

            Assert.AreEqual(expectedPounds, Pounds, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestPoundsToGramsConversion()
        {
            double Pounds = 5; // Exemplo de kilômetros

            // Act
            double grams = massConverter.PoundsToGrams(Pounds);

            // Assert
            double expectedgrams = 2268; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedgrams, grams, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestKilogramsToPoundsConversion()
        {
            double kilograms = 5000; // Exemplo de kilômetros

            // Act
            double pounds = massConverter.KilogramsToPounds(kilograms);

            // Assert
            double expectedpounds = 11025; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedpounds, pounds, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        public void TestPoundsToKilogramsConversion()
        {
            double Pounds = 11025; // Exemplo de kilômetros

            // Act
            double Kilograms = massConverter.PoundsToKilograms(Pounds);

            // Assert
            double expectedKilograms = 5000; // O valor esperado em gramas por 5 kilos

            Assert.AreEqual(expectedKilograms, Kilograms, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }
    }
}