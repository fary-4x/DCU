namespace Calculadora1
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txt.Text = txt.Text + ".";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(txt.Text);
            txt.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operacion = "x";
            primero = double.Parse(txt.Text);
            txt.Clear();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {   
            operacion = "+";
            primero = double.Parse(txt.Text);
            txt.Clear();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {   
            operacion = "-";
            primero = double.Parse(txt.Text);
            txt.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(txt.Text);

            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    txt.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = primero - segundo;
                    txt.Text = resultado.ToString();
                    break;

                case "x":
                    resultado = primero * segundo;
                    txt.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = primero / segundo;
                    txt.Text = resultado.ToString();
                    break;

            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txt.Clear();
        }

        private void btnC_Click(object sender, EventArgs e)
        {

            if (txt.Text.Length == 1)
                txt.Text = "";
            else
                txt.Text = txt.Text.Substring(0, txt.Text.Length - 1);
        }
    }
}