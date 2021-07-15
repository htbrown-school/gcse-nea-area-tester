using System;

namespace AreaTrainer
{
    public static class Questions
    {
        private static Random _rand = new Random();
        private static int points = 2;
        
        public static void Square(int diff)
        {
            points = 2;
            double width = Math.Round(_rand.NextDouble() * 100, diff - 1);
            double height = Math.Round(_rand.NextDouble() * 100, diff - 1);

            string choice = null;
            int correctIndex = _rand.Next(1, 5);

            while (choice != correctIndex.ToString() && points > 0)
            {
                Console.WriteLine("Find the area of the shape below.");
                Console.WriteLine();

                Console.WriteLine(" -------- ");
                Console.WriteLine("|        |");
                Console.WriteLine("|        | " + height + "cm");
                Console.WriteLine("|        |");
                Console.WriteLine(" -------- ");
                Console.WriteLine(" " + width + "cm ");

                Console.WriteLine();

                for (int i = 1; i < 5; i++)
                {
                    if (i == correctIndex)
                    {
                        Console.WriteLine(i + ". " + Math.Round(width * height, 2) + "cm");
                    }
                    else
                    {
                        Console.WriteLine(i + ". " + Math.Round(_rand.NextDouble() * _rand.Next(100, 500), diff - 1) + "cm");
                    }
                }
                choice = Utils.Input();
                
                if (choice == correctIndex.ToString())
                {
                    Console.Clear();
                    Console.WriteLine("Well done! You got " + points + " point(s)!");
                    Score.S = Score.S + points;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Oops! That's not quite right.");
                    Console.WriteLine();
                    Console.WriteLine("(Remember, the equation for the area of a square is a = h * w)");
                    points--;
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                }
            }

            if (choice != correctIndex.ToString())
            {
                Console.Clear();
                Console.WriteLine("The correct answer was " + width * height + "cm.");
            }
        }

        public static void Triangle(int diff)
        {
            points = 2;
            double b = Math.Round(_rand.NextDouble() * 100, diff - 1);
            double height = Math.Round(_rand.NextDouble() * 100, diff - 1);

            string choice = null;
            int correctIndex = _rand.Next(1, 5);

            while (choice != correctIndex.ToString() && points > 0)
            {
                Console.WriteLine("Find the area of the shape below.");
                Console.WriteLine();

                Console.WriteLine("    /\\   ");
                Console.WriteLine("   /  \\  ");
                Console.WriteLine("  /    \\ " + height + "cm");
                Console.WriteLine(" /      \\");
                Console.WriteLine(" -------- ");
                Console.WriteLine(" " + b + "cm ");

                Console.WriteLine();

                for (int i = 1; i < 5; i++)
                {
                    if (i == correctIndex)
                    {
                        Console.WriteLine(i + ". " + Math.Round(0.5 * b * height, 2) + "cm");
                    }
                    else
                    {
                        Console.WriteLine(i + ". " + Math.Round(_rand.NextDouble() * _rand.Next(100, 500), diff - 1) + "cm");
                    }
                }
                choice = Utils.Input();
                
                if (choice == correctIndex.ToString())
                {
                    Console.Clear();
                    Console.WriteLine("Well done! You got " + points + " point(s)!");
                    Score.S = Score.S + points;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Oops! That's not quite right.");
                    Console.WriteLine();
                    Console.WriteLine("(Remember, the equation for the area of a triangle is a = 0.5 * b * h)");
                    points--;
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                }
            }

            if (choice != correctIndex.ToString())
            {
                Console.Clear();
                Console.WriteLine("The correct answer was " + 0.5 * b * height + "cm.");
            }

        }

        public static void Circle(int diff)
        {
            points = 2;
            double diameter = Math.Round(_rand.NextDouble() * 100, diff - 1);

            string choice = null;
            int correctIndex = _rand.Next(1, 5);

            while (choice != correctIndex.ToString() && points > 0)
            {
                Console.WriteLine("Find the area of the shape below.");
                Console.WriteLine();

                Console.WriteLine(" /------\\");
                Console.WriteLine("|        |");
                Console.WriteLine("|        |");
                Console.WriteLine("|        |");
                Console.WriteLine(" \\------/ ");
                Console.WriteLine(" Diameter: " + diameter + "cm");

                Console.WriteLine();

                for (int i = 1; i < 5; i++)
                {
                    if (i == correctIndex)
                    {
                        Console.WriteLine(i + ". " + Math.Round(Math.PI * (0.5 * diameter) * (0.5 * diameter), 2) + "cm");
                    }
                    else
                    {
                        Console.WriteLine(i + ". " + Math.Round(_rand.NextDouble() * _rand.Next(100, 500), diff - 1) + "cm");
                    }
                }
                choice = Utils.Input();
                
                if (choice == correctIndex.ToString())
                {
                    Console.Clear();
                    Console.WriteLine("Well done! You got " + points + " point(s)!");
                    Score.S = Score.S + points;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Oops! That's not quite right.");
                    Console.WriteLine();
                    Console.WriteLine("(Remember, the equation for the area of a circle is πr^2)");
                    points--;
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                }
            }

            if (choice != correctIndex.ToString())
            {
                Console.Clear();
                Console.WriteLine("The correct answer was " + Math.Round(Math.PI * (0.5 * diameter) * (0.5 * diameter), 2) + "cm.");
            }
        }
    }
}