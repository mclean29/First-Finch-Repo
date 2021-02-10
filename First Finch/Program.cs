using FinchAPI;
using System;

namespace Finch_Starter
{
    class Program
    {
        // *************************************************************
        // Application:     Finch Starter Solution
        // Author:          Velis, John E
        // Description:
        // Date Created:    5/20/2016
        // Date Revised:    
        // *************************************************************

        static void Main(string[] args)
        {
            //
            // create a new Finch object
            //
            Finch myFinch;
            myFinch = new Finch();

            //
            // call the connect method
            //
            myFinch.connect();

            //
            // begin your code
            //
            myFinch.setLED(255, 0, 0);


            //
            //pause for user
            //
            Console.WriteLine();
            Console.WriteLine("press any button to exit");
            Console.ReadKey();

            //
            //end of your code
            //

            //
            // call the disconnect method
            //
            myFinch.disConnect();
        }
    }
}
