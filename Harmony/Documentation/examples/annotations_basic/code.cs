using HarmonyLib;

[HarmonyPatch(typeof(SomeTypeHere))]
[HarmonyPatch("SomeMethodName")]
class MyPatches
{
	static void Postfix(/*...*/)
	{
		//...
	}
}
