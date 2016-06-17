namespace TemperatureConverter
{
    partial class tempConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inputTempGroupBox = new System.Windows.Forms.GroupBox();
            this.inputTempTextBox = new System.Windows.Forms.TextBox();
            this.inputTempLabel = new System.Windows.Forms.Label();
            this.convertToGroupBox = new System.Windows.Forms.GroupBox();
            this.fahrenheitRadioButton = new System.Windows.Forms.RadioButton();
            this.celsiusRadioButton = new System.Windows.Forms.RadioButton();
            this.outputTempGroupBox = new System.Windows.Forms.GroupBox();
            this.tempFahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.tempCelsiusTextBox = new System.Windows.Forms.TextBox();
            this.tempInFahrenheitLabel = new System.Windows.Forms.Label();
            this.tempInCelsiusLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.inputTempGroupBox.SuspendLayout();
            this.convertToGroupBox.SuspendLayout();
            this.outputTempGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTempGroupBox
            // 
            this.inputTempGroupBox.Controls.Add(this.label1);
            this.inputTempGroupBox.Controls.Add(this.inputTempTextBox);
            this.inputTempGroupBox.Controls.Add(this.inputTempLabel);
            this.inputTempGroupBox.Location = new System.Drawing.Point(55, 38);
            this.inputTempGroupBox.Name = "inputTempGroupBox";
            this.inputTempGroupBox.Size = new System.Drawing.Size(400, 79);
            this.inputTempGroupBox.TabIndex = 0;
            this.inputTempGroupBox.TabStop = false;
            this.inputTempGroupBox.Text = "Input Temperature";
            // 
            // inputTempTextBox
            // 
            this.inputTempTextBox.Location = new System.Drawing.Point(172, 37);
            this.inputTempTextBox.Name = "inputTempTextBox";
            this.inputTempTextBox.Size = new System.Drawing.Size(159, 20);
            this.inputTempTextBox.TabIndex = 0;
            this.inputTempTextBox.Text = "0";
            this.toolTip1.SetToolTip(this.inputTempTextBox, "Enter temperature to convert");
            // 
            // inputTempLabel
            // 
            this.inputTempLabel.AutoSize = true;
            this.inputTempLabel.Location = new System.Drawing.Point(21, 37);
            this.inputTempLabel.Name = "inputTempLabel";
            this.inputTempLabel.Size = new System.Drawing.Size(73, 13);
            this.inputTempLabel.TabIndex = 0;
            this.inputTempLabel.Text = "Temperature :";
            // 
            // convertToGroupBox
            // 
            this.convertToGroupBox.Controls.Add(this.fahrenheitRadioButton);
            this.convertToGroupBox.Controls.Add(this.celsiusRadioButton);
            this.convertToGroupBox.Location = new System.Drawing.Point(55, 146);
            this.convertToGroupBox.Name = "convertToGroupBox";
            this.convertToGroupBox.Size = new System.Drawing.Size(400, 99);
            this.convertToGroupBox.TabIndex = 1;
            this.convertToGroupBox.TabStop = false;
            this.convertToGroupBox.Text = " Convert To";
            // 
            // fahrenheitRadioButton
            // 
            this.fahrenheitRadioButton.AutoSize = true;
            this.fahrenheitRadioButton.Location = new System.Drawing.Point(24, 62);
            this.fahrenheitRadioButton.Name = "fahrenheitRadioButton";
            this.fahrenheitRadioButton.Size = new System.Drawing.Size(75, 17);
            this.fahrenheitRadioButton.TabIndex = 2;
            this.fahrenheitRadioButton.TabStop = true;
            this.fahrenheitRadioButton.Text = "Fahrenheit";
            this.toolTip1.SetToolTip(this.fahrenheitRadioButton, "Convert into Fahrenheit");
            this.fahrenheitRadioButton.UseVisualStyleBackColor = true;
            this.fahrenheitRadioButton.CheckedChanged += new System.EventHandler(this.fahrenheitRadioButton_CheckedChanged);
            // 
            // celsiusRadioButton
            // 
            this.celsiusRadioButton.AutoSize = true;
            this.celsiusRadioButton.Location = new System.Drawing.Point(24, 30);
            this.celsiusRadioButton.Name = "celsiusRadioButton";
            this.celsiusRadioButton.Size = new System.Drawing.Size(58, 17);
            this.celsiusRadioButton.TabIndex = 1;
            this.celsiusRadioButton.TabStop = true;
            this.celsiusRadioButton.Text = "Celsius";
            this.toolTip1.SetToolTip(this.celsiusRadioButton, "Convert into Celsius");
            this.celsiusRadioButton.UseVisualStyleBackColor = true;
            this.celsiusRadioButton.CheckedChanged += new System.EventHandler(this.celsiusRadioButton_CheckedChanged);
            // 
            // outputTempGroupBox
            // 
            this.outputTempGroupBox.Controls.Add(this.label3);
            this.outputTempGroupBox.Controls.Add(this.label2);
            this.outputTempGroupBox.Controls.Add(this.tempFahrenheitTextBox);
            this.outputTempGroupBox.Controls.Add(this.tempCelsiusTextBox);
            this.outputTempGroupBox.Controls.Add(this.tempInFahrenheitLabel);
            this.outputTempGroupBox.Controls.Add(this.tempInCelsiusLabel);
            this.outputTempGroupBox.Location = new System.Drawing.Point(55, 269);
            this.outputTempGroupBox.Name = "outputTempGroupBox";
            this.outputTempGroupBox.Size = new System.Drawing.Size(400, 126);
            this.outputTempGroupBox.TabIndex = 2;
            this.outputTempGroupBox.TabStop = false;
            this.outputTempGroupBox.Text = "Output Temperatures";
            // 
            // tempFahrenheitTextBox
            // 
            this.tempFahrenheitTextBox.Location = new System.Drawing.Point(172, 77);
            this.tempFahrenheitTextBox.Name = "tempFahrenheitTextBox";
            this.tempFahrenheitTextBox.ReadOnly = true;
            this.tempFahrenheitTextBox.Size = new System.Drawing.Size(159, 20);
            this.tempFahrenheitTextBox.TabIndex = 1;
            this.tempFahrenheitTextBox.TabStop = false;
            this.toolTip1.SetToolTip(this.tempFahrenheitTextBox, "Temperature in Fahrenheit");
            this.tempFahrenheitTextBox.TextChanged += new System.EventHandler(this.tempFahrenheitTextBox_TextChanged);
            // 
            // tempCelsiusTextBox
            // 
            this.tempCelsiusTextBox.Location = new System.Drawing.Point(172, 40);
            this.tempCelsiusTextBox.Name = "tempCelsiusTextBox";
            this.tempCelsiusTextBox.ReadOnly = true;
            this.tempCelsiusTextBox.Size = new System.Drawing.Size(159, 20);
            this.tempCelsiusTextBox.TabIndex = 0;
            this.tempCelsiusTextBox.TabStop = false;
            this.toolTip1.SetToolTip(this.tempCelsiusTextBox, "Temperture in Celsius");
            // 
            // tempInFahrenheitLabel
            // 
            this.tempInFahrenheitLabel.AutoSize = true;
            this.tempInFahrenheitLabel.Location = new System.Drawing.Point(21, 80);
            this.tempInFahrenheitLabel.Name = "tempInFahrenheitLabel";
            this.tempInFahrenheitLabel.Size = new System.Drawing.Size(137, 13);
            this.tempInFahrenheitLabel.TabIndex = 2;
            this.tempInFahrenheitLabel.Text = "Temperature in Fahrenheit :";
            // 
            // tempInCelsiusLabel
            // 
            this.tempInCelsiusLabel.AutoSize = true;
            this.tempInCelsiusLabel.Location = new System.Drawing.Point(21, 43);
            this.tempInCelsiusLabel.Name = "tempInCelsiusLabel";
            this.tempInCelsiusLabel.Size = new System.Drawing.Size(120, 13);
            this.tempInCelsiusLabel.TabIndex = 1;
            this.tempInCelsiusLabel.Text = "Temperature in Celsius :";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(55, 447);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "C&onvert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetButton.Location = new System.Drawing.Point(227, 447);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(380, 447);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "degrees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "degrees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "degrees";
            // 
            // tempConverter
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.resetButton;
            this.ClientSize = new System.Drawing.Size(517, 498);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputTempGroupBox);
            this.Controls.Add(this.convertToGroupBox);
            this.Controls.Add(this.inputTempGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "tempConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.inputTempGroupBox.ResumeLayout(false);
            this.inputTempGroupBox.PerformLayout();
            this.convertToGroupBox.ResumeLayout(false);
            this.convertToGroupBox.PerformLayout();
            this.outputTempGroupBox.ResumeLayout(false);
            this.outputTempGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputTempGroupBox;
        private System.Windows.Forms.TextBox inputTempTextBox;
        private System.Windows.Forms.Label inputTempLabel;
        private System.Windows.Forms.GroupBox convertToGroupBox;
        private System.Windows.Forms.RadioButton fahrenheitRadioButton;
        private System.Windows.Forms.RadioButton celsiusRadioButton;
        private System.Windows.Forms.GroupBox outputTempGroupBox;
        private System.Windows.Forms.TextBox tempFahrenheitTextBox;
        private System.Windows.Forms.TextBox tempCelsiusTextBox;
        private System.Windows.Forms.Label tempInFahrenheitLabel;
        private System.Windows.Forms.Label tempInCelsiusLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

