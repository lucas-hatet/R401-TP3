using System.Xml;
using System.Linq;
using TP3Console.Models.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace TP3Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new FilmsDbContext())
            {
                // ctx.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
                Film titanic = ctx.Films.AsNoTracking().First(f => f.Nom.Contains("Titanic"));
                titanic.Description = "Un bateau échoué. Date : " + DateTime.Now;
                int nbchanges = ctx.SaveChanges();
                Console.WriteLine("Nombre d'enregistrements modifiés ou ajoutés : " + nbchanges);
            }
        }
    }
}
