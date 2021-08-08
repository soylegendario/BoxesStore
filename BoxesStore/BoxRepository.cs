using System.Collections.Generic;
using System.Linq;

namespace BoxesStore
{
    public class BoxesRepository
    {
        /// <summary>
        /// Simulate box table
        /// </summary>
        private static IEnumerable<Box> Boxes => new[]
        {
            new Box { Height = 10, Length = 20, Width = 30, Colour = "red" },
            new Box { Height = 20, Length = 20, Width = 20, Colour = "red" },
        };

        /// <summary>
        /// Find a box in the repository (soft search)
        /// </summary>
        /// <param name="box"></param>
        /// <returns></returns>
        public bool Exists(Box box)
        {
            return Boxes.Contains(box);
        }

        /// <summary>
        /// Find a box in the repository (strict search)
        /// </summary>
        /// <param name="box"></param>
        /// <param name="equalityComparer"></param>
        /// <returns></returns>
        public bool Exists(Box box, IEqualityComparer<Box> equalityComparer)
        {
            return Boxes.Contains(box, equalityComparer);
        }
    }
}