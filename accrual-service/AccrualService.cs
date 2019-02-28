using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

public class AccrualService : IHostedService, IDisposable
{
    public AccrualService() {

    }

    public void Dispose()
    {
        
    }


    public Task StartAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Accrual Service is starting.");

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Accrual Service is stopping.");

        return Task.CompletedTask;
    }
}