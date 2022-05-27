namespace Binance.Spot.FuturesExamples
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Binance.Common;
    using Binance.Spot;
    using Binance.Spot.Models;
    using Microsoft.Extensions.Logging;

    public class CalculateRateAfterAdjustCrosscollateralLtv_Example
    {
        public static async Task Main(string[] args)
        {
            using var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
            });
            ILogger logger = loggerFactory.CreateLogger<CalculateRateAfterAdjustCrosscollateralLtv_Example>();

            HttpMessageHandler loggingHandler = new BinanceLoggingHandler(logger: logger);
            HttpClient httpClient = new HttpClient(handler: loggingHandler);

            string apiKey = "api-key";
            string apiSecret = "api-secret";

            var futures = new Futures(httpClient, apiKey, apiSecret);

            var result = await futures.CalculateRateAfterAdjustCrosscollateralLtv("BUSD", 1.2376m, LoanDirection.ADDITIONAL);
        }
    }
}