
using UnrealBuildTool;
using System.Collections.Generic;

public class MeshWidgetsEditorTarget : TargetRules
{
	public MeshWidgetsEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;

		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "MeshWidgets" } );
	}
}
