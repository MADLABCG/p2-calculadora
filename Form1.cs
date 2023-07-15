namespace P2_2023_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string pantalla;

        double value1;
        double value2;
        string temporal;
        string operador;
        double resultado;

        private void btn1_Click(object sender, EventArgs e)
        {
            temporal.Text = temporal.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            temporal.Text = temporal.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            temporal.Text = temporal.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            temporal.Text = temporal.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            temporal.Text = temporal.Text + 5;
        }   

        private void btn6_Click(object sender, EventArgs e)
        {
            temporal.Text = temporal.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            temporal.Text = temporal.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            temporal.Text = temporal.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            temporal.Text = temporal.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            temporal.Text = temporal.Text + 0;
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            temporal.Text = temporal.Text + ".";
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            operador.Text = "sumar";
            mostar_pantalla(operador);
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            operador.Text = "restar";
            mostar_pantalla(operador);
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            operador.Text = "multiplicar";
            mostar_pantalla(operador);
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            operador.Text = "dividir";
            mostar_pantalla(operador);
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {
            if(value1 == null)
            {
                value1 = (double)temporal;
                mostar_pantalla((string)value1);
                temporal = null;
            } else {
                if(value2 == null)
                {
                    value2 = (double)temporal;
                    mostar_pantalla((string)value2);
                    temporal = null;
                }
            }

            if(value1 != null && value2 != null && operador != null)
            {
                if(operador == "sumar")
                {
                    resultado = value1 + value2;
                    limpiar();
                }
                if(operador == "restar")
                {
                    resultado = value1 - value2;
                    limpiar();
                }
                if(operador == "multiplicar")
                {
                    resultado = value1 * value2;
                    limpiar();
                }
                if(operador == "dividir")
                {
                    resultado = value1 / value2;
                    limpiar();
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            limpiar_pantalla();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {

        }

        private void limpiar_pantalla()
        {
            pantalla = null;
        }

        private void limpiar()
        {
            value1 = null;
            value2 = null;
            operador = null;
            temporal = null;
        }

        private void mostar_pantalla(string nuevo)
        {
            pantalla = pantalla.Text + nuevo;
        }
    }
}