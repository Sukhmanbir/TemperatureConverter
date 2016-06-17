// Project:		    TemperatureConverter
// Date:		    February 1, 2016
// Assignment No.:	1
// Description:	    This project inputs temperature and radio button has to be checked for type of conversion.
// 				    It calculates the temperature in the type selected as well as displays the value in the provided form.
// 				    Uses variables, constants and calculations.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class tempConverter : Form
    {

        //declare variables and constants
        const decimal DECIMAL_INT = 1.8m;
        const int INT = 32;
        decimal inputTemperature;

        public tempConverter()
        {
            InitializeComponent();
        }

        private void tempFahrenheitTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void celsiusRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void fahrenheitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            //checks if the celsius radio button is checked and makes conversions to fahrenheit
            if (celsiusRadioButton.Checked)
            {
                inputTemperature = decimal.Parse(inputTempTextBox.Text);//take the value of input temperature and set the variable
                decimal outputTemp = decimal.Round(((inputTemperature - INT) / DECIMAL_INT), 2);//this local variable makes conversion 
                // and rounds the anwser to display to 2 decimal point
                tempCelsiusTextBox.Text = outputTemp.ToString();
                tempFahrenheitTextBox.Text = inputTempTextBox.Text;//temp in this text box is shown as is since its already in Fahrenheit
            }
            //checks if the fahrenheit radio button is checked and makes conversions to celsius
            else if (fahrenheitRadioButton.Checked)
            {
                inputTemperature = decimal.Parse(inputTempTextBox.Text);//take the value of input temperature and set the variable
                decimal outputTemp = decimal.Round(((inputTemperature * DECIMAL_INT) + INT), 2);//this local variable makes conversion 
                // and rounds the anwser to display to 2 decimal point
                tempFahrenheitTextBox.Text = outputTemp.ToString();
                tempCelsiusTextBox.Text = inputTempTextBox.Text;//temp in this text box is shown as is since its already in Celsius
            }
        }

        //clear the form, resets values to default and unchecks the radio buttons
        private void resetButton_Click(object sender, EventArgs e)
        {
            inputTempTextBox.Text = "0";
            tempCelsiusTextBox.Clear();
            tempFahrenheitTextBox.Clear();
            celsiusRadioButton.Checked = false;
            fahrenheitRadioButton.Checked = false;
        }

        //exit from the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
