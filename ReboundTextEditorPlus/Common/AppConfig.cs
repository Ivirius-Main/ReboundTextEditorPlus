using Nucs.JsonSettings;
using Nucs.JsonSettings.Modulation;

namespace ReboundTextEditorPlus.Common;
public class AppConfig : JsonSettings, IVersionable
{
    [EnforcedVersion("4.0.0.21")]
    public virtual Version Version { get; set; } = new Version(4, 0, 0, 21);

    public override string FileName { get; set; } = Constants.AppConfigPath;


    // Docs: https://github.com/Nucs/JsonSettings
}
