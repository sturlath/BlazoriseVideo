using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BlazoriseVideo.Data;
using Volo.Abp.DependencyInjection;

namespace BlazoriseVideo.EntityFrameworkCore;

public class EntityFrameworkCoreBlazoriseVideoDbSchemaMigrator
    : IBlazoriseVideoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreBlazoriseVideoDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the BlazoriseVideoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<BlazoriseVideoDbContext>()
            .Database
            .MigrateAsync();
    }
}
