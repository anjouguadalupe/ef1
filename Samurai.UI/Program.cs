using Samurai.Data;
using SamuraiApp.Domain;
using System;
using System.Linq;

namespace Samurai.UI
{
    class Program
    {
        private static SamuraiContext _context = new SamuraiContext();
        private static void Main(string[] args)
        {
            _context.Database.EnsureCreated();
            GetSamurais("Before Add:");
            AddSamurais();
            GetSamurais("After Add:");
            Console.Write("Press any key...");
            Console.ReadKey();
        }
        private static void AddSamurais()
        {
            var samurai = new SamuraiApp.Domain.Samurai { Name = "Anjou" };
            _context.Samurais.Add(samurai);
            _context.SaveChanges();
        }

        private static void GetSamurais(string text)
        {
            var samurais = _context.Samurais.ToList();
            Console.WriteLine($"Samurai count is {samurais.Count}");
            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }
    }
}
