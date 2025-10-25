using MelonLoader;


[assembly: MelonInfo(typeof(extra_polish.Core), "extra-polish", "1.0.0", "Many people (TODO, FIX)", null)]
[assembly: MelonGame("PopCap Games", "PvZ Replanted")]

namespace extra_polish
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