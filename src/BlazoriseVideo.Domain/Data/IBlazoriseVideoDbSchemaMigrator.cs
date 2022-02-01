using System.Threading.Tasks;

namespace BlazoriseVideo.Data;

public interface IBlazoriseVideoDbSchemaMigrator
{
    Task MigrateAsync();
}
