// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class MyProjectAEditorTarget : TargetRules
{
	public MyProjectAEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_3;
		ExtraModuleNames.Add("MyProjectA");
	}
}
