namespace CalculadoradePesoCorporal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoPeso = txtPeso.Text;
            double peso = Double.Parse(textoPeso); // Peso en kilogramos
            string textoAltura = txtAltura.Text;
            double Altura = Double.Parse(textoAltura); //Altura en metros
        }
    }
}
