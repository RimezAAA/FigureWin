using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace Figure2
{
    class Figires
    {
        List<Figure> figures;
        Graphics g;
        public Figires(Graphics g)
        {
            figures = new List<Figure>();
            this.g = g;
        }

        public void Add(Figure figure)
        {
            figures.Add(figure);
        }

        public void Save(string path)
        {
            StreamWriter sw = new StreamWriter(path, false);
            try
            {
                sw.WriteLine(figures.Count);
                foreach (Figure f in figures)
                {
                    sw.WriteLine($"{f.GetInfo()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                sw.Close();
            }
        }

        public void Load(string path)
        {
            StreamReader sr = new StreamReader(path);
            try
            {
                int count = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    var s = sr.ReadLine().Split();
                    switch (s[0])
                    {
                        case "line":
                            figures.Add(new Line(g, new Pen(Color.FromArgb(Convert.ToInt32(s[5])), Convert.ToInt32(s[6])), Convert.ToInt32(s[1]), Convert.ToInt32(s[2]), Convert.ToInt32(s[3]), Convert.ToInt32(s[4])));
                            break;
                        case "triangle":
                            figures.Add(new Triangle(g, new Pen(Color.FromArgb(Convert.ToInt32(s[7])), Convert.ToInt32(s[8])), Convert.ToInt32(s[1]), Convert.ToInt32(s[2]), Convert.ToInt32(s[3]), Convert.ToInt32(s[4]), Convert.ToInt32(s[5]), Convert.ToInt32(s[6])));
                            break;
                        case "circle":
                            figures.Add(new Circle(g, new Pen(Color.FromArgb(Convert.ToInt32(s[4])), Convert.ToInt32(s[5])), Convert.ToInt32(s[1]), Convert.ToInt32(s[2]), Convert.ToInt32(s[3])));
                            break;
                        case "rectangle":
                            figures.Add(new Rectangle(g, new Pen(Color.FromArgb(Convert.ToInt32(s[5])), Convert.ToInt32(s[6])), Convert.ToInt32(s[1]), Convert.ToInt32(s[2]), Convert.ToInt32(s[3]), Convert.ToInt32(s[4])));
                            break;
                        case "ellipse":
                            figures.Add(new Ellipse(g, new Pen(Color.FromArgb(Convert.ToInt32(s[5])), Convert.ToInt32(s[6])), Convert.ToInt32(s[1]), Convert.ToInt32(s[2]), Convert.ToInt32(s[3]), Convert.ToInt32(s[4])));
                            break;
                    }
                }
                this.Draw();
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception: " + ex.Message);
            }
            finally
            {
                sr.Close();
            }
        }


        public void Draw()
        {
            foreach(var f in figures)
            {
                f.Draw();
            }
        }
    }
}