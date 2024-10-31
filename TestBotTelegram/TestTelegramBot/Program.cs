using Telegram.Bot;
using Telegram.Bot.Types;

namespace TestTelegramBot
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //var client = new TelegramBotClient("7787048783:AAGUCmcV7F780eT7mTxOyFIqKAUHs0cB8L4");
      //client.StartReceiving(Update, Error);

      //Console.ReadLine();

      try 
      {
        TelegraBotHelper hlp = new TelegraBotHelper(token: "7787048783:AAGUCmcV7F780eT7mTxOyFIqKAUHs0cB8L4");
        hlp.GetUpdates();
      }
      catch(Exception ex) {Console.WriteLine(ex.Message); return; } 
      
    }

    private static async Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
    {
      throw new NotImplementedException();
    }

    private static async Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
    {
      var message = update.Message;
    }
  }
}
