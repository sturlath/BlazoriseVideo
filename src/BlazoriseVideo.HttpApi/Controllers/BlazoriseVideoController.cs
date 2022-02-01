using BlazoriseVideo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BlazoriseVideo.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BlazoriseVideoController : AbpControllerBase
{
    protected BlazoriseVideoController()
    {
        LocalizationResource = typeof(BlazoriseVideoResource);
    }
}
