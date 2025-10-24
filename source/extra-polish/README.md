# Info about Extra-Polish
This project contains the main heavy-lifting when it comes to fixing Replanted's issues. 

## How it's structured
- The "Core.cs" file is the file that contains the Melon. (That's what MelonLoader calls its mods.) It loads all of the C# files in the "Fixes/" folder
- The files in the "Fixes/" folder contain bugfixes divided by topic into different files. Eg, "LoadingScreen.cs" contains all of the bug fixes related to the loading screen!
- The files in the "Fixes/" folder use MelonEvents to call code (with the exception of OnEarlyMelonInitialize. Refer to an existing file for an example.
- The files in the "Fixes/" folder all have their own "Implement()" function which enables all the functionality of the file. 

## How to add new bug fixes
- Either modify an existing file in the "Fixes/" folder, or create an entirely new one. Just remember to add your "Implement()" function into Core.cs when you're done!
