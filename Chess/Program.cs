namespace Chess
{
    abstract class Piece
    {
        public Vector2 Pos;
        public char Glyph;
        public Func<List<Vector2>> GetMovements;

        public Piece(char glyph)
        {
            Glyph = glyph;
        }

        public abstract List<Vector2> CalculateMovements();
    }

    class Knight : Piece
    {
        public Knight(char glyph) : base(glyph) { }

        public override List<Vector2> CalculateMovements()
        {
            List<Vector2> movements = [
                Pos + new Vector2(1, -2),
                Pos - new Vector2(2, -1),
                Pos + new Vector2(2, -1),
                Pos - new Vector2(1, -2),
                Pos + new Vector2(1, 2),
                Pos - new Vector2(2, 1),
                Pos + new Vector2(2, 1),
                Pos - new Vector2(1, 2)
            ];
            return movements;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
