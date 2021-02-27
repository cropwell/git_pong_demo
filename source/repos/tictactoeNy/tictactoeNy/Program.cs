using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoeNy
{
   public class Program
    {
      static bool x = true;


        static int howManyTurnsPlayed;

        static int winner = 0;

        static int choice;

        // vart vill spelare lägga sin  mark

        

        static void Main(string[] args)
        {
            var showBoard = new ShowBoard();
            var playerTurn = new PlayerTurn();
            var markSpot = new Markspot();
            var updateBoard = new UpdateBoard();
            var gameOutcome = new GameOutcome();


            

            while (winner != 1)
            {
                winner = gameOutcome.IsItWin();
              
                updateBoard.UpdatingBoard();

                markSpot.placeMark(); // Places the player mark (X or O) on the spot they choose

                gameOutcome.IsItWin();
                howManyTurnsPlayed++;

                if (howManyTurnsPlayed == 9 && winner != 1)
                {
                    gameOutcome.draw();
                    winner = 1;
                }

              

            }

            //  showBoard.Board(); // show boards

            //  playing.whicePlayerToPlay(); // What player turn is it

            // markSpot.placeMark(); // Places the player mark (X or O) on the spot they choose






            //choice







        }

      



    }
    
}
