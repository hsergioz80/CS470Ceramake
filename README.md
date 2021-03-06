# CS470HoloLensProject

11/28/2018:
- Added purely visual lock/unlock images along both sides of video title area to indicate when the window is locked (or unlocked) from a gaze position
- Added a button click sound for most buttons (having an issue getting it to work on things like the skip fwd and skip back images...
- Still need to duplicate video scenes but, shouldn't take long to do later today
- Fixed issues with skip forward, skip back, play and pause functionality, finally

11/27/2018:
- Got Playing and Pausing videos working!  A new script "PlayPauseVideo" is attached to the VideoPlayer object now that, on a click, finds the video that's playing, and pauses
it if it's playing, or resumes playing if it was paused.  The user must click anywhere on the video to do this but, it'd be really easy to make it so they can actually click
anywhere off screen as well.  I did it that way initially (by accident) but figured it could potentially mess with some of the other button functions.
- Got Play and Pause buttons overlayed on the video for when a user hovers or clicks to play or pause...working on skip forward and skip back function...
- Got skipping Forward and Backward implemented ("SkipForwardBackward" script applied to transparent SkipBack and SkipForward buttons)
- One thing I'd like to do is show the video progress in the form of "current time/total time" but, it's not critical
- Just need to duplicate video scenes and add buttons for them on tutorial menu and this is done!

11/26/2018 (2) (some fixes, "X" placed next to done items below):
- cursor actually fixed now on menus
- music restarts on Tutorial Menu screen when returning from video
- adjusted positioning of Tutorials menu
- Tagalong and Billboard scripts remain in existing video scene BUT, are used differently now... (see below)

So, in attempting to allow the user to manipulate and move the video window around, I encountered a slew of compilation errors when importing the necessary scripts.  Each
one I added, brought more errors with it.  After an hour, I got the errors down to 2 before I hit the final roadblock.  2 hours later trying to get passed it and I had gotten
nowhere.

So, I was ready to scrap the feature altogether when I thought to myself, "Why not leave the Tagalong scripts in place, but allow the user to disable them when they've gazed to
a position where they'd like the video to remain?"  Thus, the "AchorVideo" script was born.  It's applied to the "CenteringTitle" button which was previously disabled as a button
since I was simply using it to display the title of the video, but now, when the user clicks on it, it disables all the Tagalong-related scripts on the Canvas, leaving everything
in place.  When clicked again, it re-enables those scripts and everything follows your gaze once more.  It's not nearly as robust (or cool) as grabbing it with your hand and moving
it around but...it's a super simple solution that does mostly what we want.

_________________________________________________________



11/26/2018 (1):

Confirmed features and scenes of current build all work as expected in HoloLens, though I was reminded of some other tasks to be done:

- (X) Fix cursor so it appears all the time on menu screens (it appears just fine on the "Centering" scene so I'm certain it has to do with the fact that there is a 3D object
present, and gazing at it is what triggers the cursor to be displayed)

- (X) Optional: music doesn't restart when returning "Back" from the "Centering" scene to the "Tutorials" menu.  This whole persistance of the music playing throughout the menus
thing was tricky to figure out so this could be tricky as well but, should be doable (though not the most important thing to focus on)

- (X) Make some minor adjustments to positioning of Tutorials menu - move it slightly lower, as it gets displayed slightly higher out of view when loading compared to the position
of the main menu

_________________________________________________________

11/25/2018 (some things to be done):
- (X) remove tagalong and billboard scripts for the video scenes as we don't want those following the user's gaze

- (X) add features/scripts to allow user to play and pause video by clicking on it (should be easily done by placing an invisible button ontop of/in front of the video display and
making an OnClick script to govern the playing and pausing) (bonus: add voice recognition for playing and pausing!)

- (X) add features/scripts to allow user to navigate through the video incrementally (maybe forward/backward movement 10 seconds at a time) (bonus: voice recognition for this)

- (X) allow user to move and rotate video scenes



Once above stuff has been done (or at least, once we've done what we can) on the existing "Centering" scene:

- Duplicate "Centering" scene for the remaining tutorial videos, swap in the videos to those scenes

- Add buttons to tutorial menu for those scenes

- Should be essentially done at this point...


_________________________________________________________



10/31/2018 (initial commit):

- Unity project includes the "App" folder with VS stuff in it.  When building from Unity, just build to that folder, it'll overwrite everything there with new VS files.


- Ignore OrigamiCollection in the Unity Hierarchy for now (it's disabled), it's part of a tutorial I did and has some useful scripts I think we may need so, keeping it
in the project for now, just turned off.


- I discovered that the "distance" of the buttons and logo from the camera don't matter in terms of how big it appears to us through the HoloLens, it's a combination of the
"Scale" attributes for the Canvas object, as well as the Logo and buttons within.  Everything should be a good size now (verified through emulator).


- If you're gonna try and work on different screens (i.e. whatever gets displayed when you click into Tutorials, or Settings, etc), this involves making a new "Scene" in Unity.  You
can re-use anything in the hierarchy for the scene, arrange it and modify how you want, then just "Save Scene As" something different than the main scene.  Then, through a script
(probably attached to the Cursor object) via a function like "OnSelect()" (or possibly something else) you'll have some kind of call to the SceneManager class, and invoke LoadScene with
the name of the scene you want to transition to when a given thing is clicked.  It might help to do some tutorials on some of those functions/features to understand how they work a bit.