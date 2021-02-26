using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoeNy
{
   public class Markspot : ShowBoard
    {
        public static int player = 1;

        int choice = 0;

        public void  placeMark()
        {
            choice = int.Parse(Console.ReadLine());
            if (arr[choice] != 'X' && arr[choice] != 'O')
            {

                if (player % 2 == 0 )
                {
                    arr[choice] = 'O';
                    player++;
                }

                else
                {
                    arr[choice] = 'X';
                    player++;
                }

            }
        }

       
    }
}
