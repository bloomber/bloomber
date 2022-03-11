using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Resistella.Core.Infrastructures.Data
{
    public class ResistellaContextFactory : IDesignTimeDbContextFactory<ResistellaContext>
    {
        #region public methods

        public ResistellaContext CreateDbContext(string[] args)
        {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), "Settings", "appSettings.json"));
            IConfiguration configurationRoot = configurationBuilder.Build();

            DbContextOptionsBuilder builder = new DbContextOptionsBuilder();
            ///with DB migration
            builder.UseSqlServer(configurationRoot.GetConnectionString("ResistellaDatabase"),b=>b.MigrationsAssembly("Resistella.Core.Data.Migrations"));

            ///with out DB migration
            //builder.UseSqlServer(configurationRoot.GetConnectionString("ResistellaDatabase"));
            ResistellaContext context = new ResistellaContext(builder.Options);
            return context;
        }
        #endregion
    }
}
