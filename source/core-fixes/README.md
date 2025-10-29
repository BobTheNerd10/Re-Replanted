# Info about Core-Fixes
This project contains the main heavy-lifting when it comes to fixing Replanted's issues. 

## How it's structured
- The "Core.cs" file is the file that contains the Melon. (That's what MelonLoader calls its mods.) It loads all of the C# files in the "Fixes/" folder
- The files in the "Fixes/" folder contain bugfixes divided by topic. Eg, "LoadingScreen.cs" contains all of the bug fixes related to the loading screen!
- The files in the "Fixes/" folder all have their own "Implement()" function which enables all the functionality of the file. 
- The files in the "Fixes/" folder subscribe to MelonEvents to call code at the relevant times
If you're adding a new cs file, make sure to add the Implement() function to core.cs when you're done!

## Conventions
- When adding a new fix, please add a description of the bug you're fixing as a comment near the top of the file.
- It is strongly recommended for fixes to be static. This is to avoid unnecessary instantiation. (If there's a reason it can't be static, let Bob know!)