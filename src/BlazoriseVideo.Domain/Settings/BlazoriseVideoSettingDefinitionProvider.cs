using Volo.Abp.Settings;

namespace BlazoriseVideo.Settings;

public class BlazoriseVideoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BlazoriseVideoSettings.MySetting1));
    }
}
