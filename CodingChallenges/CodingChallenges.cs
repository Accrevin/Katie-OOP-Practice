namespace Assignment1
{

    class Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

    }
    class Character
    {
        public Vector2 position { get; set; }
        public string name;
        public Vector2 translateDistance { get; set; }

        public Character(Vector2 Position, string Name)
        {
            Position = position;
            Name = name;
        }

        public Vector2 Translate(Vector2 TranslateDistance,Vector2 position)
        {
            Vector2 NewLocation = new Vector2(position.X, position.Y);
            NewLocation.X = NewLocation.X + translateDistance.X;
            NewLocation.Y = NewLocation.Y + translateDistance.Y;
            return NewLocation;         
        }
    }

    
    internal class GuessingGame
    {
        static void Main(string[] args)
        {
            Vector2 location = new Vector2(0.0f, 0.0f);

            Character character = new Character(location, "cube");
            character.translateDistance = new Vector2(1.5f, 2.5f);
            character.position = character.Translate(character.translateDistance, character.position);
            Console.WriteLine(character.position);
            
           


            //        Console.WriteLine("Enter the Maximum number");
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        Random rand = new Random();
            //        int Answer = rand.Next(1, num + 1);

            //        bool runtime = true;
            //        while (runtime)
            //        {
            //            Console.WriteLine($"Guess a number between 1 and {num}");
            //            int guess = Convert.ToInt32(Console.ReadLine());

            //            if (guess == Answer)
            //            {
            //                Console.WriteLine("Correct guess!");
            //                runtime = false;
            //            }

            //            else if (guess > Answer)
            //            {
            //                Console.WriteLine("Guess too high, try again");
            //            }

            //            else if (guess < Answer)
            //            {
            //                Console.WriteLine("Guess too low, try again");
            //            }

            //        }

            //    }
            //}

            //string text = "The quick brown fox jumps over the lazy dog";
            //bool run = true;
            //int loop = 0;
            //while (run)
            //{
            //    if (loop == 0)
            //    {
            //        Console.Clear();
            //        for (int i = 0; i < text.Length; i++)
            //        {
            //            Console.Write(text[i]);
            //            Thread.Sleep(100);
            //        }
            //        Console.WriteLine();

            //        Console.WriteLine("Enter a letter");
            //        loop++;
            //    }

            //    else
            //    {
            //        string letterString = Console.ReadLine();
            //        char LetterChar = Convert.ToChar(letterString);
            //        Console.Clear();
            //        for (int i = 0; i < text.Length; i++)
            //        {
            //            if (text[i] == LetterChar)
            //            {
            //                Console.Write(char.ToUpper(text[i]));
            //                Thread.Sleep(100);
            //            }

            //            else
            //            {
            //                Console.Write(text[i]);
            //                Thread.Sleep(100);
            //            }
            //        }
            //        Console.WriteLine();

            //        Console.WriteLine("Enter a letter");
            //    }
            //}



               
            }
        }
    }
