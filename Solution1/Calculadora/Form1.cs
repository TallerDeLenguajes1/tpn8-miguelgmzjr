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
        calculo InstanciadeCalculo;
        string signo = null;
        string num = null;
        List<calculo> HistorialCalculadora; 
        public Form1()
        {
            InitializeComponent();
            InstanciadeCalculo = new calculo();
            HistorialCalculadora =  new List<calculo>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            tbpantalla.Text = "";
            InstanciadeCalculo = new calculo();
            num = null;
            signo = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (signo == null)
            {
                tbpantalla.Text = "8";
                num = "8";
                signo = "";
            }
            else
            {
                tbpantalla.Text += "8";
                num += "8";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (signo == null)
            {
                tbpantalla.Text = "6";
                num = "6";
                signo = "";
            }
            else
            {
                tbpantalla.Text += "6";
                num += "6";
            }
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            if (signo == null)
            {
                tbpantalla.Text = "7";
                num = "7";
                signo = "";
            }
            else
            {
                tbpantalla.Text += "7";
                num += "7";
            }
            
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            if(signo == null)
            {
                tbpantalla.Text = "9";
                num = "9";
                signo = "";
            }
            else
            {
                tbpantalla.Text += "9";
                num += "9";
            }
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            if (signo == null)
            {
                tbpantalla.Text = "4";
                num = "4";
                signo = "";
            }
            else
            {
                tbpantalla.Text += "4";
                num += "4";
            }
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            if (signo == null)
            {
                tbpantalla.Text = "5";
                num = "5";
                signo = "";
            }
            else
            {
                tbpantalla.Text += "5";
                num += "5";
            }
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            if (signo == null)
            {
                tbpantalla.Text = "1";
                num = "1";
                signo = "";
            }
            else
            {
                tbpantalla.Text += "1";
                num += "1";
            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            if (signo == null)
            {
                tbpantalla.Text = "2";
                num = "2";
                signo = "";
            }
            else
            {
                tbpantalla.Text += "2";
                num += "2";
            }
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            if (signo == null)
            {
                tbpantalla.Text = "3";
                num = "3";
                signo = "";
            }
            else
            {
                tbpantalla.Text += "3";
                num += "3";
            }
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            if (signo == null)
            {
                tbpantalla.Text = "0";
                num = "0";
                signo = "";
            }
            else
            {
                tbpantalla.Text += "0";
                num += "0";
            }
        }

        private void botondec_Click(object sender, EventArgs e)
        {
            if (num != null) //controlo si ya se escribio un numero
            {
                tbpantalla.Text += ".";
                num += ",";
                if(signo == null)
                {
                    signo = "";
                }
             
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (num != null) //controlo si ya se escribio un numero
            {
                tbpantalla.Text += "+";
                InstanciadeCalculo.Numero1 = float.Parse(num);
                signo = "+";
                num = null;
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
           if(num != null){ //controlo si ya se escribio un numero
                tbpantalla.Text += "-";
                InstanciadeCalculo.Numero1 = float.Parse(num);
                signo = "-";
                num = null;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(num != null) //controlo si ya se escribio un numero
            {
                tbpantalla.Text += "*";
                InstanciadeCalculo.Numero1 = float.Parse(num);
                signo = "*";
                num = null;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(num != null) //controlo si ya se escribio un numero
            {
                tbpantalla.Text += "/";
                InstanciadeCalculo.Numero1 = float.Parse(num);
                signo = "/";
                num = null;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            InstanciadeCalculo.Numero2 = float.Parse(num);
            if(signo == "+")
            {
                tbpantalla.Text = Convert.ToString(InstanciadeCalculo.Numero1 + InstanciadeCalculo.Numero2);
                InstanciadeCalculo.Operacion = "+";
                InstanciadeCalculo.Resultado = InstanciadeCalculo.Numero1 + InstanciadeCalculo.Numero2;
            }
            else if(signo == "-")
            {
                tbpantalla.Text = Convert.ToString(InstanciadeCalculo.Numero1 - InstanciadeCalculo.Numero2);
                InstanciadeCalculo.Operacion = "-";
                InstanciadeCalculo.Resultado = InstanciadeCalculo.Numero1 - InstanciadeCalculo.Numero2;
            }
            else if(signo == "*")
            {
                tbpantalla.Text = Convert.ToString(InstanciadeCalculo.Numero1 * InstanciadeCalculo.Numero2);
                InstanciadeCalculo.Operacion = "*";
                InstanciadeCalculo.Resultado = InstanciadeCalculo.Numero1 * InstanciadeCalculo.Numero2;
            }
            else if(signo == "/")
            {
                if(InstanciadeCalculo.Numero2 == 0)
                {
                    tbpantalla.Text = "ERROR";
                }
                else
                {
                    tbpantalla.Text = Convert.ToString(InstanciadeCalculo.Numero1 / InstanciadeCalculo.Numero2);
                    InstanciadeCalculo.Operacion = "/";
                    InstanciadeCalculo.Resultado = InstanciadeCalculo.Numero1 / InstanciadeCalculo.Numero2;
                }
            }
            else
            {
                tbpantalla.Text = tbpantalla.Text;
            }

            InstanciadeCalculo.Fecha = DateTime.Now;  //almaceno la fecha actual

            lbHistorial.Items.Add(InstanciadeCalculo.MostrarEnHistorial());  //agrego historial al list box
            HistorialCalculadora.Add(InstanciadeCalculo);  //agrego un noto a la lista
            

            //////SETEO TODOS LOS VALORES PARA UN NUEVO CALCULO/////
            InstanciadeCalculo = new calculo();
            num = null;
            signo = null;
            ////////////////////////////////////////////////////////
           
                
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.NumPad7) //no logre hacer funcionar los eventos por teclado
            {
                if (signo == null)
                {
                    tbpantalla.Text = "7";
                    num = "7";
                    signo = "";
                }
                else
                {
                    tbpantalla.Text += "7";
                    num += "7";
                }
            }
        }

        private void lbHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbHistorial_DoubleClick(object sender, EventArgs e)
        {
            lbHistorial.Items.RemoveAt(lbHistorial.SelectedIndex);  
        }
    }
}
