using CodeABP.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace CodeABP.Permissions;

public class CodeABPPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(CodeABPPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(CodeABPPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<CodeABPResource>(name);
    }
}
