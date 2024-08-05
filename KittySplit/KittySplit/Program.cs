using System;
using System.Collections.Generic;
using KittySplit.Models;
using KittySplit.Services;

namespace KittySplit
{
    class Program
    {
          public static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();

        var kittyService = host.Services.GetRequiredService<IKittyService>();
        var cli = new CommandLineInterface(kittyService);

        cli.Start();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<YourDbContext>(options =>
                    options.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));

                services.AddTransient<IKittyRepository, KittyRepository>();
                services.AddTransient<IParticipantRepository, ParticipantRepository>();
                services.AddTransient<IExpenseRepository, ExpenseRepository>();
                services.AddTransient<IKittyService, KittyService>();
            });
}
        private static readonly IKittyService _kittyService = new KittyService();

        static Kitty CreateNewKitty(string name)
        {
            var kitty = _kittyService.CreateKitty(name);
            return kitty;
        }

        static void AddParticipants(Kitty kitty, List<string> participants)
        {
            foreach (var participant in participants)
            {
                _kittyService.AddParticipant(kitty, participant);
            }
        }

        static void RecordExpense(Kitty kitty, string payer, decimal amount, string description, List<string> involved)
        {
            _kittyService.RecordExpense(kitty, payer, amount, description, involved);
        }

        static void ViewExpenses(Kitty kitty)
        {
            var expenses = _kittyService.GetExpenses(kitty);
            foreach (var expense in expenses)
            {
                Console.WriteLine(expense);
            }
        }

        static void SettleBalances(Kitty kitty)
        {
            var balances = _kittyService.GetBalances(kitty);
            foreach (var balance in balances)
            {
                Console.WriteLine($"{balance.Key} owes {balance.Value:C}");
            }
        }
    }

