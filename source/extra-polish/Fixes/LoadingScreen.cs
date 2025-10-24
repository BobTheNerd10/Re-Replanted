using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace extra_polish.Fixes
{
    internal static class LoadingScreen
    {
        public static void Implement()
        {
            // TODO, subscribe to the scene initialization event and do the things
        }

        public static void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            GameObject LoadBar = GameObject.Find("LoadBarAnimationParent");


            /*
            TODO: Write code here that iterates through the Load Bar and fixes all its problems
          
            Sprout and Zombie positions 
            -465
            -245
            -18
            155 (needs to be changed)
            290 (needs to be changed)

            The timing of the 4th and 5th object will also likely need to be changed to match the new positions

            The zombie head animation is also quite choppy 

            */
        }
    }
}
