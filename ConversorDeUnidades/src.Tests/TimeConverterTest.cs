namespace UnitTest.Aplication{
    
    [TestClass]
    [TestCategory("time")]
    public class TimeConverterTest
    {
         UnitsConverter timeConverter;
        
        public TimeConverterTest()
        {
            timeConverter = new UnitsConverter();
        }

        [TestMethod]
        [DataRow(3600,1)]
        public void TestSecondsToHoursConversion(double seconds, double expectedHours)
        {
            // Act
            double hours = timeConverter.SecondsToHours(seconds);

            Assert.AreEqual(expectedHours, hours, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        [DataRow(-3600)]
        [TestCategory("exception")]
        public void TestNegativeSecondsToHoursConversion(double seconds)
        {
            // Assert
            var exc = Assert.ThrowsException<ArgumentException>(() => timeConverter.SecondsToHours(seconds));

            Assert.AreEqual("O valor dos segundos não pode ser negativo.", exc.Message);
        }

        [TestMethod]
        [DataRow(100,360000)]
        public void TestHoursToSecondsConversion(double hours, double expectedSeconds)
        {
            // Act
            double seconds = timeConverter.HoursToSeconds(hours);

            Assert.AreEqual(expectedSeconds, seconds, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        [DataRow(86400,1)]
        public void TestSecondsToDaysConversion(double seconds, double expectedDays)
        {
            // Act
            double days = timeConverter.SecondsToDays(seconds);

            Assert.AreEqual(expectedDays, days, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        [DataRow(7,604800)]
        public void TestDaysToSecondsConversion(double days, double expectedSeconds)
        {
            // Act
            double seconds = timeConverter.DaysToSeconds(days);

            Assert.AreEqual(expectedSeconds, seconds, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        [DataRow(24,1)]
        public void TestHoursToDaysConversion(double Hours, double expectedDays)
        {
            // Act
            double days = timeConverter.HoursToDays(Hours);

            Assert.AreEqual(expectedDays, days, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }

        [TestMethod]
        [DataRow(7,168)]
        public void TestDaysToHoursConversion(double days, double expectedHours)
        {
            // Act
            double Hours = timeConverter.DaysToHours(days);

            Assert.AreEqual(expectedHours, Hours, 0.01); // Use uma margem de erro pequena (0.01) devido a arredondamentos
        }
    }
}