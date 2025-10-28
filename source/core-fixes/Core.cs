using MelonLoader;


[assembly: MelonInfo(typeof(core_fixes.Core), "rereplanted-core-fixes", "1.0.0", "BobTheNerd10", null)]
[assembly: MelonGame("PopCap Games", "PvZ Replanted")]

namespace core_fixes
{
    public class Core : MelonMod
    {
        public override void OnEarlyInitializeMelon()
        {
            MelonLogger.Msg("Implementing fixes...");
            Fixes.LoadingScreen.Implement();
        }
    }
}