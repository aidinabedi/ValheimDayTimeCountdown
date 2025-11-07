using HarmonyLib;

namespace ValheimDayTimeCountdown.GamePatches
{
    [HarmonyPatch(typeof(Hud), "Awake")]
    public static class Hud_Awake_Patch
    {
        public static void Postfix(Hud __instance)
        {
            DayTimeCountdownPlugin.CreatePanel(__instance);
        }
    }
}
