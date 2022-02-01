using Volo.Abp.Modularity;

namespace BlazoriseVideo;

[DependsOn(
    typeof(BlazoriseVideoApplicationModule),
    typeof(BlazoriseVideoDomainTestModule)
    )]
public class BlazoriseVideoApplicationTestModule : AbpModule
{

}
