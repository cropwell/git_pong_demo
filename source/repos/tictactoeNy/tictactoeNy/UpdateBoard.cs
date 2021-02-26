using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoeNy
{
 public class UpdateBoard
    {
        ShowBoard showBoard = new ShowBoard();
        playerTurn playerTurn = new playerTurn();
        Markspot markSpot = new Markspot();

        public void UpdatingBoard()
        {
            Console.Clear();
            whicePlayerIsXAndO();
            showBoard.Board(); // show boards

            playerTurn.whicePlayerToPlay(); // What player turn is it

         

            markSpot.placeMark(); // Places the player mark (X or O) on the spot they choose




        }

        public static void whicePlayerIsXAndO()
        {
            Console.WriteLine("Player 1: X and player 2: O \n \n");

        }
    }
}
