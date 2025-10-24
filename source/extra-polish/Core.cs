using MelonLoader;

[assembly: MelonInfo(typeof(extra_polish.Core), "extra-polish", "1.0.0", "Many people (TODO, FIX)", null)]
[assembly: MelonGame("PopCap Games", "PvZ Replanted")]

namespace extra_polish
{
    public class Core : MelonMod
    {
        // TODO: Add some sort of modular system for adding fixes.
        // What I have in mind is having this class call the "Implement" method of each class in "Fixes"
        // From there, each fix can subscribe to the melon events it needs, and then do what it has to

        public override void OnEarlyInitializeMelon()
        {
            MelonLogger.Msg("Implementing fixes...");
            Fixes.LoadingScreen.Implement();
        }
    }
}