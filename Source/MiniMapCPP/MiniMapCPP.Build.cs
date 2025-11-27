// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MiniMapCPP : ModuleRules
{
	public MiniMapCPP(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MiniMapCPP",
			"MiniMapCPP/Variant_Platforming",
			"MiniMapCPP/Variant_Platforming/Animation",
			"MiniMapCPP/Variant_Combat",
			"MiniMapCPP/Variant_Combat/AI",
			"MiniMapCPP/Variant_Combat/Animation",
			"MiniMapCPP/Variant_Combat/Gameplay",
			"MiniMapCPP/Variant_Combat/Interfaces",
			"MiniMapCPP/Variant_Combat/UI",
			"MiniMapCPP/Variant_SideScrolling",
			"MiniMapCPP/Variant_SideScrolling/AI",
			"MiniMapCPP/Variant_SideScrolling/Gameplay",
			"MiniMapCPP/Variant_SideScrolling/Interfaces",
			"MiniMapCPP/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
