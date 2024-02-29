using System;
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

            //Game diceGame = new Game();
            //diceGame.Main();
            Testing testOutputs = new Testing();
            testOutputs.Main();


            Console.ReadLine();
        }
    }
}
