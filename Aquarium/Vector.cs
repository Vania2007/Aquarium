using System;
using System.Collections.Generic;
using System.Text;

namespace Aquarium
{
    public class Vector
    {
        
        public Vector(double x = 0, double y = 0)
        {
            X = x;
            Y = y;
        }
        public void Rotate(double angle)
        {
            double cos = Math.Cos(angle);
            double sin = Math.Sin(angle);
            double nextX = X * cos - Y * sin;
            double nextY = X * sin + Y * cos;
            X = nextX; Y = nextY;
        }
        public double X { get; set; }

        public double Y { get; set; }

        public double GetLength()
        {
            return Math.Sqrt(SqLength);
        }
        
        public double SqLength
        {
            get => this * this;
        }

        public Vector Normal
        {
            get => new Vector(-Y, X);
        }

        public static Vector operator+(Vector a,Vector b)
        {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }

        public static Vector operator-(Vector v)
        {
            return new Vector(-v.X, -v.Y);
        }

        public static Vector operator-(Vector a, Vector b)
        {
            return a + (-b);
        }

        public static Vector operator *(double c, Vector v) 
        {
            return new Vector(c * v.X, c * v.Y);
        }

        public static Vector operator/(Vector v, double c)
        {
            return v * (1 / c);
        }
        public static Vector operator*(Vector v, double c)
        {
            return c * v;
        }
        public static double operator*(Vector a, Vector b)
        {
            return DotProduct(a,b);
        }

        public Vector GetE() => this / GetLength();

        public Vector Projection(Vector OnVector) => (this * OnVector) / OnVector.SqLength * OnVector;

        public Vector Mirror(Vector v) => this - 2 * this.Projection(v.Normal);
        
        public void HorizontalBounce()
        {
            Y = -Y;
        }
        public void VerticalBounce()
        {
            X = -X;
        }
        
        public Vector Sum(Vector other)
        {
            return new Vector(X + other.X, Y + other.Y);
        }

        public Vector Mnoj(Vector other)
        {
            return new Vector(X * other.X, Y * other.Y); 
        }

        public static double DotProduct(Vector a,Vector b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
        public override bool Equals(object obj)
        {
            return obj is Vector && this.Equals((Vector)obj);
        }
        public bool Equals(Vector v)
        {
            return v.X==X&&v.Y==Y;
        }
        public override string ToString()
        {
            return $"({X}; {Y})";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
