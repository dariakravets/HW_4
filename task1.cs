using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangles
{
    public partial class task1 : Form
    {
        Triangle tr1;
        EquilateralTriangle tr2;

        class Triangle
        {
            public double a, b, c;

            public Triangle(double _a, double _b, double _c)
            {
                if (_a <= 0 || _b <= 0 || _c <= 0 || _c >= (_a + _b) || _b >= (_a + _c) || _a >= (_b + _c))
                {
                    throw new Exception();
                }
                a = _a;
                b = _b;
                c = _c;
            }

            public bool ChangeLength(double a, double b, double c)
            {
                if (a <= 0 || b <= 0 || c <= 0 || c >= (a + b) || b >= (a + c) || a >= (b + c))
                    return false;

                this.a = a;
                this.b = b;
                this.c = c;
                return true;
            }

            public string AnglesCount()
            {
                double angA = Math.Acos((b * b + c * c - a * a) / (2 * b * c));
                double angB = Math.Acos((a * a + c * c - b * b) / (2 * a * c));
                double angC = Math.Acos((b * b + a * a - c * c) / (2 * b * a));

                return angA.ToString() + " " + angB.ToString() + " " + angC.ToString();
            }

            public double PerimeterCount()
            {
                return a + b + c;
            }
        }

        class EquilateralTriangle : Triangle
        {
            private double a, b, c;
            public double area;
            public EquilateralTriangle(double _a, double _b, double _c) : base(_a,  _b,  _c)
            {
                if (_a != _b && _b != _c)
                    throw new Exception();
                a = _a;
                b = _b;
                c = _c;

            }
            public void AreaCount()
            {
                area = a * a * Math.Sqrt(3) / 4;
            }
        }

        public task1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double side1 = Convert.ToDouble(textBox1.Text);
                double side2 = Convert.ToDouble(textBox2.Text);
                double side3 = Convert.ToDouble(textBox3.Text);
                tr1 = new Triangle(side1, side2, side3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
            finally
            {
                MessageBox.Show("Triangle was succesfully created!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox7.Text = tr1.AnglesCount();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox4.Text;
            textBox2.Text = textBox5.Text;
            textBox3.Text = textBox6.Text;
            MessageBox.Show("Click all buttons again!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox8.Text = tr1.PerimeterCount().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                tr2 = new EquilateralTriangle(tr1.a, tr1.b, tr1.c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Function \"Calculating an area\" is availiable only for Equilateral Triangle!");
            }
            tr2.AreaCount();
            textBox9.Text = tr2.area.ToString();

        }
    }
}
