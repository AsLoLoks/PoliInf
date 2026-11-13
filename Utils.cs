using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliInf
{
    internal class Utils
    {
        public static int GetUserInputInt(string initialMessage, string errorMessage)
        {
            int a;

            Console.WriteLine(initialMessage);
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                errorMessage = "Error: " + errorMessage;
                Console.WriteLine(errorMessage);
                throw;
            }
            return a;
        }
        public static int GetUserInputInt(string initialMessage)
        {
            string errorMessage = "Nie sprecyzowano bledu";
            int a;

            Console.WriteLine(initialMessage);
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                errorMessage = "Error: " + errorMessage;
                Console.WriteLine(errorMessage);
                throw;
            }
            return a;
        }

        public static float GetUserInputFloat(string initialMessage, string errorMessage)
        {
            float a;

            Console.WriteLine(initialMessage);
            try
            {
                a = float.Parse(Console.ReadLine());
            }
            catch
            {
                errorMessage = "Error: " + errorMessage;
                Console.WriteLine(errorMessage);
                throw;
            }
            return a;
        }

        public static float GetUserInputFloat(string initialMessage)
        {
            float a;
            string errorMessage = "Nie sprecyzowano bledu";

            Console.WriteLine(initialMessage);
            try
            {
                a = float.Parse(Console.ReadLine());
            }
            catch
            {
                errorMessage = "Error: " + errorMessage;
                Console.WriteLine(errorMessage);
                throw;
            }
            return a;
        }

    }
}
