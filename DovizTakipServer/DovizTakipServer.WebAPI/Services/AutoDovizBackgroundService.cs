using DovizTakipServer.Application.Hubs;
using DovizTakipServer.Domain.Entities;
using Microsoft.AspNetCore.SignalR;

namespace DovizTakipServer.WebAPI.Services;

public class AutoDovizBackgroundService(IHubContext<TakipHub> hubContext) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await Task.Delay(1000);
            await CreateCurrency(1);
            await CreateCurrency(2);
        }
    }

    private async Task CreateCurrency(int type)
    {
        Random random = new();
        decimal amount = 0;
        if(type == 1)
        {
            amount = random.Next(30, 33);
        }
        if (type == 2)
        {
            amount = random.Next(33, 36);
        }
        Currency currency = Currency.Create(amount, type);
        await hubContext.Clients.All.SendAsync("Currency", currency);
    }
}
