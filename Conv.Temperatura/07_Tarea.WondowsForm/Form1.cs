namespace _07_Tarea.WondowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                double grados = double.Parse(txtInput.Text);
                IConversorTemperatura conversor;

                if (cmbConversion.SelectedItem.ToString() == "Celsius a Fahrenheit")
                {
                    conversor = new CelsiusAFahrenheit();
                }
                else
                {
                    conversor = new FahrenheitACelsius();
                }

                double resultado = conversor.Convertir(grados);
                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }
    }
}
