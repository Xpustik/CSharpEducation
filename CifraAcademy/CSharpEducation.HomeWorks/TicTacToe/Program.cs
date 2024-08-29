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
                int result = count % 2;
                                
                DesignField.PrintTurn(result);
                DesignField.PrintField(Field.playField, Field.playerField);

                int value =  Field.ReadTurn();
                bool check = Field.CheckTurn(value);

                if (check) Field.WriteFeild(value, result);
                else count--;

                 
                resultGame = Field.GameOver(count);
                if ((count == 9) || (resultGame == true))  
                {
                    exit = false;
                }
                count++;

                DesignField.PrintDraw();
                
               // Console.Clear();
            }
        }
    }
}
