﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Simple_Paint
{
    public class RightTriangle : Triangle
    {
        public RightTriangle(Point start, Point end, Color color, Color fillColor, float penWidth) : base(color, fillColor, penWidth)
        {
            Point vertex1 = new Point(start.X, start.Y);
            Point vertex2 = new Point(end.X, end.Y);
            Point vertex3 = new Point(start.X, end.Y);

            vertices = new Point[3] { vertex1, vertex2, vertex3 };
        }

        public RightTriangle(Color color, Color fillColor, float penWidth) : base(color, fillColor, penWidth) { }

        public override void Draw(Graphics graphics, Point start, Point end)
        {
            Point vertex1 = new Point(start.X, start.Y);
            Point vertex2 = new Point(end.X, end.Y);
            Point vertex3 = new Point(start.X, end.Y);

            vertices = new Point[3] { vertex1, vertex2, vertex3 };

            graphics.FillPolygon(brush, vertices);
            graphics.DrawPolygon(pen, vertices);
        }
    }
}
