namespace _07_Tarea.WondowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            cmbConversion = new ComboBox();
            btnConvertir = new Button();
            txtResultado = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(7, 32);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 0;
            txtInput.TextChanged += textBox1_TextChanged;
            // 
            // cmbConversion
            // 
            cmbConversion.BackColor = SystemColors.Window;
            cmbConversion.FormattingEnabled = true;
            cmbConversion.Items.AddRange(new object[] { "Celsius -> Fahrenheit", "Fahrenheit -> Celsius" });
            cmbConversion.Location = new Point(7, 61);
            cmbConversion.Name = "cmbConversion";
            cmbConversion.Size = new Size(166, 23);
            cmbConversion.TabIndex = 1;
            cmbConversion.Text = "Seleccione la conversión";
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(7, 90);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(100, 37);
            btnConvertir.TabIndex = 2;
            btnConvertir.Text = "CONVERTIR";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // txtResultado
            // 
            txtResultado.ForeColor = SystemColors.MenuHighlight;
            txtResultado.Location = new Point(7, 133);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 3;
            txtResultado.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Location = new Point(7, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "Ingrese los grados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 442);
            Controls.Add(textBox1);
            Controls.Add(txtResultado);
            Controls.Add(btnConvertir);
            Controls.Add(cmbConversion);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private ComboBox cmbConversion;
        private Button btnConvertir;
        private TextBox txtResultado;
        private TextBox textBox1;
    }
}
