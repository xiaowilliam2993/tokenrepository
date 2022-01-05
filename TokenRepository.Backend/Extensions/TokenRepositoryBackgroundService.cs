using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace TokenRepository.Backend.Extensions
{
    public class TokenRepositoryBackgroundService : BackgroundService
    {
        public readonly ILogger<TokenRepositoryBackgroundService> _logger;

        public TokenRepositoryBackgroundService(ILogger<TokenRepositoryBackgroundService> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("TokenRepositoryBackgroundWorker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"TokenRepositoryBackgroundWorker started at: {DateTime.Now}");
            return base.StartAsync(cancellationToken);
        }
        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"TokenRepositoryBackgroundWorker stopped at: {DateTime.Now}");
            return base.StopAsync(cancellationToken);
        }

        public override void Dispose()
        {
            _logger.LogInformation($"TokenRepositoryBackgroundWorker disposed at: {DateTime.Now}");
            base.Dispose();
        }
    }
}
