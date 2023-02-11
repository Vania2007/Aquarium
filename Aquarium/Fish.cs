using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Aquarium
{
    public abstract class Fish : Sprite
    {
        private static readonly Random random = new Random();
        public Vector VSpeed { get => Direction.GetE() * Speed; }
        public Vector Direction { get; set; } = new Vector();
        private int speed;
        public int Speed
        {
            get => speed;
            set
            {
                if (value < 0) throw new Exception("Speed must be higher or equal to zero");
                speed = value;
            }
        }
        protected Fish(Point location, Size size, Image image) : base(location, size, image)
        {
            Speed = random.Next(5, 10);
            double angle = random.Next(360);
            Direction = new Vector(angle, speed);
        }

        public bool Look(Sprite[] others)
        {
            for (int i = 0; i < 5; i++)
            {
                foreach (var sprite in others)
                {
                    if (sprite == this) continue;
                    Vector adding = VSpeed * i;
                    Point potntialLocation = new Point(X + (int)adding.X, Y + (int)adding.Y);
                    if (sprite.IsInto(potntialLocation))
                        return true;
                }
            }
            return false;
        }
        public void PutToFreeDirection(Sprite[] others)
        {
            for (double angle = 0; angle < 360; angle += 5)
            {
                Direction.Rotate(angle);
                if (!Look(others))
                {
                    return;
                }
            }
        }

        public void Run(Sprite[] others)
        {
            PutToFreeDirection(others);
            Run();
        }

        public void Run()
        {
            X += (int)VSpeed.X;
            Y += (int)VSpeed.Y;
            if (random.Next(100) == 1)
                Direction.Rotate(random.Next(360));
        }

    }
}