using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class FlipCoin
    {
        public static void CalculatePercentage()
        {
            Console.WriteLine("Please enter the value for number of flips");

            int head=0;
            int tail = 0;
            int headcount = 0;
            int tailcount = 0;

            double HeadPercentage;
            double tailPercentage;

            int flipCoin =Convert.ToInt32(Console.ReadLine());

            if(flipCoin>0)
            {
                for(int i=0;i< flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    Console.WriteLine("The Random number generated is  " + number);

                    //if(number == 0)
                    //{
                    //    tailcount++;
                    //}else
                    //{
                    //    headcount++;
                    //}

                    switch(number)
                    {
                        case 0:
                            tailcount++;
                            break;
                        case 1:
                            headcount++;
                            break;
                    }
                }
                Console.WriteLine("The tail count is  " + tailcount);
                Console.WriteLine("The Head Count is " + headcount);

                HeadPercentage = headcount * 100 / flipCoin;
                tailPercentage = tailcount * 100 / flipCoin;

                Console.WriteLine("HeadPercentage : " + HeadPercentage+"%");
                Console.WriteLine("TailPercentage : " + tailPercentage+"%");
            }
            else
            {
                Console.WriteLine("Please enter a valid number");
            }


        }
    }
}
