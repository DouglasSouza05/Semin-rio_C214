using Core.Aplication;

namespace WinForms.Aplication {

    public class Config {

        public List<string> mainOptions = new List<string> { "Temperature", "Length", "Time", "Mass" };

        public List<string> tempOptions = new List<string>
        {
            "Celsius",
            "Fahrenheit",
            "Kelvin"
        };

        public List<string> lengthOptions = new List<string>
        {
            "Meters",
            "Kilometers",
            "Feet"
        };

        public List<string> timeOptions = new List<string>
        {
            "Seconds",
            "Hours",
            "Days",
        };

        public List<string> massOptions = new List<string>
        {
            "Grams",
            "Kilograms",
            "Pounds"
        };

        public void SetLabelProperties(Label label) {
            label.AutoSize = true;
            label.Font = new Font("Calibri", 18);
            label.ForeColor = ColorTranslator.FromHtml("#FF69B4");
            // label.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }
    }
}