using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Bot;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace demo1.Bots{
    public class SimpleBot : IBot{
        public async Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default)
        {
            if (turnContext.Activity.Type == ActivityTypes.Message){
                var replyText = $"You sent: {turnContext.Activity.Text}";
                await turnContext.SendActivityAsync(replyText);
            }
        }
    }
}