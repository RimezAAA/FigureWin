namespace FigureWin
{
    partial class Figure
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Figure));
            this.DrawField = new System.Windows.Forms.PictureBox();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.Load = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.widthLine = new System.Windows.Forms.TrackBar();
            this.buttonTriangleTwoPoints = new System.Windows.Forms.Button();
            this.buttonTriangleThreePoints = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.radiusCircle = new System.Windows.Forms.TextBox();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DrawField)).BeginInit();
            this.menu.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthLine)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawField
            // 
            this.DrawField.Location = new System.Drawing.Point(0, 72);
            this.DrawField.Name = "DrawField";
            this.DrawField.Size = new System.Drawing.Size(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width, System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Height);
            this.DrawField.TabIndex = 0;
            this.DrawField.TabStop = false;
            this.DrawField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrawField_MouseClick);
            this.DrawField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawField_MouseDown);
            this.DrawField.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawField_MouseMove);
            this.DrawField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawField_MouseUp);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("buttonEllipse.Image")));
            this.buttonEllipse.Location = new System.Drawing.Point(3, 0);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(83, 49);
            this.buttonEllipse.TabIndex = 1;
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save,
            this.Load});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1534, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(43, 20);
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(45, 20);
            this.Load.Text = "Load";
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.buttonClear);
            this.panel.Controls.Add(this.widthLine);
            this.panel.Controls.Add(this.buttonTriangleTwoPoints);
            this.panel.Controls.Add(this.buttonTriangleThreePoints);
            this.panel.Controls.Add(this.buttonTriangle);
            this.panel.Controls.Add(this.buttonLine);
            this.panel.Controls.Add(this.buttonRectangle);
            this.panel.Controls.Add(this.radiusLabel);
            this.panel.Controls.Add(this.radiusCircle);
            this.panel.Controls.Add(this.buttonCircle);
            this.panel.Controls.Add(this.buttonColor);
            this.panel.Controls.Add(this.buttonEllipse);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1534, 49);
            this.panel.TabIndex = 3;
            // 
            // widthLine
            // 
            this.widthLine.Location = new System.Drawing.Point(615, 2);
            this.widthLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.widthLine.Minimum = 1;
            this.widthLine.Name = "widthLine";
            this.widthLine.Size = new System.Drawing.Size(136, 45);
            this.widthLine.TabIndex = 11;
            this.widthLine.Value = 3;
            this.widthLine.Scroll += new System.EventHandler(this.widthLine_Scroll);
            // 
            // buttonTriangleTwoPoints
            // 
            this.buttonTriangleTwoPoints.Location = new System.Drawing.Point(491, 22);
            this.buttonTriangleTwoPoints.Name = "buttonTriangleTwoPoints";
            this.buttonTriangleTwoPoints.Size = new System.Drawing.Size(100, 23);
            this.buttonTriangleTwoPoints.TabIndex = 10;
            this.buttonTriangleTwoPoints.Text = "2 точки";
            this.buttonTriangleTwoPoints.UseVisualStyleBackColor = true;
            this.buttonTriangleTwoPoints.Visible = false;
            this.buttonTriangleTwoPoints.Click += new System.EventHandler(this.buttonTriangleTwoPoints_Click);
            // 
            // buttonTriangleThreePoints
            // 
            this.buttonTriangleThreePoints.Location = new System.Drawing.Point(491, 0);
            this.buttonTriangleThreePoints.Name = "buttonTriangleThreePoints";
            this.buttonTriangleThreePoints.Size = new System.Drawing.Size(100, 23);
            this.buttonTriangleThreePoints.TabIndex = 9;
            this.buttonTriangleThreePoints.Text = "3 точки";
            this.buttonTriangleThreePoints.UseVisualStyleBackColor = true;
            this.buttonTriangleThreePoints.Visible = false;
            this.buttonTriangleThreePoints.Click += new System.EventHandler(this.buttonTriangleThreePoints_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTriangle.Image")));
            this.buttonTriangle.Location = new System.Drawing.Point(257, 0);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(49, 49);
            this.buttonTriangle.TabIndex = 8;
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Image = ((System.Drawing.Image)(resources.GetObject("buttonLine.Image")));
            this.buttonLine.Location = new System.Drawing.Point(202, 0);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(49, 49);
            this.buttonLine.TabIndex = 7;
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonRectangle.Image")));
            this.buttonRectangle.Location = new System.Drawing.Point(147, 0);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(49, 49);
            this.buttonRectangle.TabIndex = 6;
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(493, 5);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(45, 15);
            this.radiusLabel.TabIndex = 5;
            this.radiusLabel.Text = "Radius:";
            this.radiusLabel.Visible = false;
            // 
            // radiusCircle
            // 
            this.radiusCircle.Location = new System.Drawing.Point(491, 23);
            this.radiusCircle.Name = "radiusCircle";
            this.radiusCircle.Size = new System.Drawing.Size(100, 23);
            this.radiusCircle.TabIndex = 4;
            this.radiusCircle.Visible = false;
            this.radiusCircle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radiusCircle_KeyPress);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Image = ((System.Drawing.Image)(resources.GetObject("buttonCircle.Image")));
            this.buttonCircle.Location = new System.Drawing.Point(92, 0);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(49, 49);
            this.buttonCircle.TabIndex = 3;
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.White;
            this.buttonColor.Location = new System.Drawing.Point(444, 4);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(41, 40);
            this.buttonColor.TabIndex = 2;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(757, 19);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Figure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 717);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.DrawField);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "Figure";
            this.Text = "Figure";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DrawField)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widthLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DrawField;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.ToolStripMenuItem Load;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.TextBox radiusCircle;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonTriangleTwoPoints;
        private System.Windows.Forms.Button buttonTriangleThreePoints;
        private System.Windows.Forms.TrackBar widthLine;
        private System.Windows.Forms.Button buttonClear;
    }
}
