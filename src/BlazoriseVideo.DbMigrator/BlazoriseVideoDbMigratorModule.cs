using BlazoriseVideo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace BlazoriseVideo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BlazoriseVideoEntityFrameworkCoreModule),
    typeof(BlazoriseVideoApplicationContractsModule)
    )]
public class BlazoriseVideoDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
