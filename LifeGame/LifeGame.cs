/*
**            Conway's Game of ife(Cellural automata)
**            Conditions: cell has 8 neighbours, they can be weither dead or alive(0, 1);
**            World starts with random resettlement of live and dead cells. After that life and dead depend on
**            number of neighbours.
**            
**            Conditions:
**            if cell is alive:
**            <2 or >3 neighbours -> death
**            2|3 neighbours -> life
**            if cell is dead 
**            3 neighbours -> life
**            
**            Start screen with button on it 
**            
**            Create a new window of custom size with button to do the next rearrangement ->
**            Do random resettlement ->
**            Endless cycle 
**            
*/

using System;

namespace LifeGame
{

    public interface ILife
    {
        void GenerateWorld(int[,] reservour);
        void ClearWorld();
    }


    public class LifeGame : ILife
    {
        protected int[,] second;
        private static int generation = 0;
        public int[,] First { get; set; }
        public int Y_Dim { get; private set; }
        public int X_Dim { get; private set; }
        public static int Generation { get => generation; private set => generation = value; }
        public int TimeInterval { get; set; }

        public int this[int y, int x]
        {
            get
            {
                if (IsOutOfBounds(y, x))
                    throw new ArgumentOutOfRangeException("value must be in correct range");
                else
                {
                    return First[y,x];
                }
            }
            set
            {
                if (IsOutOfBounds(y, x))
                    throw new ArgumentOutOfRangeException("value must be in correct range");
                else
                {
                    First[y, x] = value;
                }
            }
        }
        //master constructor
        public LifeGame(int Xbound, int Ybound, int TimeInterval)
        {
            Y_Dim = Ybound;
            X_Dim = Xbound;
            First = new int[Ybound, Xbound];
            second = GetClonnedArray(First, Ybound, Xbound);
            TimeInterval = this.TimeInterval;
            //random resettlement
            GenerateWorld(First);
        }

        public LifeGame(int bound) : this(bound, bound, 100) { }


        //TODO: refactor it later
        public LifeGame(int Xcord, int Y_cord) : this(Xcord, Y_cord, 100) { }

        protected bool IsOutOfBounds(int y_value, int x_value)
        {
            return y_value < 0 || x_value > First.GetUpperBound(0) || y_value < 0 || y_value > First.Length / (First.GetUpperBound(0) + 1) ;
        }

        public void GenerateWorld(int[,] reservour)
        {
            int rows = reservour.GetUpperBound(0) + 1;
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < reservour.Length / rows; j++)
                {
                    reservour[i, j] = random.Next(0, 2);
                }

            }
        }

        public void ClearWorld()
        {
            Generation = 0;
            //create arrays filled with zeroes
            int[,] fst = new int[First.GetUpperBound(0) + 1, First.Length / (second.GetUpperBound(0) + 1)];
            int[,] scnd = new int[second.GetUpperBound(0) + 1, First.Length / (second.GetUpperBound(0) + 1)];
            //copy values to original arrays
            First = fst;
            second = scnd;
        }

        public void GetNextState() =>
            MoveNext(First, second);
      

        public static void MoveNext(int[,] origin, int[,] destination)
        {
            int origin_rows = origin.GetUpperBound(0) + 1;
            int origin_coll = origin.Length / origin_rows;
            int destination_rows = destination.GetUpperBound(0) + 1;
            int destination_coll = destination.Length / destination_rows;

            if (origin_rows != destination_rows || origin_coll != destination_coll || origin_rows == 0 || origin_coll == 0)
            {
                throw new System.ArgumentOutOfRangeException("Arrays must be the same");
            }
            else
            {
                for (int i = 0; i < origin_coll; ++i)
                {
                    for (int j = 0; j < origin_rows; ++j)
                    {
                        destination[i, j] = LifeHelper.IsAlive(origin, i, j) ? 1 : 0;
                    }
                }
            }
            ++Generation;
            origin = destination;
        }

        private int[,] GetClonnedArray(int [,] origin, int Y_bound, int X_bound)
        {
            int[,] clone = new int[Y_bound, X_bound];

            for (var j = 0; j < Y_bound; ++j)
            {
                for (var i = 0; i < X_bound; ++i)
                {
                    clone[j, i] = origin[j, i];
                }
            }
            return clone;
        }
    }

}