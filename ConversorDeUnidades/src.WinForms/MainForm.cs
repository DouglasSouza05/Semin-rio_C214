using System;
using System.Windows.Forms;

namespace WinForms.Aplication;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    // private void CelsiusToFahrenheitButton_Click(object sender, EventArgs e)
    // {
    //     if (double.TryParse(celsiusTextBox.Text, out double celsius))
    //     {
    //         double fahrenheit = (celsius * 9.0 / 5.0) + 32;
    //         fahrenheitTextBox.Text = fahrenheit.ToString("F2");
    //     }
    //     else
    //     {
    //         fahrenheitTextBox.Text = "Valor inválido";
    //     }
    // }
}
