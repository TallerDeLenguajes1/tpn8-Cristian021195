using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tpn7.Clases;

namespace tpn7
{
    public partial class Form1 : Form
    {
        public static List<Calculadora> calculos = new List<Calculadora>();
        public static DateTime fecha = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarTB(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "." && !textBox1.Text.Contains(","))
            {
                btn.Text = ",";
                textBox1.Text = textBox1.Text + btn.Text;
            }
            else if (btn.Text == "." && textBox1.Text.Contains(","))
            {
                textBox1.Text = "";
                btnDot.Enabled = false;
            }
            else {
                if (btn.Text == ".")
                {
                    textBox1.Text = "";
                }
                else {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
            }




        }

        private void calcularRes(object sender, EventArgs e)
        {
            calculoMain();
        }

        private void cal(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
               calculoMain();
            }
        }
        public void calculoMain() {
            string texto = textBox1.Text;
            float x, y;
            Calculadora calculo = new Calculadora();
            string resultado;
            if (texto.Contains("+"))
            {
                string[] operando = texto.Split("+");

                calculo = cargarObjeto(float.Parse(operando[0]), float.Parse(operando[1]), "+", fecha);
                resultado = calculo.resultado(float.Parse(operando[0]), float.Parse(operando[1]), "+", fecha);
                pintarTB(resultado, calculo);
                calculos.Add(calculo);

            }
            else if (texto.Contains("-"))
            {
                string[] operando = texto.Split("-");

                calculo = cargarObjeto(float.Parse(operando[0]), float.Parse(operando[1]), "-", fecha);
                resultado = calculo.resultado(float.Parse(operando[0]), float.Parse(operando[1]), "-", fecha);
                pintarTB(resultado, calculo);
                calculos.Add(calculo);
            }
            else if (texto.Contains("*"))
            {
                string[] operando = texto.Split("*");
                calculo = cargarObjeto(float.Parse(operando[0]), float.Parse(operando[1]), "*", fecha);
                resultado = calculo.resultado(float.Parse(operando[0]), float.Parse(operando[1]), "*", fecha);
                pintarTB(resultado, calculo);
                calculos.Add(calculo);
            }
            else if (texto.Contains("/"))
            {
                string[] operando = texto.Split("/");
                calculo = cargarObjeto(float.Parse(operando[0]), float.Parse(operando[1]), "/", fecha);
                resultado = calculo.resultado(float.Parse(operando[0]), float.Parse(operando[1]), "/", fecha);
                calculos.Add(calculo);
                pintarTB(resultado, calculo);
            }
            textBox1.SelectionStart = textBox1.Text.Length;
            
        }

        private void pintarTB(string data, Calculadora calculo) {
            textBox1.Text = calculo.resultado(calculo.X, calculo.Y, calculo.Z,calculo.Fecha);
            listBox2.Items.Add(calculo.X + " " + calculo.Z + " " + calculo.Y + " = " + calculo.resultado(calculo.X, calculo.Y, calculo.Z, calculo.Fecha) + " || Tiempo: " + calculo.Fecha);        }
        private void calcularKey(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                calculoMain();
            }
        }

        private Calculadora cargarObjeto(float x, float y, string op, DateTime fecha) {
            Calculadora trabajo = new Calculadora();
            trabajo.X = x;
            trabajo.Y = y;
            trabajo.Z = op;
            trabajo.Fecha = fecha;
            return trabajo;
        }
        private void listarLista(object sender, EventArgs e)
        {
            MessageBox.Show(calculos[2].Z, "Item de lista n3", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            /*foreach (Calculadora c in calculos) {
                listBox2.Items.Add(c.X.ToString()); 
            }*/
        }

        private void eliminaElemento(object sender, MouseEventArgs e)
        {
            int index = this.listBox2.IndexFromPoint(e.Location);
            listBox2.Items.RemoveAt(index);
            calculos.RemoveAt(index);
        }
    }
}
