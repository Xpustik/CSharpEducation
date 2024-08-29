using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Field
    {
         
        /// <summary>
        /// свободная клетка или нет, false - свободно, true - занатя
        /// </summary>
        public static bool[] playField = new bool[9];
        /// <summary>
        /// false - крестик, true - нолик
        /// </summary>
        public static bool[] playerField = new bool[9];
        // флаг проверки линии на возможность выиграть
        public static bool[] drawPlayer = new bool[8];
        /// <summary>
        /// Проверка горизонтали
        /// </summary>
        internal static bool CheckHorField()
        {
            for (int i = 0; i < 3; i++) 
            {
                bool plaer1 = false;
                bool plaer2 = false;
                int chekPlayer1 = 0;
                int chekPlayer2 = 0;
                bool value;

                for (int j = 0; j < 9; j+=3) 
                {
                    // проверяем ячейку поля на наличие хода и целесообразности проверки
                    if ((playField[i + j] == false) || (drawPlayer[i] == true)) continue;
                    // проверяем что ячейка поля занята
                    if (playField[i + j] == true)
                        // проверяем кто сделал ход
                        if (playerField[i + j] == true)
                        {
                            plaer2 = true;
                            chekPlayer1 += 1;
                        }
                        else if (playerField[i + j] != true) 
                        { 
                            plaer1 = true;
                            chekPlayer2 += 1;
                        }
                    // Проверка на ничью линии
                    if ((chekPlayer2 == 1) && (chekPlayer1 == 1)) drawPlayer[i]=true;
                }
              
              value = DesignField.WinPlayer(chekPlayer1, chekPlayer2);
                if (value == true) return true; 
            }
            return false;
        }
        /// <summary>
        /// Проверка вертикали
        /// </summary>
        internal static bool CheckVerField()
        {
            int ij = 3;
            for (int i = 0; i < 9; i += 3)
            {
                bool plaer1 = false;
                bool plaer2 = false;
                int chekPlayer1 = 0;
                int chekPlayer2 = 0;
                bool value;
                

                for (int j = 0; j < 3; j++)
                {
                   // проверяем ячейку поля на наличие хода и целесообразности проверки
                   // if ((playField[i + j] == false) || (drawPlayer[ij] == true)) continue;
                    // проверяем что ячейка поля занята
                    if (playField[i + j] == true)
                        // проверяем кто сделал ход
                        if (playerField[i + j] == true)
                        {
                            plaer2 = true;
                            chekPlayer1 += 1;
                        }
                        else if (playerField[i + j] != true)
                        {
                            plaer1 = true;
                            chekPlayer2 += 1;
                        }
                    // Проверка на ничью линии
                    if ((chekPlayer2 == 1) && (chekPlayer1 == 1)) drawPlayer[ij] = true;                    
                                      
                } 
                ij++;
                value = DesignField.WinPlayer(chekPlayer1, chekPlayer2);
                if (value == true) return true;
            }
            return false;
        }
        /// <summary>
        /// Проверка диагонали обратной
        /// </summary>
        /// <returns> совпало три или нет </returns>
        internal static bool CheckDiagonalField() 
        {
            bool plaer1 = false;
            bool plaer2 = false;
            int chekPlayer1 = 0;
            int chekPlayer2 = 0;
            bool value;

            for (int i = 2; i < 7; i += 2)
            {
                if (Field.playField[i] == false) continue;
                if (Field.playField[i] == true)
                {
                    if (Field.playerField[i] == true)
                    {
                        plaer2 = true;
                        chekPlayer1 += 1;
                    }
                    else if (Field.playerField[i] != true)
                    {
                        plaer1 = true;
                        chekPlayer2 += 1;
                    }
                }
            }
            if ((chekPlayer2 == 1) && (chekPlayer1 == 1)) drawPlayer[6] = true;
            
            value = DesignField.WinPlayer(chekPlayer1, chekPlayer2);
            if (value == true) return true;
            return false;
        }
        /// <summary>
        /// Проверка главной диагонали
        /// </summary>
        /// <returns> совпало три или нет </returns>
        internal static bool CheckDiagonal1Field()
        {
            bool plaer1 = false;
            bool plaer2 = false;
            int chekPlayer1 = 0;
            int chekPlayer2 = 0;
            bool value;

            for (int i = 0; i < 9; i += 4)
            {
                if (Field.playField[i] == false) continue;
                if (Field.playField[i] == true)
                {
                    if (Field.playerField[i] == true)
                    {
                        plaer2 = true;
                        chekPlayer1 += 1;
                    }
                    else if (Field.playerField[i] != true)
                    {
                        plaer1 = true;
                        chekPlayer2 += 1;
                    }
                } 
            }
            if ((chekPlayer2 == 1) && (chekPlayer1 == 1)) drawPlayer[7] = true;
            
            value = DesignField.WinPlayer(chekPlayer1, chekPlayer2);
            if (value == true) return true;
            return false;
        }
        /// <summary>
        /// парсинг в инт хода игрока
        /// </summary>
        /// <returns> номер поля </returns>
        internal static int ReadTurn() 
        {
            bool result = false;
            int lengthValue;

            string? input = Console.ReadLine();

            result = int.TryParse(input, out lengthValue);

            if (result) return lengthValue - 1;
            else return -1;
        }
        
        /// <summary>
        /// Запись хода
        /// </summary>
        /// <param name="count"> номeр поля </param>
        /// <param name="turn"> Чей ход Х или О. Четный или нечетный параметр  (0 или 1) </param>
        /// <param name="playField"> Массив поля </param>
        /// <param name="playerField"> Массив игроков </param>
        internal static void WriteFeild(int count, int turn) 
        {
            if (playField[count] == false)
            {
                playField[count] = true;

                if (turn == 0)
                {
                    playerField[count] = true;
                }
                else
                {
                    playerField[count] = false;
                }
            }
        }
        /// <summary>
        /// Проверка вводимого значения в диапозоне от 1 до 9 
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        internal static bool CheckTurn(int result) 
        {
            //int result = ReadTurn();
            if ((result >= 0) && (result < 9) && (playField[result] == false)) 
            {
                //playerField[result] = true;
                return true;
            }
            Console.WriteLine("Некоректный ход");
            return false;
        }
        /// <summary>
        /// проверка на ничью
        /// </summary>
        /// <param name="count"></param>
        /// <returns> возвращает true если ничья </returns>
        internal static bool GameOver(int count) 
        {
           int counter = 0;
           bool valueVer = CheckVerField(); 
           bool valueHor = CheckHorField();
           bool valueDiagonal = CheckDiagonalField();
           bool valueDiagonal1 = CheckDiagonal1Field();

            for (int i = 0; i < 8; i++) 
            {
                if (drawPlayer[i] == true) counter++;
            }
            if (counter == 5) 
            {
                Console.WriteLine("Game Over Ничья!!!");
                return true;
            }
            //if ((valueHor) || (valueVer) || (valueDiagonal) || (valueDiagonal1)) return true;

            Console.WriteLine($"Счетчик линий {counter}");
            return false;
        }

        internal static void ClearField() 
        {
            for (int i = 0; i < 8; i++) 
            {
                playerField[i] = false;
                playField[i] = false;
                drawPlayer[i] = false;
            }
        }
    }
}
