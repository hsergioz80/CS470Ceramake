# CS470HoloLensProject


10/31/2018 (initial commit):
- Unity project includes the "App" folder with VS stuff in it.  When building from Unity, just build to that folder, it'll overwrite everything there with new VS files.

- Ignore OrigamiCollection in the Unity Hierarchy for now (it's disabled), it's part of a tutorial I did and has some useful scripts I think we may need so, keeping it in the project for now, just turned off.

- I discovered that the "distance" of the buttons and logo from the camera don't matter in terms of how big it appears to us through the HoloLens, it's a combination of the "Scale" attributes for the Canvas object, as well as the Logo and buttons within.  Everything should be a good size now (verified through emulator).

- If you're gonna try and work on different screens (i.e. whatever gets displayed when you click into Tutorials, or Settings, etc), this involves making a new "Scene" in Unity.  You can re-use anything in the hierarchy for the scene, arrange it and modify how you want, then just "Save Scene As" something different than the main scene.  Then, through a script (probably attached to the Cursor object) via a function like "OnSelect()" (or possibly something else) you'll have some kind of call to the SceneManager class, and invoke LoadScene with the name of the scene you want to transition to when a given thing is clicked.  It might help to do some tutorials on some of those functions/features to understand how they work a bit.
