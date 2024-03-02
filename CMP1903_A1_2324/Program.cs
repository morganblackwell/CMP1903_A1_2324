﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            /// <summary>
            /// Infinitely creates a game object through the Testing class
            /// until the users types 'stop'.
            /// </summary>


            // Keep rolling until 'stop' is typed
            for (; ; )
            {
                Testing testOutputs = new Testing();
                testOutputs.Main();

                Console.WriteLine("Type 'stop' to stop");
                var stopRoll = Console.ReadLine();
                stopRoll.ToLower(); // Input sanitisation

                if (stopRoll == "stop")
                {
                    break; // Stop program
                }
            }

        }
    }
}
