namespace P2_2023_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string? pantalla;
        double? value1;
        double? value2;
        string? temporal;
        string? operador;
        double? resultado;

        private void btn1_Click(object sender, EventArgs e)
        {
            temporal = temporal + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            temporal = temporal + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            temporal = temporal + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            temporal = temporal + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            temporal = temporal + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            temporal = temporal + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            temporal = temporal + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            temporal = temporal + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            temporal = temporal + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            temporal = temporal + 0;
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            temporal = temporal + ".";
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            operador = "sumar";
            mostar_pantalla("+");
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            operador = "restar";
            mostar_pantalla("-");
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            operador = "multiplicar";
            mostar_pantalla("X");
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            operador = "dividir";
            mostar_pantalla("/");
        }

        private void btn_ejecutar_Click(object sender, EventArgs e)
        {
            if (temporal != null)
            {
                if (value1 == null)
                {
                    try
                    {
                        value1 = Double.Parse(temporal);
                    }
                    catch
                    {
                        value1 = 0;
                    }
                    mostar_pantalla(value1.ToString());
                    temporal = null;
                }
                else
                {
                    if (value2 == null)
                    {
                        try
                        {
                            value2 = Double.Parse(temporal);
                        }
                        catch
                        {
                            value2 = 0;
                        }
                        mostar_pantalla(value2.ToString());
                        temporal = null;
                    }
                }
            }

            if (value1 != null && value2 != null && operador != null)
            {
                if (operador == "sumar")
                {
                    resultado = value1 + value2;
                    mostar_pantalla("Resultado: " + resultado.ToString());
                    limpiar();
                }
                if (operador == "restar")
                {
                    resultado = value1 - value2;
                    mostar_pantalla("Resultado: " + resultado.ToString());
                    limpiar();
                }
                if (operador == "multiplicar")
                {
                    resultado = value1 * value2;
                    mostar_pantalla("Resultado: " + resultado.ToString());
                    limpiar();
                }
                if (operador == "dividir")
                {
                    resultado = value1 / value2;
                    mostar_pantalla("Resultado: " + resultado.ToString());
                    limpiar();
                }
            }

            if (operador == "itbis")
            {
                if (value1 != null)
                {
                    resultado = value1 * 0.18;
                    mostar_pantalla("Itbis: " + resultado.ToString());
                    limpiar();
                }
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            limpiar_pantalla();
        }

        private void limpiar_pantalla()
        {
            pantalla = null;
            textBox1.Text = string.Empty;
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
            pantalla = pantalla + System.Environment.NewLine + nuevo;
            textBox1.Text = pantalla;
        }

        private void btn_itbis_Click(object sender, EventArgs e)
        {
            operador = "itbis";
            mostar_pantalla("Itbis");
        }
    }
}