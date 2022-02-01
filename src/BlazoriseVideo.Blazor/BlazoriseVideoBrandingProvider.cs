using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace BlazoriseVideo.Blazor;

[Dependency(ReplaceServices = true)]
public class BlazoriseVideoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "BlazoriseVideo";
}
