using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Wholesale.TelegramBot.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UpdateController : ControllerBase
    {
        private readonly TelegramBotClient botClient;

        public UpdateController(TelegramBotClient botClient)
        {
            this.botClient = botClient;
        }

        [HttpPost]
        public async Task Post(Update update)
        {
            await botClient.SendTextMessageAsync(update.Message.Chat.Id, "پیام شما دریافت شد، ممنون از زحمات شما :).");
        }
    }
}
