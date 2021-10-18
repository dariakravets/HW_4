using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeomFigures
{
    public partial class task2 : Form
    {
        public abstract class Figure
        {
            public virtual void PerimeterCount()
            {

            }
            public virtual void AreaCount()
            {
                
            }
        }

        public class Triangle : Figure
        {
            private double a, b, c;
            public double perimeter, area;
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
            public override void PerimeterCount()
            {
                perimeter = a + b + c;
            }
            public override void AreaCount()
            {
                area = Math.Sqrt(((a + b + c) / 2) * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c));
            }
        } //три стороны
        public class Circle : Figure
        {
            private double r;
            public double perimeter, area;
            public Circle(double _r)
            {
                if (_r <= 0 )
                {
                    throw new Exception();
                }
                r = _r;
            }
            public override void PerimeterCount()
            {
                perimeter = 2 * Math.PI * r;
            }
            public override void AreaCount()
            {
                area = Math.PI * r * r;
            }
        } //радиус
        public class Rectangle : Figure
        {
            private double a, b;
            public double perimeter, area;
            public Rectangle(double _a, double _b)
            {
                if (_a <= 0 || _b <= 0 )
                {
                    throw new Exception();
                }
                a = _a;
                b = _b;
            }
            public override void PerimeterCount()
            {
                perimeter = 2 * (a + b);
            }
            public override void AreaCount()
            {
                area = a * b;
            }
        } //две стороны
        public class Square : Figure
        {
            private double a;
            public double perimeter, area;
            public Square(double _a)
            {
                if (_a <= 0)
                {
                    throw new Exception();
                }
                a = _a;
            }
            public override void PerimeterCount()
            {
                perimeter = 4 * a;
            }
            public override void AreaCount()
            {
                area = a * a;
            }
        } //одна сторона
        public class Rhomb : Figure
        {
            private double a, alpha;
            public double perimeter, area;
            public Rhomb(double _a, double _alpha)
            {
                if (_a <= 0 || _alpha <= 0)
                {
                    throw new Exception();
                }
                a = _a;
                alpha = _alpha;
            }
            public override void PerimeterCount()
            {
                perimeter = 4 * a;
            }
            public override void AreaCount()
            {
                area = a*a*Math.Sin(alpha);
            }
        } //сторона и угол
        public task2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox textBox1 = new TextBox();
            textBox1.Top = 150;
            textBox1.Left = 70;
            this.Controls.Add(textBox1);
            textBox1.BringToFront();
            TextBox textBox2 = new TextBox();
            textBox2.Top = 150;
            textBox2.Left = 220;
            this.Controls.Add(textBox2);
            textBox2.BringToFront();
            TextBox textBox3 = new TextBox();
            textBox3.Top = 150;
            textBox3.Left = 370;
            this.Controls.Add(textBox3);
            textBox3.BringToFront();

            Button newbtn = new Button();
            newbtn.Location = new Point(70, 180);
            newbtn.Name = "newbtn";
            newbtn.Size = new Size(80, 35);
            newbtn.TabIndex = 3;
            newbtn.Text = "Calculate Perimeter";
            newbtn.UseVisualStyleBackColor = true;
            newbtn.Click += new EventHandler(newbtn_Click);
            Controls.Add(newbtn);
            newbtn.BringToFront();
            void newbtn_Click(object sender1, EventArgs e1)
            {
                try
                {
                    double side1 = Convert.ToDouble(textBox1.Text);
                    double side2 = Convert.ToDouble(textBox2.Text);
                    double side3 = Convert.ToDouble(textBox3.Text);
                    Triangle tr1 = new Triangle(side1, side2, side3);
                    tr1.PerimeterCount();
                    MessageBox.Show("Triangle perimeter is " + tr1.perimeter.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
                
            }

            Button newbtn1 = new Button();
            newbtn1.Location = new Point(70, 220);
            newbtn1.Name = "newbtn";
            newbtn1.Size = new Size(80, 35);
            newbtn1.TabIndex = 3;
            newbtn1.Text = "Calculate Area";
            newbtn1.UseVisualStyleBackColor = true;
            newbtn1.Click += new EventHandler(newbtn_Click1);
            Controls.Add(newbtn1);
            newbtn1.BringToFront();
            void newbtn_Click1(object sender1, EventArgs e1)
            {
                try
                {
                    double side1 = Convert.ToDouble(textBox1.Text);
                    double side2 = Convert.ToDouble(textBox2.Text);
                    double side3 = Convert.ToDouble(textBox3.Text);
                    Triangle tr1 = new Triangle(side1, side2, side3);
                    tr1.AreaCount();
                    MessageBox.Show("Triangle area is " + tr1.area.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBox textBox1 = new TextBox();
            textBox1.Top = 150;
            textBox1.Left = 70;
            this.Controls.Add(textBox1);
            textBox1.BringToFront();

            Button newbtn = new Button();
            newbtn.Location = new Point(70, 180);
            newbtn.Name = "newbtn";
            newbtn.Size = new Size(80, 35);
            newbtn.TabIndex = 3;
            newbtn.Text = "Calculate Perimeter";
            newbtn.UseVisualStyleBackColor = true;
            newbtn.Click += new EventHandler(newbtn_Click);
            Controls.Add(newbtn);
            newbtn.BringToFront();
            void newbtn_Click(object sender1, EventArgs e1)
            {
                try
                {
                    double side1 = Convert.ToDouble(textBox1.Text);
                    Circle c1 = new Circle(side1);
                    c1.PerimeterCount();
                    MessageBox.Show("Circle perimeter is " + c1.perimeter.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }

            }

            Button newbtn1 = new Button();
            newbtn1.Location = new Point(70, 220);
            newbtn1.Name = "newbtn";
            newbtn1.Size = new Size(80, 35);
            newbtn1.TabIndex = 3;
            newbtn1.Text = "Calculate Area";
            newbtn1.UseVisualStyleBackColor = true;
            newbtn1.Click += new EventHandler(newbtn_Click1);
            Controls.Add(newbtn1);
            newbtn1.BringToFront();
            void newbtn_Click1(object sender1, EventArgs e1)
            {
                try
                {
                    double side1 = Convert.ToDouble(textBox1.Text);
                    Circle c1 = new Circle(side1);
                    c1.AreaCount();
                    MessageBox.Show("Circle area is " + c1.area.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox textBox1 = new TextBox();
            textBox1.Top = 150;
            textBox1.Left = 70;
            this.Controls.Add(textBox1);
            textBox1.BringToFront();
            TextBox textBox2 = new TextBox();
            textBox2.Top = 150;
            textBox2.Left = 220;
            this.Controls.Add(textBox2);
            textBox2.BringToFront();

            Button newbtn = new Button();
            newbtn.Location = new Point(70, 180);
            newbtn.Name = "newbtn";
            newbtn.Size = new Size(80, 35);
            newbtn.TabIndex = 3;
            newbtn.Text = "Calculate Perimeter";
            newbtn.UseVisualStyleBackColor = true;
            newbtn.Click += new EventHandler(newbtn_Click);
            Controls.Add(newbtn);
            newbtn.BringToFront();
            void newbtn_Click(object sender1, EventArgs e1)
            {
                try
                {
                    double side1 = Convert.ToDouble(textBox1.Text);
                    double side2 = Convert.ToDouble(textBox2.Text);
                    Rectangle rec1 = new Rectangle(side1, side2);
                    rec1.PerimeterCount();
                    MessageBox.Show("Rectangle perimeter is " + rec1.perimeter.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }

            }

            Button newbtn1 = new Button();
            newbtn1.Location = new Point(70, 220);
            newbtn1.Name = "newbtn";
            newbtn1.Size = new Size(80, 35);
            newbtn1.TabIndex = 3;
            newbtn1.Text = "Calculate Area";
            newbtn1.UseVisualStyleBackColor = true;
            newbtn1.Click += new EventHandler(newbtn_Click1);
            Controls.Add(newbtn1);
            newbtn1.BringToFront();
            void newbtn_Click1(object sender1, EventArgs e1)
            {
                try
                {
                    double side1 = Convert.ToDouble(textBox1.Text);
                    double side2 = Convert.ToDouble(textBox2.Text);
                    Rectangle rec1 = new Rectangle(side1, side2);
                    rec1.AreaCount();
                    MessageBox.Show("Rectangle area is " + rec1.area.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBox textBox1 = new TextBox();
            textBox1.Top = 150;
            textBox1.Left = 70;
            this.Controls.Add(textBox1);
            textBox1.BringToFront();

            Button newbtn = new Button();
            newbtn.Location = new Point(70, 180);
            newbtn.Name = "newbtn";
            newbtn.Size = new Size(80, 35);
            newbtn.TabIndex = 3;
            newbtn.Text = "Calculate Perimeter";
            newbtn.UseVisualStyleBackColor = true;
            newbtn.Click += new EventHandler(newbtn_Click);
            Controls.Add(newbtn);
            newbtn.BringToFront();
            void newbtn_Click(object sender1, EventArgs e1)
            {
                try
                {
                    double side1 = Convert.ToDouble(textBox1.Text);
                    Square sq1 = new Square(side1);
                    sq1.PerimeterCount();
                    MessageBox.Show("Square perimeter is " + sq1.perimeter.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }

            }

            Button newbtn1 = new Button();
            newbtn1.Location = new Point(70, 220);
            newbtn1.Name = "newbtn";
            newbtn1.Size = new Size(80, 35);
            newbtn1.TabIndex = 3;
            newbtn1.Text = "Calculate Area";
            newbtn1.UseVisualStyleBackColor = true;
            newbtn1.Click += new EventHandler(newbtn_Click1);
            Controls.Add(newbtn1);
            newbtn1.BringToFront();
            void newbtn_Click1(object sender1, EventArgs e1)
            {
                try
                {
                    double side1 = Convert.ToDouble(textBox1.Text);
                    Square sq1 = new Square(side1);
                    sq1.AreaCount();
                    MessageBox.Show("Square area is " + sq1.area.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBox textBox1 = new TextBox();
            textBox1.Top = 150;
            textBox1.Left = 70;
            this.Controls.Add(textBox1);
            textBox1.BringToFront();
            TextBox textBox2 = new TextBox();
            textBox2.Top = 150;
            textBox2.Left = 220;
            this.Controls.Add(textBox2);
            textBox2.BringToFront();

            Button newbtn = new Button();
            newbtn.Location = new Point(70, 180);
            newbtn.Name = "newbtn";
            newbtn.Size = new Size(80, 35);
            newbtn.TabIndex = 3;
            newbtn.Text = "Calculate Perimeter";
            newbtn.UseVisualStyleBackColor = true;
            newbtn.Click += new EventHandler(newbtn_Click);
            Controls.Add(newbtn);
            newbtn.BringToFront();
            void newbtn_Click(object sender1, EventArgs e1)
            {
                try
                {
                    double side = Convert.ToDouble(textBox1.Text);
                    double angle = Convert.ToDouble(textBox2.Text);
                    Rhomb rh1 = new Rhomb(side, angle);
                    rh1.PerimeterCount();
                    MessageBox.Show("Rhomb perimeter is " + rh1.perimeter.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }

            }

            Button newbtn1 = new Button();
            newbtn1.Location = new Point(70, 220);
            newbtn1.Name = "newbtn";
            newbtn1.Size = new Size(80, 35);
            newbtn1.TabIndex = 3;
            newbtn1.Text = "Calculate Area";
            newbtn1.UseVisualStyleBackColor = true;
            newbtn1.Click += new EventHandler(newbtn_Click1);
            Controls.Add(newbtn1);
            newbtn1.BringToFront();
            void newbtn_Click1(object sender1, EventArgs e1)
            {
                try
                {
                    double side = Convert.ToDouble(textBox1.Text);
                    double angle = Convert.ToDouble(textBox2.Text);
                    Rhomb rh1 = new Rhomb(side, angle);
                    rh1.AreaCount();
                    MessageBox.Show("Rhomb area is " + rh1.area.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Application.Exit();
                }
            }
        }
    }
}
