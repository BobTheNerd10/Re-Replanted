using MelonLoader;

[assembly: MelonInfo(typeof(pvz_logging.Core), "pvz-logging", "1.0.0", "BobTheNerd10", null)]
[assembly: MelonGame("PopCap Games", "PvZ Replanted")]

namespace pvz_logging
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("OnApplicationStart");
        }

        public override void OnLateInitializeMelon() // Runs after OnApplicationStart.
        {
            MelonLogger.Msg("OnApplicationLateStart");
        }

        public override void OnSceneWasLoaded(int buildindex, string sceneName) // Runs when a Scene has Loaded and is passed the Scene's Build Index and Name.
        {
            MelonLogger.Msg("OnSceneWasLoaded: " + buildindex.ToString() + " | " + sceneName);
        }

        public override void OnSceneWasInitialized(int buildindex, string sceneName) // Runs when a Scene has Initialized and is passed the Scene's Build Index and Name.
        {
            MelonLogger.Msg("OnSceneWasInitialized: " + buildindex.ToString() + " | " + sceneName);
        }

        public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
        {
            MelonLogger.Msg("OnSceneWasUnloaded: " + buildIndex.ToString() + " | " + sceneName);
        }

        public override void OnApplicationQuit() // Runs when the Game is told to Close.
        {
            MelonLogger.Msg("OnApplicationQuit");
        }

        public override void OnPreferencesSaved() // Runs when Melon Preferences get saved.
        {
            MelonLogger.Msg("OnPreferencesSaved");
        }

        public override void OnPreferencesLoaded() // Runs when Melon Preferences get loaded.
        {
            MelonLogger.Msg("OnPreferencesLoaded");
        }
    }
}