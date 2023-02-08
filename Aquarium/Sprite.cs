using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Aquarium
{
    public abstract class Sprite
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point Location
        { 
            get => new Point(X, Y);
            set 
            { X = value.X;
              Y = value.Y;
            }
        }
        public Size Size { get; set; } = new Size();
        public int Width { get => Size.Width; }
        public int Height { get => Size.Height; }
        public Image Image { get; set; }

        protected Sprite(Point location, Size size, Image image)
        {
            X = location.X;
            Y = location.Y;
            Size = size;
            Image = image;
        }
    }
}
