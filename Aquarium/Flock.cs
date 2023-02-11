using System;
using System.Collections.Generic;
using System.Text;

namespace Aquarium
{
    internal class Flock
    {
        private List<Fish> fishes = new List<Fish>();
        public Fish this[int number]
        {
            get => fishes[number];
            set => fishes[number] = value;
        }
        public void Add(Fish fish)
        {
            fishes.Add(fish);
        }
    }
}
