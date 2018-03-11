﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Paint
{
    public partial class MainWindow : Form
    {
        private Graphics graphics;
        private ListOfShapes listOfShapes;

        public MainWindow()
        {
            InitializeComponent();

            graphics = CreateGraphics(pictureBox.Width, pictureBox.Height);
            listOfShapes = new ListOfShapes();

            DrawShapes();
        }

        private Graphics CreateGraphics(int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height);
            pictureBox.Image = bitmap;
            return Graphics.FromImage(bitmap);
        }

        private void DrawShapes()
        {
            Line line = new Line(50, 50, 400, 200, Color.Chocolate, 8);
            listOfShapes.Add(line);

            Ellipse ellipse = new Ellipse(535, 410, 1100, 20, Color.Purple, Color.Red, 2);
            listOfShapes.Add(ellipse);

            Rectangle rectangle = new Rectangle(432, 52, 600, 240, Color.BlueViolet, Color.IndianRed, 5);
            listOfShapes.Add(rectangle);

            IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(400, 100, 200, 300, Color.BlueViolet, Color.IndianRed, 1);
            listOfShapes.Add(isoscelesTriangle);

            RightTriangle rightTriangle = new RightTriangle(30, 500, 200, 300, Color.Blue, Color.Blue, 1);
            listOfShapes.Add(rightTriangle);

            listOfShapes.Draw(graphics);
        }
    }
}
