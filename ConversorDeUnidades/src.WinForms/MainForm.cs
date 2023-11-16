using System;
using System.Windows.Forms;
using System.Drawing;
using WinForms.Aplication;

namespace WinForms.Aplication {

    public partial class MainForm : Form {

        Units units = new Units();

        private ComboBox mainComboBox;
        private ComboBox fromComboBox;
        private ComboBox toComboBox;
        private Button converterButton;
        private TextBox inputTextBox;
        private TextBox resultTextBox;
        private Label mainLabel, unitLabel, valueLabel, resultLabel;
        string mainUnit;

        List<string> mainOptions = new List<string> { "Temperature", "Length", "Time", "Mass" };

        List<string> tempOptions = new List<string>
        {
            "Celsius",
            "Fahrenheit",
            "Kelvin"
        };

        List<string> lengthOptions = new List<string>
        {
            "Meters",
            "Kilometers",
            "Feet"
        };

        List<string> timeOptions = new List<string>
        {
            "Seconds",
            "Hours",
            "Days",
        };

        List<string> massOptions = new List<string>
        {
            "Grams",
            "Kilograms",
            "Pounds"
        };

        public MainForm() {
            InitializeComponent();

            CreateComponents();

            mainComboBox.Items.AddRange(mainOptions.ToArray());

            converterButton.Text = "Converter";
            converterButton.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            LabelTexts();
            LabelProperties();
            ComboBoxLocations();
            ComboBoxAdd();

            mainComboBox.SelectedIndexChanged += ComboBoxSelectedItem;
            converterButton.Click += ConverterButtonClick;
        }

        private void CreateComponents() {
            mainComboBox = new ComboBox();
            fromComboBox = new ComboBox();
            toComboBox = new ComboBox();
            converterButton = new Button();
            inputTextBox = new TextBox();
            resultTextBox = new TextBox();
            mainLabel = new Label();
            unitLabel = new Label();
            valueLabel = new Label();
            resultLabel = new Label();
        }

        private void LabelTexts() {
            mainLabel.Text = "Selecione o tipo de Conversão desejada:";
            unitLabel.Text = "Selecione as Unidades:";
            valueLabel.Text = "Entre com o Valor a ser Convertido:";
            resultLabel.Text = "Resultado da Conversão:";
        }

        private void SetLabelProperties(Label label) {
            label.AutoSize = true;
            label.Font = new Font("Calibri", 18);
            label.ForeColor = ColorTranslator.FromHtml("#FF69B4");
        }

        private void LabelProperties() {
            SetLabelProperties(mainLabel);
            SetLabelProperties(unitLabel);
            SetLabelProperties(valueLabel);
            SetLabelProperties(resultLabel);
        }

        private void ComboBoxClear() {
            fromComboBox.SelectedIndex = -1;
            toComboBox.SelectedIndex = -1;
            fromComboBox.Items.Clear();
            toComboBox.Items.Clear();
        }

        private void ComboBoxLocations() {
            mainLabel.Location = new Point(10, 10);
            mainComboBox.Location = new Point(10, 50);
            unitLabel.Location = new Point(10, 90);
            fromComboBox.Location = new Point(10, 130);
            toComboBox.Location = new Point(140, 130);
            valueLabel.Location = new Point(10, 170);
            inputTextBox.Location = new Point(10, 210);
            converterButton.Location = new Point(10, 250);
            resultLabel.Location = new Point(10, 290);
            resultTextBox.Location = new Point(10, 330);
        }

        private void ComboBoxAdd() {
            Controls.Add(mainComboBox);
            Controls.Add(converterButton);
            Controls.Add(fromComboBox);
            Controls.Add(toComboBox);
            Controls.Add(inputTextBox);
            Controls.Add(resultTextBox);
            Controls.Add(mainLabel);
            Controls.Add(unitLabel);
            Controls.Add(valueLabel);
            Controls.Add(resultLabel);
        }

        private void ComboBoxSelectedItem(object sender, EventArgs e)
        {
            string selectedOption = mainComboBox.SelectedItem.ToString();
            ComboBoxClear();

            if (selectedOption == "Temperature")
            {
                fromComboBox.Items.AddRange(tempOptions.ToArray());
                toComboBox.Items.AddRange(tempOptions.ToArray());
            }
            else if (selectedOption == "Length")
            {
                fromComboBox.Items.AddRange(lengthOptions.ToArray());
                toComboBox.Items.AddRange(lengthOptions.ToArray());
            }else if (selectedOption == "Time")
            {
                fromComboBox.Items.AddRange(timeOptions.ToArray());
                toComboBox.Items.AddRange(timeOptions.ToArray());
            }
            else if (selectedOption == "Mass")
            {
                fromComboBox.Items.AddRange(massOptions.ToArray());
                toComboBox.Items.AddRange(massOptions.ToArray());
            }
        }

        private void ConverterButtonClick(object? sender, EventArgs e) {
            string fromUnit = fromComboBox.SelectedItem.ToString();
            string toUnit = toComboBox.SelectedItem.ToString();

            if (mainComboBox.SelectedItem == null || fromComboBox.SelectedItem == null || toComboBox.SelectedItem == null) {
                resultTextBox.Text = "Selecione as unidades de Conversão!";
                return;
            }

            // Converte o valor de texto de entrada para um número. TryParse retorna um valor booleano caso haja sucesso (True)
            if (double.TryParse(inputTextBox.Text, out double inputValue)) {
                // Chama o método ConvertUnits para realizar a conversão

                double convertedValue = ConvertUnits(fromUnit, toUnit, inputValue);
                // Exibe o resultado na TextBox de resultado na forma de string

                resultTextBox.Text = (convertedValue < 1) ? convertedValue.ToString("F5") : convertedValue.ToString("F2");
            } else {
                resultTextBox.Text = "Valor Inválido!";
            }
        }

        private double ConvertUnits(string fromUnit, string toUnit, double value) {

            mainUnit = mainComboBox.SelectedItem.ToString();

            if (mainUnit == null || fromUnit == null || toUnit == null) {
                return value;
            }

            if (mainUnit == "Temperature") {
                return units.TempConvertUnits(fromUnit, toUnit, value);
            } else if (mainUnit == "Length") {
                return units.LengthConvertUnits(fromUnit, toUnit, value);

            } else if (mainUnit == "Time") {
                return units.TimeConvertUnits(fromUnit, toUnit, value);

            } else if (mainUnit == "Mass") {
                return units.MassConvertUnits(fromUnit, toUnit, value);

            } else {
                return value;
            }
        }
    }
}
