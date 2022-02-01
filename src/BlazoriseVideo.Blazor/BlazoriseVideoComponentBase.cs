using BlazoriseVideo.Localization;
using Volo.Abp.AspNetCore.Components;

namespace BlazoriseVideo.Blazor;

public abstract class BlazoriseVideoComponentBase : AbpComponentBase
{
    protected BlazoriseVideoComponentBase()
    {
        LocalizationResource = typeof(BlazoriseVideoResource);
    }
}
