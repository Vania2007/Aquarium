using Aquarium.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Aquarium
{
    class Carp : Fish
    {
        public Carp(Point location, Size size) : base(location, size, Resources.Karp)
        {
        }
    }
}
