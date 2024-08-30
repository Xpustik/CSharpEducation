namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int count = 1;
            bool exit = true;
            bool resultGame = false;
            Field.ClearField();
            
            while(exit) 
            {
                Console.Clear();
                int result = count % 2;
                                
                DesignField.PrintTurn(result);
                DesignField.PrintField(Field.playField, Field.playerField);

                int value =  Field.ReadTurn();
                bool check = Field.CheckTurn(value);
                
                // если ход некорректный анулирует его
                if (check) Field.WriteFeild(value, result);
                else count--;

                 
                resultGame = Field.GameOver();
                if ((count == 9) || (resultGame == true))  
                {
                    DesignField.PrintField(Field.playField, Field.playerField);
                    exit = false;
                }
                count++;
                              
            }
        }
    }
}
