using System;
using System.Collections.Generic;
using System.Text;
using BlazoriseVideo.Localization;
using Volo.Abp.Application.Services;

namespace BlazoriseVideo;

/* Inherit your application services from this class.
 */
public abstract class BlazoriseVideoAppService : ApplicationService
{
    protected BlazoriseVideoAppService()
    {
        LocalizationResource = typeof(BlazoriseVideoResource);
    }
}
