namespace UnboundWorldView
{
    using System;
    using Boardgame.NonVR.CameraControl;
    using HarmonyLib;

    internal static class ModPatcher
    {
        internal static void Patch(Harmony harmony)
        {
            harmony.Patch(
                original: AccessTools.Method(typeof(CameraBehaviorFocus), "Initialize"),
                postfix: new HarmonyMethod(typeof(ModPatcher), nameof(EnablePitchControl)));
        }

        private static void EnablePitchControl(ref CameraBehaviorFocus __instance, ref CameraControlSettings ___settings)
        {
            ___settings.allowManualPitchChange = true;
            ___settings.tiltVerticalFactor = ___settings.aroundRotationFactorForMouse;
        }
    }
}
