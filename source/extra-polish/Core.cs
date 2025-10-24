using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(extra_polish.Core), "extra-polish", "1.0.0", "BobTheNerd10", null)]
[assembly: MelonGame("PopCap Games", "PvZ Replanted")]

namespace extra_polish
{
    public class Core : MelonMod
    {
        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {

        }
    }
}