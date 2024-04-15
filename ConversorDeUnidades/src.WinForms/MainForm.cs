using System;
using System.Windows.Forms;
using System.Drawing;
using WinForms.Aplication;

namespace WinForms.Aplication
{

    public partial class MainForm : Form
    {

        Units units = new Units();
        Config config = new Config();

        private ComboBox mainComboBox;
        private ComboBox fromComboBox;
        private ComboBox toComboBox;
        private Button converterButton;
        private TextBox inputTextBox;
        private TextBox resultTextBox;
        private Label mainLabel, unitLabel, valueLabel, resultLabel;
        // public string mainUnit;
        public string? mainUnit;

        public MainForm()
        {
            InitializeComponent();

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

            CreateComponents();

            if (config.mainOptions != null)
            {
                mainComboBox.Items.AddRange(config.mainOptions.ToArray());
            }

            converterButton.Text = "Converter";
            converterButton.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            LabelTexts();
            LabelProperties();
            ComboBoxLocations();
            ComboBoxAdd();

            mainComboBox.SelectedIndexChanged += ComboBoxSelectedItem;
            converterButton.Click += ConverterButtonClick;
        }

        private void CreateComponents()
        {
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

        private void LabelTexts()
        {
            mainLabel.Text = "Selecione o tipo de Conversão desejada:";
            unitLabel.Text = "Selecione as Unidades:";
            valueLabel.Text = "Entre com o Valor a ser Convertido:";
            resultLabel.Text = "Resultado da Conversão:";
        }

        private void LabelProperties()
        {
            config.SetLabelProperties(mainLabel);
            config.SetLabelProperties(unitLabel);
            config.SetLabelProperties(valueLabel);
            config.SetLabelProperties(resultLabel);
        }

        private void ComboBoxClear()
        {
            fromComboBox.SelectedIndex = -1;
            toComboBox.SelectedIndex = -1;
            fromComboBox.Items.Clear();
            toComboBox.Items.Clear();
        }

        private void ComboBoxLocations()
        {
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

        private void ComboBoxAdd()
        {
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

        private void ComboBoxSelectedItem(object? sender, EventArgs e)
        {
            string selectedOption = mainComboBox.SelectedItem?.ToString() ?? "Default";
            ComboBoxClear();

            if (selectedOption == "Temperature" && config.tempOptions != null)
            {
                fromComboBox.Items.AddRange(config.tempOptions.ToArray());
                toComboBox.Items.AddRange(config.tempOptions.ToArray());
            }
            else if (selectedOption == "Length" && config.lengthOptions != null)
            {
                fromComboBox.Items.AddRange(config.lengthOptions.ToArray());
                toComboBox.Items.AddRange(config.lengthOptions.ToArray());
            }
            else if (selectedOption == "Time" && config.timeOptions != null)
            {
                fromComboBox.Items.AddRange(config.timeOptions.ToArray());
                toComboBox.Items.AddRange(config.timeOptions.ToArray());
            }
            else if (selectedOption == "Mass" && config.massOptions != null)
            {
                fromComboBox.Items.AddRange(config.massOptions.ToArray());
                toComboBox.Items.AddRange(config.massOptions.ToArray());
            }
        }

        private void ConverterButtonClick(object? sender, EventArgs e)
        {

            string fromUnit = fromComboBox.SelectedItem?.ToString() ?? "Default";
            string toUnit = toComboBox.SelectedItem?.ToString() ?? "Default";

            // Converte o valor de texto de entrada para um número. TryParse retorna um valor booleano caso haja sucesso (True)
            if (double.TryParse(inputTextBox.Text, out double inputValue))
            {
                // Chama o método ConvertUnits para realizar a conversão

                double convertedValue = ConvertUnits(fromUnit, toUnit, inputValue);
                // Exibe o resultado na TextBox de resultado na forma de string

                resultTextBox.Text = (convertedValue < 1) ? convertedValue.ToString("F5") : convertedValue.ToString("F2");
            }
            else
            {
                resultTextBox.Text = "Valor Inválido!";
            }
        }

        private double ConvertUnits(string fromUnit, string toUnit, double value)
        {

            mainUnit = mainComboBox.SelectedItem?.ToString() ?? "Default";

            if (mainUnit == null || fromUnit == null || toUnit == null)
            {
                return value;
            }

            if (mainUnit == "Temperature")
            {
                return units.TempConvertUnits(fromUnit, toUnit, value);
            }
            else if (mainUnit == "Length")
            {
                return units.LengthConvertUnits(fromUnit, toUnit, value);

            }
            else if (mainUnit == "Time")
            {
                return units.TimeConvertUnits(fromUnit, toUnit, value);

            }
            else if (mainUnit == "Mass")
            {
                return units.MassConvertUnits(fromUnit, toUnit, value);

            }
            else
            {
                return value;
            }
        }
    }
}
