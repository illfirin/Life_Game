using System;

namespace LifeGame
{
    public class LifeHelper
    {
        public LifeHelper() { }
        //returns true if cell going to be alive in the next generation
        public static bool IsAlive(int[,] current, int x_cord, int y_cord)
        {
            int count = LifeHelper.CountNeighbours(current, x_cord, y_cord);
            return current[y_cord, x_cord] != 0 && (count < 2 || count > 3) ? false :
                 (current[y_cord, x_cord] == 0 && count == 3 ? true : false);
        }
        //count neighbours of cell at concrete position
        public static int CountNeighbours(int[,] world, int x_cord, int y_cord)
        {
            if (IsOutOfBounds(world, y_cord, x_cord))
                throw new ArgumentOutOfRangeException("Cordinates must be non-negative!");
            int count = 0;

            for (var j = y_cord - 1; j < y_cord + 2; ++j)
                for (var i = x_cord - 1; i < x_cord + 2; ++i)
                    if (!IsOutOfBounds(world, j, i))
                        count += world[j, i];

            return count - world[y_cord, x_cord];
        }

        public static bool IsOutOfBounds(int[,] world, int y, int x)
        {
            int rows = world.GetUpperBound(0) + 1;
            int collums = world.Length / rows;
            return y < 0 || y > collums || x < 0 || x > rows;
        }
    }
}
