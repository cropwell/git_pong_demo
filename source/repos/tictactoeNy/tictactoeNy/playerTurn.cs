using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoeNy
{
  public class PlayerTurn : ShowBoard
    {


        public static int player = 1;
        bool x = true;
        int y = 0;

        public void whicePlayerToPlay()
        {
            do
            {
              
                x = false;

                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 chance");
                    player++;

                }

                else
                {
                    Console.WriteLine("Player 1 chance");
                    player++;

                }

                y++;
                Console.WriteLine("\n");
       
            }

            while (y <= 0);

        }


        
        public void whicePlayerWon()
        {
            if (player % 2 == 0)
            {
                Console.WriteLine("Congrats player 2 won");
            }

            else

            {
                Console.WriteLine("Congrats player 1 won");
            }
        }







    }
}
