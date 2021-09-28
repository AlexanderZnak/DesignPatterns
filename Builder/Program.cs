using System;
using Microsoft.Extensions.DependencyInjection;

namespace Builder
{
    class Program
    {
        private static ConsoleWrite consoleWrite => Get<ConsoleWrite>();
        static void Main(string[] args)
        {
            Person sasha = new PersonBuilder()
                .Height(178)
                .Weight(95)
                .FirstName("Alexander")
                .Build();
            Console.WriteLine(consoleWrite.Deploy());
            Console.WriteLine(sasha);
        }

        private static IServiceProvider ServiceProvider()
        {
            return new Startup().ConfigureServices(new ServiceCollection());
        }
        
        public static T Get<T>()
        {
            return ServiceProvider().GetRequiredService<T>();
        }
    }
}