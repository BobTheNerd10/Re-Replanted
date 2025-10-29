using UnityEngine;
using MelonLoader;
using Il2CppTekly;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace core_fixes.Fixes
{
    internal static class LoadingScreen
    {
        /*
            Changes Implemented:
            
            Changing the positions of the sprout and zombie head on the loading screen to their correct positions 
            (And also retiming the animations to match their new positions)
         
        */


        public static void Implement()
        {
            // Fix the loading bar's visuals for the 4th and 5th objects (sprout and zombie head)
            MelonEvents.OnSceneWasLoaded.Subscribe(OnSceneWasLoaded);
        }

        // For fixing the loading bar's visuals for the 4th and 5th objects (sprout and zombie head)
        private static void OnSceneWasLoaded(int _buildIndex, string sceneName)
        {
            // Only run this code on the loading screen
            if (sceneName != "Bootstrap") return;

            // Get The PanelViewContainer game obejct. It contains all the objects that are rendered to the screen
            var PanelViewContainer = GameObject.FindFirstObjectByType<Il2CppTekly.PanelViews.PanelViewContainer>();
            if (PanelViewContainer == null) { MelonLogger.Error("PanelViewContainer not found!"); return; }

            Il2CppArrayBase<UnityEngine.Animator> LoadBarAnimatorComponents = PanelViewContainer.GetComponentsInChildren<UnityEngine.Animator>();

            MelonLogger.Msg(LoadBarAnimatorComponents.Count);


            Transform childTransform;

            // Iterate through the loadbar's child object's components to find the objects with "Animator" components. (IE, what we need)
            foreach (var LoadBarAnimatorComponent in LoadBarAnimatorComponents)
            {

                childTransform = LoadBarAnimatorComponent.gameObject.transform;

                // If child doesn't have the animator component, check next one (because only sprouts and the zombie head have it) 
                if (!childTransform.TryGetComponent<Animator>(out _)) continue;

                // Fix the X positions
                switch (childTransform.localPosition.x)
                {
                    case 155:
                        // Change to the correct position (It needs to be done this way because
                        //   Unity is stupid and doesn't let you modify the xyz values directly)
                        childTransform.localPosition = new Vector3(185, childTransform.localPosition.y, childTransform.localPosition.z);
                        break;

                    case 290:
                        // Change to the correct position (It needs to be done this way because
                        //   Unity is stupid and doesn't let you modify the xyz values directly)
                        childTransform.localPosition = new Vector3(185, childTransform.localPosition.y, childTransform.localPosition.z);
                        break;
                }

                /*
         
                The timing of the 4th and 5th object will also likely need to be changed to match the new positions

                The zombie head animation is also quite choppy 

                */
            }
        }
    }
}
