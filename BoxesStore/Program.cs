using System;

namespace BoxesStore
{
    class Program
    {
        public static void Main(string[] args)
        {
            var repository = new BoxesRepository();
            var box1 = new Box
            {
                Height = 10,
                Length = 20,
                Width = 30,
                Colour = "red"
            };
            var box2 = new Box
            {
                Height = 10,
                Length = 20,
                Width = 30,
                Colour = "yellow"
            };
            
            // Soft search
            Console.WriteLine(repository.Exists(box1));  // Output: True
            Console.WriteLine(repository.Exists(box2));  // Output: True
            
            // Strict search
            var comparer = new StrictEqualityComparer();
            Console.WriteLine(repository.Exists(box1, comparer));  // Output: True
            Console.WriteLine(repository.Exists(box2, comparer));  // Output: False

        }
    }
}