using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoeNy
{
   public class Markspot : ShowBoard
    {
        PlayerTurn playerTurn = new PlayerTurn();
        public static int player = 0;
        public static int winner = 0;

        int choice = 0;

        public void  placeMark()
        {
           
            GameOutcome gameOutcome = new GameOutcome();
            winner = gameOutcome.IsItWin();
            if (winner != 1)
            {
                gameOutcome.aa();
                choice = int.Parse(Console.ReadLine());
                if (arr[choice-1] != 'X' && arr[choice-1] != 'O')
                {

                    if (player % 2 == 0)
                    {
                        arr[choice-1] = 'O';
                        player++;
                    }

                    else
                    {
                        arr[choice-1] = 'X';
                        player++;
                    }

                }
            }

            else
            {
                playerTurn.whicePlayerWon();
            }

           
        }

       
    }
}
