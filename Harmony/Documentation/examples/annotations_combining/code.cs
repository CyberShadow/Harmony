using HarmonyLib;

[HarmonyPatch(typeof(SomeType))]
class MyPatches1
{
	[HarmonyPatch("SomeMethod1")]
	static void Postfix() { }

	[HarmonyPatch("SomeMethod2")]
	static void Postfix() { }
}

[HarmonyPatch(typeof(TypeA))]
class MyPatches2
{
	[HarmonyPatch("SomeMethod1")]
	static void Prefix() { }

	[HarmonyPatch("SomeMethod2")]
	static void Prefix() { }

	[HarmonyPatch(typeof(TypeB), "SomeMethod1")]
	static void Postfix() { }
}

[HarmonyPatch]
class MyPatches3
{
	[HarmonyPatch(typeof(TypeA), "SomeMethod1")]
	static void Prefix() { }

	[HarmonyPatch(typeof(TypeB), "SomeMethod2")]
	static void Postfix() { }

	[HarmonyPatch(typeof(TypeC), "SomeMethod3")]
	static void Finalizer() { }
}
