using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Bot;
using Microsoft.Bot.Builder;

namespace demo1.Bots{
    public class SimpleBot : IBot{
        public async Task OnTurn(ITurnContext turnContext, CancellationToken cancellationToken){
            await turnContext.SendActivityAsync("Hello World!");
        }

        public Task OnTurnAsync(ITurnContext turnContext, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}