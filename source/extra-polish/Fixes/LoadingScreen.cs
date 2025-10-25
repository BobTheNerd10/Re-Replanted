using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using MelonLoader;

namespace extra_polish.Fixes
{
    internal static class LoadingScreen
    {
        public static void Implement()
        {
            MelonEvents.OnSceneWasLoaded.Subscribe(OnSceneWasLoaded);
        }

        public static void OnSceneWasLoaded(int buildIndex, string sceneName)
        {

            if (sceneName != "Bootstrap") return; // Only run this code on the loading screen

            // Get the loading bar, and then its children
            // NOTE: Apparently, it's better to iterate through gameobjects based on their components.
            // I think it's kinda silly, but whatevs, standards are standards
            GameObject LoadBar = GameObject.Find("LoadBarAnimationParent");

            UnityEngine.Animator[] Animators = LoadBar.GetComponentsInChildren<UnityEngine.Animator>();

            // Iterate through the loadbar components to find the ones that need fixing, and then fix them
            foreach (UnityEngine.Animator LoadBarAnimator in Animators)
            {
                var Xposition = LoadBarAnimator.gameObject.transform.localPosition.x;
                Vector3 objPosition;

                switch (Xposition)
                {
                    case 155:
                        MelonLogger.Msg("Implementing sprout fix...");
                        objPosition = LoadBarAnimator.gameObject.transform.localPosition;
                        objPosition.x = 185; // Change to the correct position
                        LoadBarAnimator.gameObject.transform.localPosition = objPosition;

                        break;

                    case 290:
                        MelonLogger.Msg("Implementing head fix...");
                        objPosition = LoadBarAnimator.gameObject.transform.localPosition;
                        objPosition.x = 400; // Change to the correct position
                        LoadBarAnimator.gameObject.transform.localPosition = objPosition;

                        break;
                }
            }
            /*
            TODO: Write code here that iterates through the Load Bar and fixes all its problems
         
            The timing of the 4th and 5th object will also likely need to be changed to match the new positions

            The zombie head animation is also quite choppy 

            */
        }
    }
}
