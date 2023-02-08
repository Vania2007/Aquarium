using Aquarium.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Aquarium
{
    public class Pike : Fish
    {
        public Pike(Point location, Size size, Image image) : base(location, size, image)
        {
            image = Resources.Pike;
        }
        List<Pike> pikes = new List<Pike>();
       
    }
}
