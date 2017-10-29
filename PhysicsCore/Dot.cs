using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PhysicsCore {
    public class Dot {
        public Point p = new Point(0, 0);
        public Color c = Color.FromArgb(255, 255, 255);
        public Shape shape = Shape.Rect;
        public FillMode fillMode = FillMode.Empty;
        public Size s = new Size(5, 5);
        public string UUID;
        public enum Shape {
            Rect = 0,
            Round = 1
        }
        public enum FillMode {
            Empty = 0,
            Filled = 1
        }
        public Dot(Point p, Color c, Size s, Shape shape, FillMode fillMode) {
            this.p = p;
            this.c = c;
            this.s = s;
            this.shape = shape;
            this.fillMode = fillMode;
            this.UUID = Guid.NewGuid().ToString();
        }
        public Dot Clone(object newValue = null) {
            if (newValue == null) {
                return new Dot(p, c, s, shape, fillMode);
            }
            Type t = newValue.GetType();
            if (t == typeof(Point)) {
                return new Dot((Point)newValue, c, s, shape, fillMode);
            } else if (t == typeof(Color)) {
                return new Dot(p, (Color)newValue, s, shape, fillMode);
            } else if (t == typeof(Size)) {
                return new Dot(p, c, (Size)newValue, shape, fillMode);
            } else if (t == typeof(Shape)) {
                return new Dot(p, c, s, (Shape)newValue, fillMode);
            } else {
                // We can't create a new Dot so return a copy of this one.
                return new Dot(p, c, s, shape, fillMode);
            }
        }
        public void Draw(Graphics g) {
            Pen pen = new Pen(c);
            if (fillMode == FillMode.Empty) {
                if (shape == Shape.Rect) {
                    g.DrawRectangle(pen, new Rectangle(p.X, p.Y, s.Width, s.Height));
                } else if (shape == Shape.Round) {
                    g.DrawEllipse(pen, new Rectangle(p.X, p.Y, s.Width, s.Height));
                }
            } else if (fillMode == FillMode.Filled) {
                if (shape == Shape.Rect) {
                    g.FillRectangle(pen.Brush, new Rectangle(p.X, p.Y, s.Width, s.Height));
                } else if (shape == Shape.Round) {
                    g.FillEllipse(pen.Brush, new Rectangle(p.X, p.Y, s.Width, s.Height));
                }
            }
        }
    }
}
