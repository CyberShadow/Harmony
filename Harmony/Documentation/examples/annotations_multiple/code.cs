using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;

[HarmonyPatch] // make sure Harmony inspects the class
class MyPatches
{
	IEnumerable<MethodBase> TargetMethods()
	{
		return AccessTools.GetTypesFromAssembly(MyCode.someAssembly)
			.SelectMany(type => type.GetMethods())
			.Where(method => method.ReturnType != typeof(void) && method.Name.StartsWith("Player"))
			.Cast<MethodBase>();
	}

	// prefix all methods in someAssembly with a non-void return type and beginning with "Player"
	static void Prefix(MethodBase __originalMethod)
	{
		// use __originalMethod to decide what to do
	}
}
