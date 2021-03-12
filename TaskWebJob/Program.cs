using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using TaskWebJob.Data;
using TaskWebJob.Repositories;

namespace TaskWebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string cnn = "Data Source=sqltajamartete.database.windows.net;Initial Catalog=TETEDB;Persist Security Info=True;User ID=adminsql;Password=Admin123";
            var provider = new ServiceCollection().AddTransient<RepositoryWebJob>().AddDbContext<WebJobContext>(options =>
            options.UseSqlServer(cnn)).BuildServiceProvider();
            RepositoryWebJob repo = provider.GetService<RepositoryWebJob>();
            Console.WriteLine("PULSE UNA TECLA PARA INICIAR");
            //Console.ReadLine();
            repo.PopulateDataWebJob();
            Console.WriteLine("PROCESO TERMINADO. PULSE ENTER PARA FINALIZAR");
            //Console.ReadLine();
        }
    }
}
