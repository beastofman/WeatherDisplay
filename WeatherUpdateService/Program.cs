using System;

namespace WeatherUpdateService
{
    internal class Program
    {
        private static void Main()
        {
            var factory = new UpdaterServiceFactory();
            var service = factory.GetService();
            service.UpdateInterval = 60;
            service.Start();

            Console.WriteLine("Сервис обновлений запущен. Нажмите <Enter>, чтобы остановить работу.");
            Console.ReadLine();
            service.Stop();
            Console.WriteLine("Сервис обновлений остановлен.");
        }
    }
}