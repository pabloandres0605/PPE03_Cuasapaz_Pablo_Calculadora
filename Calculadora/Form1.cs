using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calculadora
{
    public partial class Form1 : Form
    {
        double primerNumero;
        double segundoNumero;
        double resultado;

        string operacion;

        bool resultadoMostrado;

        const int MaximoDigitos = 15;

        public Form1()
        {
            InitializeComponent();

            btn0.Click += BotonNumero_Click;
            btn1.Click += BotonNumero_Click;
            btn2.Click += BotonNumero_Click;
            btn3.Click += BotonNumero_Click;
            btn4.Click += BotonNumero_Click;
            btn5.Click += BotonNumero_Click;
            btn6.Click += BotonNumero_Click;
            btn7.Click += BotonNumero_Click;
            btn8.Click += BotonNumero_Click;
            btn9.Click += BotonNumero_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPantalla.ReadOnly = true;
            txtPantalla.TextAlign = HorizontalAlignment.Right;

            ReiniciarCalculadora();
        }

        private void AgregarNumero(string numero)
        {
            if (resultadoMostrado)
            {
                txtPantalla.Clear();
                resultadoMostrado = false;
            }

            if (txtPantalla.Text.Length >= MaximoDigitos)
            {
                MessageBox.Show("Se alcanzó el máximo de " + MaximoDigitos + " dígitos.");
                return;
            }

            txtPantalla.Text += numero;
        }

        private void BotonNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            AgregarNumero(boton.Text);
        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void SeleccionarOperacion(string simbolo)
        {
            if (!string.IsNullOrEmpty(operacion) && string.IsNullOrWhiteSpace(txtPantalla.Text))
            {
                operacion = simbolo;
                return;
            }

            if (!string.IsNullOrEmpty(operacion))
            {
                if (!Calcular())
                {
                    return;
                }

                primerNumero = resultado;
                operacion = simbolo;
                txtPantalla.Clear();
                resultadoMostrado = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPantalla.Text))
            {
                MessageBox.Show("Ingrese primero un número.");
                return;
            }

            if (!double.TryParse(txtPantalla.Text, out primerNumero))
            {
                MessageBox.Show("El valor ingresado no es un número válido.");
                txtPantalla.Clear();
                return;
            }

            operacion = simbolo;

            txtPantalla.Clear();
            resultadoMostrado = false;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            SeleccionarOperacion("+");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            SeleccionarOperacion("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            SeleccionarOperacion("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            SeleccionarOperacion("/");
        }

        private bool Calcular()
        {
            if (string.IsNullOrWhiteSpace(txtPantalla.Text))
            {
                MessageBox.Show("Ingrese el segundo número.");
                return false;
            }

            if (!double.TryParse(txtPantalla.Text, out segundoNumero))
            {
                MessageBox.Show("El valor ingresado no es un número válido.");
                txtPantalla.Clear();
                return false;
            }

            switch (operacion)
            {
                case "+":
                    resultado = primerNumero + segundoNumero;
                    break;

                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;

                case "*":
                    resultado = primerNumero * segundoNumero;
                    break;

                case "/":
                    if (segundoNumero == 0)
                    {
                        MessageBox.Show(
                            "No es posible dividir para cero."
                        );
                        txtPantalla.Clear();
                        return false;
                    }

                    resultado = primerNumero / segundoNumero;
                    break;
            }

            if (double.IsInfinity(resultado) || double.IsNaN(resultado))
            {
                MessageBox.Show("El resultado es demasiado grande para mostrarse.");
                ReiniciarCalculadora();
                return false;
            }

            txtPantalla.Text = resultado.ToString();
            return true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operacion))
            {
                MessageBox.Show("Seleccione una operación antes de presionar '='.");
                return;
            }

            if (Calcular())
            {
                operacion = "";
                resultadoMostrado = true;
            }
        }

        private void ReiniciarCalculadora()
        {
            txtPantalla.Clear();

            primerNumero = 0;
            segundoNumero = 0;
            resultado = 0;

            operacion = "";
            resultadoMostrado = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarCalculadora();
        }
    }
}