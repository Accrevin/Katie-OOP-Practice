using System.Collections.Generic;

namespace Checkers
{
    class Piece
    {
        public Vector2 Pos;
        public char Team;

        public Piece(char team)
        {
            Team = team;
        }

        //public abstract List<Vector2> CalculateMovements();
    }

    //class Knight : Piece
    //{
    //    public Knight(char team) : base(team)
    //    {
    //    }

    //    public override List<Vector2> CalculateMovements()
    //    {
    //        List<Vector2> movements =
    //        [
    //            Pos + new Vector2(1, -2),
    //            Pos - new Vector2(2, -1),
    //            Pos + new Vector2(2, -1),
    //            Pos - new Vector2(1, -2),
    //            Pos + new Vector2(1, 2),
    //            Pos - new Vector2(2, 1),
    //            Pos + new Vector2(2, 1),
    //            Pos - new Vector2(1, 2),
    //        ];

    //        return movements;
    //    }
    //}

    //struct Vector2
    //{
    //    public int X, Y;

    //    public static readonly Vector2 Zero = new Vector2(0, 0);

    //    public Vector2(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public static Vector2 operator +(Vector2 a, Vector2 b)
    //    {
    //        return new Vector2(a.X + b.X, a.Y + b.Y);
    //    }

    //    public static Vector2 operator -(Vector2 a, Vector2 b)
    //    {
    //        return new Vector2(a.X - b.X, a.Y - b.Y);
    //    }


    //    public override string ToString()
    //    {
    //        return $"{X}, {Y}";
    //    }
    //}
    class program
    {
        static void Main()
        {
            int boardSize = 8;
            List<Piece> Xpieces = new List<Piece>();
            List<Piece> Opieces = new List<Piece>();


            //Set the starting positions of the 'X' Player
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Piece Player = new Piece('X');

                   
                    int xPosition = (j * 2 + i % 2 + 1);
                    if (xPosition >= 8)
                    {
                        xPosition = 0;
                    }
                    int yPosition = i;
                    
                    Player.Pos = new Vector2(xPosition, yPosition);
                    Player.Team = 'X';
                    Xpieces.Add(Player);

                }
            }


            //Set the starting positions of the 'O' Player
            for (int i = 7; i >= 5; i--)
            {
                for (int j = 0; j < 4; j++)
                {
                    Piece Player = new Piece('O');


                    int xPosition = (j * 2 + i % 2 + 1);
                    if (xPosition >= 8)
                    {
                        xPosition = 0;
                    }
                    int yPosition = i;
              
                    Player.Pos = new Vector2(xPosition, yPosition);
                    Player.Team = 'O';
                    Opieces.Add(Player);
                }
            }


            while (true)
            {
                Console.Clear();


                PrintBoard(Xpieces, Opieces, boardSize);

                Console.WriteLine(Xpieces.Count);
                Console.WriteLine(Opieces.Count);


                while (!Console.KeyAvailable) { }
                
                ConsoleKey key = Console.ReadKey(true).Key;

                //    Vector2 targetPos = Player.Pos;

                //    if (key == ConsoleKey.Q)
                //    {
                //        targetPos.Y -= 1;
                //        targetPos.X -= 1;
                //        Console.WriteLine(targetPos);
                //    }

                //    else if (key == ConsoleKey.E)
                //    {
                //        targetPos.Y -= 1;
                //        targetPos.X += 1;
                //        Console.WriteLine(targetPos);
                //    }

                //    else if (key == ConsoleKey.A)
                //    {
                //        targetPos.Y += 1;
                //        targetPos.X -= 1;
                //        Console.WriteLine(targetPos);
                //    }

                //    else if (key == ConsoleKey.D)
                //    {
                //        targetPos.Y += 1;
                //        targetPos.X += 1;
                //        Console.WriteLine(targetPos);
                //    }
                //    if (targetPos.X >= 0 && targetPos.X < boardSize && targetPos.Y >= 0 && targetPos.Y < boardSize)
                //    {
                //        Player.Pos = targetPos;
                //    }
                //}

            }
            static void PrintBoard(List<Piece> Xpieces, List<Piece> Opieces, int boardSize)
            {
                for (int y = 0; y < boardSize; y++)
                {
                    // Print each tile in the row.
                    for (int x = 0; x < boardSize; x++)
                    {
                        bool isOccupied = false;

                        Console.Write("[");

                        // Check if our piece is sitting on the tile we are
                        // about to draw. If it is, draw an X inside the tile.
                        // Otherwise, draw the tile as normal.
                        foreach (Piece piece in Xpieces)
                        {
                            if (piece.Pos == new Vector2(x, y))
                            {
                                Console.Write(piece.Team);

                                isOccupied = true;
                                break;
                            }
                        }

                        foreach (Piece piece in Opieces)
                        {
                            if (piece.Pos == new Vector2(x, y))
                            {
                                Console.Write(piece.Team);

                                isOccupied = true;
                                break;
                            }
                        }

                        if (isOccupied == false)
                        {
                            Console.Write(" ");
                        }

                        Console.Write("]");
                    }

                    // Print out a newline to skip to a new row.
                    Console.WriteLine();
                }
            }
        }
    }
}
