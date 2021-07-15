using System;

namespace AreaTrainer
{
    public static class Utils
    {
        public static string Input(string msg = null)
        {
            if (msg != null)
            {
                Console.Write(msg + " > ");
            }
            else
            {
                Console.Write("> ");
            }

            return Console.ReadLine();
        }
    }
}