using Aquarium.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aquarium
{
    public class Aquarium
    {
        private static readonly Random random = new Random();
        public Aquarium(Control container, int numOfPikes, int numOfCarps)
        {
            Container = container;
            Graphics = container.CreateGraphics();

            for (int i = 0; i < numOfCarps; i++)
            {
                var rect = GetRectangle(container); ;
                Carps.Add(new Carp(rect.Location, rect.Size));
                Sprites.Add(Carps[i]);
            }
            for (int i = 0; i < numOfPikes; i++)
            {
                var rect = GetRectangle(container); ;
                Pikes.Add(new Pike(rect.Location, rect.Size));
                Sprites.Add(Pikes[i]);
            }
        }
        public void Update()
        {
            Graphics.Clear(Color.LightBlue);
            foreach (var sprite in Sprites)
            {
                if (sprite is Fish fish)
                {
                    fish.Run();
                }
                sprite.Draw(Graphics);
            }
        }

        private static Rectangle GetRectangle(Control container)
        {
            int w = random.Next(50, 200);
            int x = random.Next(container.Width - w);
            int y = random.Next(container.Height - w / 2);
            return new Rectangle(x, y, w, w / 2);
        }

        public Flock Carps { get; } = new Flock();
        public Flock Pikes { get; } = new Flock();
        public List<Sprite> Sprites { get; } = new List<Sprite>();
        public Graphics Graphics { get; }
        public Control Container { get; private set; }

    }
}
