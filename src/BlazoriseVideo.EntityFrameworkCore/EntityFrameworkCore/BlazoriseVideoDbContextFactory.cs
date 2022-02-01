using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BlazoriseVideo.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class BlazoriseVideoDbContextFactory : IDesignTimeDbContextFactory<BlazoriseVideoDbContext>
{
    public BlazoriseVideoDbContext CreateDbContext(string[] args)
    {
        BlazoriseVideoEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<BlazoriseVideoDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new BlazoriseVideoDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../BlazoriseVideo.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
