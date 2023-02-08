using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Aquarium
{
    public abstract class Fish : Sprite
    {
        public Vector VSpeed { get => Direction.GetE() * Speed; }
        public Vector Direction { get; set; }
        public int Speed { get; set; }
        protected Fish(Point location, Size size, Image image) : base(location, size, image)
        {
        }
        public virtual void Draw()
        {

        }
        public void Look()
        {
            
        }
        public void Run()
        {
            X += (int)VSpeed.X;
            Y += (int)VSpeed.Y;
        }

    }
}