using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class DesignField
    {
     /// <summary>
     /// Выводит в консоль игровое поле
     /// </summary>
     /// <param name="field"> игровое поле </param>
     /// <param name="player"> значения игроков </param>
      internal static void PrintField(bool[] field, bool[] player) 
      {
         for (int i = 0; i < 9; i++) 
         {
            Console.Write("\t");
                //Console.Write(i + 1);
                if ((field[i] == true) && (player[i] == true))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("X");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if ((field[i] == true) && (player[i] == false))
                {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("O");
                        Console.ForegroundColor = ConsoleColor.Gray;
                }
                else Console.Write(i + 1);

            int result = (i + 4) % 3;
                if (result == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
            
            //Console.WriteLine(result);
         }
           // for (int i = 0; i < 9; i++) Console.WriteLine($"Поле {i}: {field[i]} \t Игрок : { player[i]} ");
      }

      /// <summary>
      /// Вывод в консоль чей ход "Х" или "О"
      /// </summary>
      /// <param name="turn"> Четный или нечетный параметр (0 или 1) </param>
      internal static void PrintTurn(int turn)
      {
          if (turn == 0)
          {
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine("\t Turn Player X !");
              Console.ForegroundColor = ConsoleColor.Gray;
          }
          else
          {
              Console.ForegroundColor = ConsoleColor.Green;
              Console.WriteLine("\t Turn Player O !");
              Console.ForegroundColor = ConsoleColor.Gray;
          };
      }
      internal static bool WinPlayer(int chekPlayer1, int checkPlayer2) 
      {
         if (chekPlayer1 == 3)
         {
             Console.ForegroundColor = ConsoleColor.Red;
             Console.WriteLine("\t Win Player X !");
             Console.ForegroundColor = ConsoleColor.Gray;
             return true;
         }
         if (checkPlayer2 == 3)
         {
             Console.ForegroundColor = ConsoleColor.Green;
             Console.WriteLine("\t Win Player O !");
             Console.ForegroundColor = ConsoleColor.Gray;
             return true;
         }
         return false;
      }
    
      internal static void PrintDraw() 
      {
            foreach (var item in Field.drawPlayer)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
      }
    }
}
