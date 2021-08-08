using System;

namespace BoxesStore
{
    public class Box : IEquatable<Box>
    {
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Box) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Height, Length, Width, Colour);
        }

        public int Height { get; init; }
        
        public int Length { get; init; }
        
        public int Width { get; init; }

        public string Colour { get; init; }
        
        public static bool operator == (Box obj1, Box obj2)
        {
            return ReferenceEquals(obj1, obj2) || obj1.Equals(obj2);
        }

        public static bool operator !=(Box obj1, Box obj2)
        {
            return !(obj1 == obj2);
        }
        public bool Equals(Box other)
        {
            return Width == other.Width && Height == other.Height && Width == other.Width;
        }
    }
}