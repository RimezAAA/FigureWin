using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Figure2;

namespace FigureWin
{
    public partial class Figure : Form
    {
        Graphics g;
        string click = "";
        Bitmap bmp;
        Figires figures;
        System.Drawing.Point[] clickMouse = new System.Drawing.Point[3];
        int countClickMouse;
        Pen color = new Pen(Color.Black, 3);
        int x, y, sX, sY, cX, cY;
        public Figure()
        {
            InitializeComponent();
            bmp = new Bitmap(DrawField.Size.Width, DrawField.Size.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            DrawField.Image = bmp;
            figures = new Figires(g);
        }

        private void DrawField_MouseDown(object sender, MouseEventArgs e)
        {
            cX = e.X;
            cY = e.Y;
        }

        private void DrawField_MouseMove(object sender, MouseEventArgs e)
        {
            DrawField.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void DrawField_MouseUp(object sender, MouseEventArgs e)
        {
            sX = x - cX;
            sY = y - cY;

            switch (click)
            {
                case "ellipse":
                    figures.Add(new Ellipse(g, color, cX, cY, sX, sY));
                    break;
                case "rectangle":
                    figures.Add(new Figure2.Rectangle(g, color, cX, cY, sX, sY));
                    break;
                case "line":
                    figures.Add(new Line(g, color, cX, cY, e.X, e.Y));
                    break;
                case "triangleTwoPoints":
                    figures.Add(new Triangle(g, color, cX, cY, e.X, e.Y, cX - (e.X-cX), e.Y));
                    break;
            }
        }

        private void DrawField_MouseClick(object sender, MouseEventArgs e)
        {
            switch (click)
            {
                case "circle":
                    if (radiusCircle.Text != String.Empty)
                        figures.Add(new Circle(g, color, e.X, e.Y, int.Parse(radiusCircle.Text)));
                    else MessageBox.Show("Заполните радиус");
                    break;
                case "triangleThreePoints":
                    clickMouse[countClickMouse] = e.Location;
                    ++countClickMouse;
                    if (countClickMouse % 3 == 0 && countClickMouse != 0)
                    {
                        figures.Add(new Triangle(g, color, clickMouse[0].X, clickMouse[0].Y, clickMouse[1].X, clickMouse[1].Y, clickMouse[2].X, clickMouse[2].Y));
                        countClickMouse = 0;
                    }
                    break;
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            figures.Save(filename);
        }
        private void Load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            figures.Load(filename);
        }



        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = new Pen(colorDialog1.Color, 3);
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        

        private void visible()
        {
            if (click == "circle")
            {
                this.radiusCircle.Visible = true;
                this.radiusLabel.Visible = true;
            }
            else
            {
                this.radiusCircle.Visible = false;
                this.radiusLabel.Visible = false;
            }
            if (click == "triangle" || click == "triangleTwoPoints" || click == "triangleThreePoints")
            {
                this.buttonTriangleThreePoints.Visible = true;
                this.buttonTriangleTwoPoints.Visible = true;
            }
            else
            {
                this.buttonTriangleThreePoints.Visible = false;
                this.buttonTriangleTwoPoints.Visible = false;
            }
        }
        private void radiusCircle_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }
        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            click = "rectangle";
            visible();
        }
        private void buttonCircle_Click(object sender, EventArgs e)
        {
            click = "circle";
            visible();
        }
        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            click = "ellipse";
            visible();

        }
        private void buttonLine_Click(object sender, EventArgs e)
        {
            click = "line";
            visible();
        }
        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            click = "triangle";
            visible();
        }
        private void buttonTriangleTwoPoints_Click(object sender, EventArgs e)
        {
            click = "triangleTwoPoints";
            visible();
        }
        private void buttonTriangleThreePoints_Click(object sender, EventArgs e)
        {
            click = "triangleThreePoints";
            visible();
        }
    }
}
