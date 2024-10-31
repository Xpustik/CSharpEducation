
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace TestTelegramBot
{
  internal class TelegraBotHelper
  {
    private const string Text1 = "Один";
    private const string Text2 = "Два";
    private const string Text3 = "Три";
    private const string Text4 = "Четыре";

    private string token;
    
    Telegram.Bot.TelegramBotClient client;

    public TelegraBotHelper(string token)
    {
      this.token = token;
    }

    internal void GetUpdates()
    {
      client = new Telegram.Bot.TelegramBotClient(token);
      var me = client.GetMeAsync().Result;

      if (me != null && !string.IsNullOrEmpty(me.Username))
      {
        int offset = 0;
        while (true)
        {
          try
          {
            var updates = client.GetUpdatesAsync(offset).Result;
            if (updates != null && updates.Count() > 0)
            {
              foreach (var update in updates) 
              {
                processUpdate(update);
                offset = update.Id + 1;
              }
            }
          }
          catch (Exception ex) { Console.WriteLine(ex.Message); return; }

          Thread.Sleep(1000);
        }
      }
    }

    private void processUpdate(Update update)
    {
      
      if (update.Type == UpdateType.Message)
      {
          {
            //переменная будет содержать в себе все связанное с сообщениями
            var message = update.Message;
            // From - это от кого пришло сообщение
            var user = message.From;
            // Chat - содержит всю информацию о чате
            var chat = message.Chat;

            var inlineKeyboard = new InlineKeyboardMarkup(
              new List<InlineKeyboardButton[]>()
              {
                new InlineKeyboardButton[]
                {
                  InlineKeyboardButton.WithCallbackData("кнопка 1", "/callbackData1"),
                  InlineKeyboardButton.WithCallbackData("кнопка 12", "/callbackData12"),
                },
                new InlineKeyboardButton[]
                {
                  InlineKeyboardButton.WithCallbackData("кнопка 21", "/callbackData21"),
                  InlineKeyboardButton.WithCallbackData("кнопка 22", "/callbackData22"),
                }

              });

            client.SendTextMessageAsync(chat.Id, "Reaceve text " + message, replyMarkup: inlineKeyboard);
          }
          Console.WriteLine(update.Type + " Not implemented!");
          
        };
      if (update.Type == UpdateType.CallbackQuery) 
      {
        var callbackData = UpdateType.CallbackQuery.ToString();
        if (string.IsNullOrEmpty(callbackData)) return;
        else
        if (callbackData.Contains("/callbackData1")) Console.WriteLine("кнопка 1");

      }
        
            
          
        

      
    }

    //private async Task  GetBottons()
    //{
      
      
    //  //await client.SendTextMessageAsync(
    //  //          "Это Inline клавиатура!",
    //  //  replyMarkup: inlineKeyboard);
    //  return inlineKeyboard;
    //}
  }
};