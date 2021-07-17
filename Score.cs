using System;
using System.Collections.Generic;
using System.IO;

namespace AreaTrainer
{
    public class Score
    {
        public static int S = 0;

        public static void PrintScores(string username)
        {
            Console.Clear();
            Console.WriteLine("Your score for the current session is: " + S);
            List<string> scores = GetScores(username);

            for (int i = 0; i < scores.Count; i++)
            {
                Console.WriteLine(scores[i]);
            }
        }

        public static List<string> GetScores(string username)
        {
            List<string> list = new List<string>();
            using StreamReader file = new("scores.txt");

            string line = file.ReadLine();
            while (line != null)
            {
                if (line.StartsWith(username))
                {
                    list.Add(line);
                }
                line = file.ReadLine();
            }
            file.Close();

            return list;
        }

        public static async void SaveScore(string username)
        {
            await using StreamWriter file = new("scores.txt", true);
            DateTime date = DateTime.Now;
            
            await file.WriteLineAsync(username + " " + date.ToString("dd/MM/yyyy HH:mm:ss") + " - " + S + " points");
            file.Close();
        }
    }
}