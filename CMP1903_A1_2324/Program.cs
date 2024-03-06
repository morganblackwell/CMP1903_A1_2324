﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main()
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            /// <summary>
            /// Infinitely creates a game object through the Testing class
            /// until the users types 'stop'.
            /// </summary>

            while (true) // Runs continuously 
            {
                Console.WriteLine("How many times should three dice be rolled?");

                try
                {
                    int rollAmount = Int32.Parse(Console.ReadLine());

                    for (int rollCount = 1; rollCount <= rollAmount; rollCount++)
                    {
                        Testing testOutputs = new Testing();
                        testOutputs.Main();
                        Console.WriteLine(); // Seperate different sets of rolls
                    }
                }

                // Stops non integer values being accepted
                catch (FormatException)
                {
                    Console.WriteLine("Input must be an integer");
                    Main(); // Resets Program to allow the user to enter a valid input
                }
            }
        }
    }
}
