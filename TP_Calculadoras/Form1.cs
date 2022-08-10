namespace TP_Calculadoras
{
    public partial class FrmIMC_Load : Form
    {
        public FrmIMC_Load()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double peso, altura;
            peso = Convert.ToDouble(text_entrada_peso.Text);
            altura = Convert.ToDouble(text_entrada_altura.Text);

            var alturaMetros = altura / 100;

            CalcularImc(peso, alturaMetros);

            var (descricaoImc, resultadoImc) = CalcularImc(peso, alturaMetros);

            lbl_info.Text = $"{descricaoImc}\nSeu IMC: {resultadoImc}";

        }

        private (string,double) CalcularImc (double peso, double altura)
        {
            double imc = peso / (altura * altura);

            var resultado = imc switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso normal",
                >= 25 and < 30 => "Sobre peso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido"
            };

            return (resultado, imc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_titulo.Text = "Calculadora de IMC";
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            text_entrada_peso.Text = String.Empty;
            text_entrada_altura.Text = String.Empty;
            lbl_info.Text = String.Empty;

            text_entrada_peso.Focus();
        }
    }
}