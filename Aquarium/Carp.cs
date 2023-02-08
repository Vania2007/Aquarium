using Aquarium.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Aquarium
{
    class Carp : Fish
    {
        public Carp(Point location, Size size, Image image) : base(location, size, image)
        {
            image = Resources.Karp;
        }
        List<Carp> carps = new List<Carp>();
    }
}
