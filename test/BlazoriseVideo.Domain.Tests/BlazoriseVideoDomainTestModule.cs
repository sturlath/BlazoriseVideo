using BlazoriseVideo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace BlazoriseVideo;

[DependsOn(
    typeof(BlazoriseVideoEntityFrameworkCoreTestModule)
    )]
public class BlazoriseVideoDomainTestModule : AbpModule
{

}
