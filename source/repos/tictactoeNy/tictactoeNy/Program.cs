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

        static int y = 0;

  





        // vart vill spelare lägga sin  mark

        static int whoWon = 0; // if 1 har någon vunnit om -1 draw 0 fortsätter

        static void Main(string[] args)
        {
            var showBoard = new ShowBoard();
            var playing = new playerTurn();
            var markSpot = new Markspot();
            var updateBoard = new UpdateBoard();


            while (true)
            {
                updateBoard.UpdatingBoard();

            }

            //  showBoard.Board(); // show boards

            //  playing.whicePlayerToPlay(); // What player turn is it

            // markSpot.placeMark(); // Places the player mark (X or O) on the spot they choose






            //choice







        }

      



    }
    
}
