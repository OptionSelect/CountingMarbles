using System;

namespace CountingMarbles
{
    class Program
    {
        public class MarbleBag
        {
            public int RedMarbles { get; set; } = 0;
            public int GreenMarbles { get; set; } = 0;
            public int BlueMarbles { get; set; } = 0;

            public MarbleBag(int redMarbles, int greenMarbles, int blueMarbles)
            {
                RedMarbles = redMarbles;
                BlueMarbles = blueMarbles;
                GreenMarbles = greenMarbles;
            }

            public int getTotalNumberofMarbles() => RedMarbles + GreenMarbles + BlueMarbles;

            public int removeAllGreenMarbles() => GreenMarbles = 0;

            public override string ToString()
            {
                return $"Reds: {RedMarbles}, Greens: {GreenMarbles}, Blues: {BlueMarbles}";
            }
        }
        static void Main(string[] args)
        {
            var marbleBag = new MarbleBag(3, 1, 2);

            Console.WriteLine(marbleBag);

            marbleBag.BlueMarbles = 5;

            var total = marbleBag.getTotalNumberofMarbles();
            Console.WriteLine($"The total number of marbles is: {total}.");

            marbleBag.removeAllGreenMarbles();
            total = marbleBag.getTotalNumberofMarbles();
            Console.WriteLine($"New Total Without Green Marbles: {total}.");

        }
    }
}
