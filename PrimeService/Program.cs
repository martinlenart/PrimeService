using PrimeService.Models;
using PrimeService.Services;

namespace PrimeService
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Progress<float> progressReporter = new Progress<float>(value =>
            {
                Console.WriteLine($"{value*100:F0}%");
            });

            var _service = new PrimeNumberService();
            var primes = await _service.GetPrimeBatchCountsAsync(10, progressReporter);

            foreach (var prime in primes)
            {
                Console.WriteLine(prime);
            }
        }
    }
}