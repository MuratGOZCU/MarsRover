
using MarsRover.Core.Infrastructure;

namespace MarsRover.Core.Model
{
    public class Grid : IPlateau
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Grid(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }


    }
}
