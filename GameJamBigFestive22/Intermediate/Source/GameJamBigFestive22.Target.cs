using UnrealBuildTool;

public class GameJamBigFestive22Target : TargetRules
{
	public GameJamBigFestive22Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("GameJamBigFestive22");
	}
}
