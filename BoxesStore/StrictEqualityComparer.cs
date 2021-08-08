using System.Collections.Generic;

namespace BoxesStore
{
    public class StrictEqualityComparer : IEqualityComparer<Box>
    {
        public bool Equals(Box x, Box y)
        {
            return x == y && x.Colour == y.Colour;
        }

        public int GetHashCode(Box box)
        {
            var h = box.Height ^ box.Length ^ box.Width ^ box.Colour.GetHashCode();
            return h.GetHashCode();
        }
    }
}