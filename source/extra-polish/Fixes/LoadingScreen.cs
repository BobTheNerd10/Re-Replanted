using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace extra_polish.Fixes
{
    internal class LoadingScreen
    {
        public /*override*/ void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            GameObject LoadBar = GameObject.Find("LoadBarAnimationParent");

            // Iterate through the Load Bar animator components (IE the animator of the loadbar sprouts and zombie head)
            foreach (UnityEngine.Animator LoadBarObject in LoadBar.GetComponentsInChildren<UnityEngine.Animator>())
            {
                /*
                  
                Sprout and Zombie positions 
                -465
                -245
                -18
                 155
                 290 

                The 4th and 5th objects need their positions in the load bar changed

                The zombie head animation is also quite choppy 
                 
                */
            }
        }
    }
}
