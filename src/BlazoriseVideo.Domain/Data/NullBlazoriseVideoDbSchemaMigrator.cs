using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace BlazoriseVideo.Data;

/* This is used if database provider does't define
 * IBlazoriseVideoDbSchemaMigrator implementation.
 */
public class NullBlazoriseVideoDbSchemaMigrator : IBlazoriseVideoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
