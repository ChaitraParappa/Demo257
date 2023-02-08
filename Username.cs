using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Username
    {
        public static int a = 10;
        public static void DisplayUsername()
        {
            Console.WriteLine("Print the username");
            string username = Console.ReadLine();

            int val = username.Length;

            Console.WriteLine("The number of characters is " + val);

            if (username.Length > 3 && username.Length < 5)
            {
                Console.WriteLine("Hello " + username + ", How are you?");
                Console.WriteLine("Hello {0}, How are you?", username);
            }
            else if (username.Length > 5)
            {
                Console.WriteLine("The name is having more than 5 characters");
            }
            else
            {
                Console.WriteLine("The name is not having minimum 3 characters");
            }
        }
    }
}
