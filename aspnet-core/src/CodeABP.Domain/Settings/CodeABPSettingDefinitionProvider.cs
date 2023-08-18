using Volo.Abp.Settings;

namespace CodeABP.Settings;

public class CodeABPSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(CodeABPSettings.MySetting1));
    }
}
