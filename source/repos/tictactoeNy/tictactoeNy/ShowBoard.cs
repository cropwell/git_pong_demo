﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoeNy
{
    public class ShowBoard
    {


        public static char[] arr = {'1', '2', '3', '4', '5', '6', '7', '8', '9'};

        public ShowBoard()
        {

        }
      
       
       
        public  void Board()

        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[0], arr[1], arr[2]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[3], arr[4], arr[5]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[6], arr[7], arr[8]);

            Console.WriteLine("     |     |      ");

        }


       public void aa()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
               
            
        }

    }

  
}
