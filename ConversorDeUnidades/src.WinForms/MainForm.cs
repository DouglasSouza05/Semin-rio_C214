using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinForms.Aplication;

public partial class MainForm : Form
{
    
    private TextBox celsiusTextBox;
    private TextBox fahrenheitTextBox;

    public MainForm()
    {
        InitializeComponent();

        celsiusTextBox = new TextBox();
        fahrenheitTextBox = new TextBox();
    
        // Configurar as propriedades dos TextBox
        celsiusTextBox.Location = new Point(10, 10);
        fahrenheitTextBox.Location = new Point(10, 40);

        Button celsiusToFahrenheitButton = new Button();
        celsiusToFahrenheitButton.Text = "Converter";
        celsiusToFahrenheitButton.Location = new Point(10, 70);

        celsiusToFahrenheitButton.Click += CelsiusToFahrenheitButton_Click;

        Controls.Add(celsiusTextBox);
        Controls.Add(fahrenheitTextBox);
        Controls.Add(celsiusToFahrenheitButton);
    }

    private void CelsiusToFahrenheitButton_Click(object sender, EventArgs e)
    {
        if (double.TryParse(celsiusTextBox.Text, out double celsius))
        {
            double fahrenheit = (celsius * 9.0 / 5.0) + 32;
            fahrenheitTextBox.Text = fahrenheit.ToString("F2");
        }
        else
        {
            fahrenheitTextBox.Text = "Valor inválido";
        }
    }
}
