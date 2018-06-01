using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace research_8
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool enter_value = false;
        float Cel, Fah, Kel;
        char op;
        bool decNum = true, binNum = false, hexNum = false, octNum = false;

        public Form1()
        {
            InitializeComponent();
            this.Location = new Point();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const int w = 312;
            const int h = 450;
            this.Width = w;
            this.Height = h;
            txtDisplay.Width = 266;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 312;
            txtDisplay.Width = 266;
            this.Height = 450;
            if (txtDisplay.Text.Length > 5)
            {
                float Fsize = txtDisplay.Font.Size;
                Fsize = 10;
                txtDisplay.Font = new Font(txtDisplay.Font.Name, Fsize, txtDisplay.Font.Style, txtDisplay.Font.Unit);
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
            }
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 675;
            txtDisplay.Width = 630;
            this.Height = 450;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void strongMathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 950;
            this.Height = 450;
            txtDisplay.Width = 633;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox4.Location = new Point(674, 27);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1143;
            this.Height = 450;
            txtDisplay.Width = 633;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void button_Click(object sender, EventArgs e)
        {

            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
                enter_value = false;
                Button num = (Button)sender;
            num.FlatStyle = FlatStyle.Flat;
            num.FlatAppearance.BorderSize = 0;
            if (num.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + num.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + num.Text;
        }

        private void btnDeleteCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void Arithmetic_Operartor(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            result = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
            lblShowOp.Text = System.Convert.ToString(result) + " " + operation;
        }

        private void havasare(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            switch (operation)
            {
                case "+":
                    {
                        txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    }
                case "-":
                    {
                        txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    }
                case "*":
                    {
                        txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    }
                case "/":
                    {
                        txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    }
                case "ⁿ√":
                    {
                        txtDisplay.Text = (Math.Pow(result, (1 / Double.Parse(txtDisplay.Text)))).ToString();
                        break;
                    }
                case "Mod":
                    {
                        txtDisplay.Text = (result % Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    }
                case "EE":
                    {
                        txtDisplay.Text = (result * Math.Pow(10, Double.Parse(txtDisplay.Text))).ToString();
                        break;
                    }
                case "xⁿ":
                    {
                        txtDisplay.Text = (Math.Pow(result, Double.Parse(txtDisplay.Text))).ToString();
                        break;
                    }
            }          
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = "Exp(" + txtDisplay.Text + ")";
            txtDisplay.Text = (Math.Exp(a)).ToString();
        }

        private void btnPi_Click(object sender, EventArgs e) => txtDisplay.Text = Math.PI.ToString();

        private void btnLog_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Log10" + "(" + txtDisplay.Text + ")");
            log = Math.Log10(log);
            txtDisplay.Text = System.Convert.ToString(log);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sqrt" + "(" + txtDisplay.Text + ")");
            sqrt = Math.Sqrt(sqrt);
            txtDisplay.Text = System.Convert.ToString(sqrt);
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            double x2 = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString(txtDisplay.Text + "²");
            x2 = Math.Pow(x2, 2);
            txtDisplay.Text = System.Convert.ToString(x2);
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            double x3 = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString(txtDisplay.Text + "³");
            x3 = Math.Pow(x3, 3);
            txtDisplay.Text = System.Convert.ToString(x3);
        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double sinh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sinh" + "(" + txtDisplay.Text + ")");
            double k = Math.PI / sinh;
            lblShowOp.Text = System.Convert.ToString("sinh" + "(" + txtDisplay.Text + ")");
            sinh = Math.Sinh(180 / k);
            txtDisplay.Text = System.Convert.ToString(sinh);
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double sin = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sin" + "(" + txtDisplay.Text + ")");
            sin = Math.Sin(sin);
            txtDisplay.Text = System.Convert.ToString(sin);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double cosh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("cosh" + "(" + txtDisplay.Text + ")");
            cosh = Math.Cosh(cosh);
            txtDisplay.Text = System.Convert.ToString(cosh);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double cos = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("cos" + "(" + txtDisplay.Text + ")");
            cos = Math.Cos(cos);
            txtDisplay.Text = System.Convert.ToString(cos);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double tgh = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("tanh" + "(" + txtDisplay.Text + ")");
            tgh = Math.Tanh(tgh);
            txtDisplay.Text = System.Convert.ToString(tgh);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double tg = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("tan" + "(" + txtDisplay.Text + ")");
            tg = Math.Tan(tg);
            txtDisplay.Text = System.Convert.ToString(tg);
        }

        private void btnE_Click(object sender, EventArgs e) => txtDisplay.Text = Math.E.ToString();

        private void btnPhi_Click(object sender, EventArgs e)
        {
            double phi = (1 + Math.Sqrt(5)) / 2;
            txtDisplay.Text = phi.ToString();
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(txtDisplay.Text);
            x = 0 - x;
            txtDisplay.Text = System.Convert.ToString(x);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            double sqrt_pow_three = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("³√" + txtDisplay.Text);
            sqrt_pow_three = Math.Pow(sqrt_pow_three, 1.0 / 3.0);
            txtDisplay.Text = System.Convert.ToString(sqrt_pow_three);
        }

        private void btnSqrtxy_Click(object sender, EventArgs e)
        {
            //double x = Double.Parse(txtDisplay.Text);
            //lblShowOp.Text = "x^1/y";
            //x = (Math.Pow(result, (1 / x)));
            //txtDisplay.Text = System.Convert.ToString(x);
        }
        
        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a,2);
            decNum = false;
            hexNum = false;
            octNum = false;
            binNum = true;
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 16);
            decNum = false;
            hexNum = true;
            octNum = false;
            binNum = false;
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 8);
            decNum = false;
            hexNum = false;
            octNum = true;
            binNum = false;
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            int bin, sum = 0, counter = 0, power;
            if (!decNum && binNum)
            {


                bin = int.Parse(txtDisplay.Text);
                while (bin != 0)
                {
                    power = 1;
                    for (int i = 0; i < counter; i++)
                    {
                        power *= 2;
                    }
                    sum += (power * (bin % 10));
                    bin /= 10;
                    counter++;
                }

                txtDisplay.Text = System.Convert.ToString(sum);
            }
            else if (hexNum)
            {
                int number = int.Parse(txtDisplay.Text, System.Globalization.NumberStyles.HexNumber);
                txtDisplay.Text = System.Convert.ToString(number);
            }
            else if (octNum)
            {
                int octLength = txtDisplay.Text.Length;
                double decNumber = 0;

                for (int i = 0; i < octLength; ++i)
                {
                    decNumber += ((byte)txtDisplay.Text[i] - 48) * Math.Pow(8, ((octLength - i) - 1));
                }

                txtDisplay.Text = System.Convert.ToString((int)decNumber);
            }
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("1/" + txtDisplay.Text);
            x = 1 / x;
            txtDisplay.Text = System.Convert.ToString(x);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            long sum = long.Parse(txtDisplay.Text);
            sum = ((sum * (sum - 1)) / 2) + sum;
            txtDisplay.Text = System.Convert.ToString(sum);
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            long n = long.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString(txtDisplay.Text + "!");
            if (n == 0)
            {
                txtDisplay.Text = "0";
            }
            else if (n == 1)
            {
                txtDisplay.Text = "1";
            }
            else
            {
                int factorial = 1;
                for (int i = 1; i <=n; i++)
                {
                    factorial *= i;
                }
                txtDisplay.Text = System.Convert.ToString(factorial);
            }
        }

        private void btnInx_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("In(" + txtDisplay.Text + ")");
            a = Math.Log(a);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        private void rbK_CheckedChanged(object sender, EventArgs e)
        {
            op = 'K';
        }

        private void rbFtoC_CheckedChanged(object sender, EventArgs e)
        {
            op = 'F';
        }

        private void rbCtoF_CheckedChanged(object sender, EventArgs e)
        {
            op = 'C';
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtConvert.Clear();
            lblConvert.Text = "";
            rbCtoF.Checked = false;
            rbFtoC.Checked = false;
            rbK.Checked = false;
        }

        private void cbConvert_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataConvertionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 1167;
            this.Height = 450;
            txtDisplay.Width = 633;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox3.Location = new Point(674, 27);
        }

        private void btnSin_Click_1(object sender, EventArgs e)
        {
            double sin = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sin" + "(" + txtDisplay.Text + ")");
            sin = Math.Sin(sin);
            txtDisplay.Text = System.Convert.ToString(sin);
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            //int x;
            //x = int.Parse(txtDisplay.Text);
            //lblShowOp.Text = "Mod(" + txtDisplay.Text + ")";
            //x = (int)result / x;
            //int y = (int)result - x;
            //txtDisplay.Text = System.Convert.ToString(y);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (cbConvert.SelectedItem)
            {
                case "AMD to RUB":
                    double z = Double.Parse(txtDisplayCUR.Text);
                    z /= 8;
                    z = Math.Round(z, 2, MidpointRounding.AwayFromZero);
                    txtConvertCUR.Text = System.Convert.ToString(z);
                    break;
                case "AMD to USD":
                    double y = Double.Parse(txtDisplayCUR.Text);
                    y /= 485;
                    y = Math.Round(y, 2, MidpointRounding.AwayFromZero);
                    txtConvertCUR.Text = System.Convert.ToString(y);
                    break;        
                case "AMD to EUR":
                    double x = Double.Parse(txtDisplayCUR.Text);
                    x /= 566;
                    x = Math.Round(x, 2, MidpointRounding.AwayFromZero);
                    txtConvertCUR.Text = System.Convert.ToString(x);
                    break;
                case "AMD to GBP":
                    double w = Double.Parse(txtDisplayCUR.Text);
                    w /= 640;
                    w = Math.Round(w, 2, MidpointRounding.AwayFromZero);
                    txtConvertCUR.Text = System.Convert.ToString(w);
                    break;
                case "RUB to AMD":
                    double q = Double.Parse(txtDisplayCUR.Text);
                    q *= 8;
                    txtConvertCUR.Text = System.Convert.ToString(q);
                    break;
                case "RUB to USD":
                    double r = Double.Parse(txtDisplayCUR.Text);
                    r /= 0.017;
                    r = Math.Round(r, 2, MidpointRounding.AwayFromZero);
                    txtConvertCUR.Text = System.Convert.ToString(r);
                    break;
                case "RUB to EUR":
                    double t = Double.Parse(txtDisplayCUR.Text);
                    t /= 0.014;
                    t = Math.Round(t, 2, MidpointRounding.AwayFromZero);
                    txtConvertCUR.Text = System.Convert.ToString(t);
                    break;
                case "RUB to GBP":
                    double u = Double.Parse(txtDisplayCUR.Text);
                    u /= 0.013;
                    u = Math.Round(u, 2, MidpointRounding.AwayFromZero);
                    txtConvertCUR.Text = System.Convert.ToString(u);
                    break;
                case "USD to AMD":
                    double i = Double.Parse(txtDisplayCUR.Text);
                    i *= 485;
                    txtConvertCUR.Text = System.Convert.ToString(i);
                    break;
                case "USD to RUB":
                    double o = Double.Parse(txtDisplayCUR.Text);
                    o /= 500;
                    o = Math.Round(o, 2, MidpointRounding.AwayFromZero);
                    txtConvertCUR.Text = System.Convert.ToString(o);
                    break;
                case "USD to EUR":
                    double p = Double.Parse(txtDisplayCUR.Text);
                    p /= 0.86;
                    p = Math.Round(p, 2, MidpointRounding.AwayFromZero);
                    txtConvertCUR.Text = System.Convert.ToString(p);
                    break;
                case "USD to GBP":
                    double a = Double.Parse(txtDisplayCUR.Text);
                    a /= 0.76;
                    a = Math.Round(a, 2, MidpointRounding.AwayFromZero);
                    txtConvertCUR.Text = System.Convert.ToString(a);
                    break;
                case "EUR to AMD":
                    double s = Double.Parse(txtDisplayCUR.Text);
                    s *= 566;
                    txtConvertCUR.Text = System.Convert.ToString(s);
                    break;
                case "EUR to RUB":
                    double d = Double.Parse(txtDisplayCUR.Text);
                    d *= 68;
                    txtConvertCUR.Text = System.Convert.ToString(d);
                    break;
                case "EUR to USD":
                    double f = Double.Parse(txtDisplayCUR.Text);
                    f *= 1.17;
                    txtConvertCUR.Text = System.Convert.ToString(f);
                    break;
                case "EUR to GBP":
                    double g = Double.Parse(txtDisplayCUR.Text);
                    g *= 0.88;
                    txtConvertCUR.Text = System.Convert.ToString(g);
                    break;
                case "GBP to AMD":
                    double h = Double.Parse(txtDisplayCUR.Text);
                    h *= 637;
                    txtConvertCUR.Text = System.Convert.ToString(h);
                    break;
                case "GBP to RUB":
                    double j = Double.Parse(txtDisplayCUR.Text);
                    j *= 78;
                    txtConvertCUR.Text = System.Convert.ToString(j);
                    break;
                case "GBP to USD":
                    double k = Double.Parse(txtDisplayCUR.Text);
                    k *= 637;
                    txtConvertCUR.Text = System.Convert.ToString(k);
                    break;
                case "GBP to EUR":
                    double l = Double.Parse(txtDisplayCUR.Text);
                    l *= 637;
                    txtConvertCUR.Text = System.Convert.ToString(l);
                    break;
            }
        }

        private void txtConvertCUR_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisplayCUR_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "Infinity")
            {
                txtDisplay.Text = "Can't divide by 0";
            }
        }

        private void arcsin_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(txtDisplay.Text);
            x = Math.Asin(x);
            txtDisplay.Text = System.Convert.ToString(x);
        }

        private void arccot_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(txtDisplay.Text);
            x = Math.Atan(1 / x);
            txtDisplay.Text = System.Convert.ToString(x);
        }

        private void button_ctg_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(txtDisplay.Text);
            x = 1 / Math.Tan(x);
            txtDisplay.Text = System.Convert.ToString(x);
        }

        private void arctan_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(txtDisplay.Text);
            x = Math.Atan(x);
            txtDisplay.Text = System.Convert.ToString(x);
        }

        private void arccos_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(txtDisplay.Text);
            x = Math.Acos(x);
            txtDisplay.Text = System.Convert.ToString(x);
        }

        private void btnTokos_Click(object sender, EventArgs e)
        {
            if (operation == "*" || operation == "/")
            {
                double a;
                a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100);
                txtDisplay.Text = System.Convert.ToString(a);
            }
            else if (operation == "+" || operation == "-")
            {
                double x = Convert.ToDouble(txtDisplay.Text)/*100%*//*, y = x*/;
                double z;
                double y;
                //y = y * x;
                if (operation == "+")
                {
                    //z = (x * 100) + Convert.ToDouble(txtDisplay.Text);
                    //z -= (x * 100);

                    z = (x * result) / 100;
                    y = z + result;
                    y -= result;
                    txtDisplay.Text = System.Convert.ToString(y);
                }
                else if (operation == "-")
                {
                    z = (x * result) / 100;
                    y = result + z;
                    y -= result;
                    txtDisplay.Text = System.Convert.ToString(y);
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case 'C':
                    Cel = float.Parse(txtConvert.Text);
                    lblConvert.Text = (Math.Round(((1.8 * Cel) + 32), 4).ToString() + " ºF");
                    break;
                case 'F':
                    Fah = float.Parse(txtConvert.Text);
                    lblConvert.Text = (Math.Round(((Fah - 32) / 1.8), 5).ToString() + " ºC");
                    break;
                case 'K':
                    Kel = float.Parse(txtConvert.Text);
                    lblConvert.Text = (Math.Round((Kel + 273.15), 5).ToString() + " ºK");
                    break;
            }
        }
    }
}