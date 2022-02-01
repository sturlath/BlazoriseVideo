using BlazoriseVideo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BlazoriseVideo.Permissions;

public class BlazoriseVideoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(BlazoriseVideoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(BlazoriseVideoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<BlazoriseVideoResource>(name);
    }
}
