using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangles2
{
    public partial class task3 : Form
    {
        RectangularTriangle tr1;
        EquilateralTriangle tr2;

        public abstract class Triangle
        {
            public double a, b, alpha;
            /*public Triangle(double _a, double _b, double _alpha)
            {
                if (_a <= 0 || _b <= 0 || _alpha <= 0 || _alpha >= Math.PI)
                {
                    throw new Exception();
                }
                a = _a;
                b = _b;
                alpha = _alpha;
            }*/
            public virtual double PerimeterCalculate()
            {
                return a + b + Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(alpha));
            }

            public virtual double AreaCalculate()
            {
                return a * b * Math.Sin(alpha) / 2;
            }
        }

        public class RectangularTriangle : Triangle
        {
            public RectangularTriangle(double _a, double _b)
            {
                if (_a <= 0 || _b <= 0)
                {
                    throw new Exception();
                }
                a = _a;
                b = _b;
                alpha = Math.PI / 2;
            }
            public override double PerimeterCalculate()
            {
                return a + b + Math.Sqrt(a * a + b * b);
            }
            public override double AreaCalculate()
            {
                return a * b / 2;
            }
        }

        public class EquilateralTriangle : Triangle
        {
            public EquilateralTriangle(double _a)
            {
                if (_a <= 0)
                {
                    throw new Exception();
                }
                a = _a;
                alpha = Math.PI / 3;
            }
            public override double PerimeterCalculate()
            {
                return a * 3;
            }
            public override double AreaCalculate()
            {
                return a * a * Math.Sqrt(3) / 4;
            }
        }

        public task3()
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
                tr1 = new RectangularTriangle(side1, side2);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double side = Convert.ToDouble(textBox3.Text);
                tr2 = new EquilateralTriangle(side);
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

        /*private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = tr1.PerimeterCalculate().ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = tr1.AreaCalculate().ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = tr2.PerimeterCalculate().ToString();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label10.Text = tr2.AreaCalculate().ToString();
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Perimeter is " + tr1.PerimeterCalculate().ToString() + "!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Perimeter is " + tr1.AreaCalculate().ToString() + "!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Perimeter is " + tr2.PerimeterCalculate().ToString() + "!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Perimeter is " + tr2.AreaCalculate().ToString() + "!");
        }
    }
}