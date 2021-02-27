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
        PlayerTurn playerTurn = new PlayerTurn();
        Markspot markSpot = new Markspot();
        GameOutcome gameOutcome = new GameOutcome();
        public void UpdatingBoard()
        {
            Console.Clear();
            whicePlayerIsXAndO();
            showBoard.Board(); // show boards

            playerTurn.whicePlayerToPlay(); // What player turn is it

            gameOutcome.IsItWin();

       
         
         


        }

        public static void whicePlayerIsXAndO()
        {
            Console.WriteLine("Player 1: O and player 2: X \n \n");

        }
    }
}
