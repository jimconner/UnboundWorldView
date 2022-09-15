namespace UnboundWorldView
{
    using HarmonyLib;
    using MelonLoader;

    internal class UnboundWorldView : MelonMod
    {
        internal static readonly MelonLogger.Instance Logger = new MelonLogger.Instance("UnboundWorldView");

        public override void OnApplicationStart()
        {
            Logger.Msg("In OnApplicationStart.");

            var harmony = new Harmony("com.conner.demeomods.unboundworldview");
            ModPatcher.Patch(harmony);
        }
    }
}
