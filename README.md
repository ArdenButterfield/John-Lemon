# Project 2 (John Lemon's Haunted Jaunt)

## Project Members and Contributions

Arden Butterfield: 
- Getting started section
- Enimies part 1 and 2 sections
- Audio section
- Linear interpolation element
- particle effect

Donny Ebel:
-Character movement
-The Environment
-The Camera
-Ending the Game
-Dot matrix


## Dot Product Element

I used a dot product to create a one-way trigger near the starting point, displaying the game title. It will show the text for two seconds only if you are moving forward. I take the John Lemon's vector and subtract the trigger's forward vector, yielding a new one that points from the head of the player's vector to the trigger's. I then call Unity's dot matrix function with the trigger's forward vector and the head-to-head vector. This function returns the magnitudes of those vectors multiplied together with the cosine of theta (of the angle between them). This is a float between 0 and 1. I then test to see if the result is less than 0. If it is, this means John is facing the same direction as the trigger, and is therefore walking the correct direction. If you walk backwards over the trigger, the text will not display. I do not destroy the object, so if you walk forward again the text will re-trigger.

## Linear Interpolation Element

Linear interpolation is used to change the color of the bubble particles on the ghosts. There are two colors, stored as vectors in the script. We take a sine of time, and rescale it to be between 0 and 1 instead of between -1 and 1, and use those changing sine values to smoothly interpolate from the first color to the second color, and back again.

## Particle Effect

There are two simple particle effects used in this game. One effect uses moving particle "bubbles" that come out of the back side of the ghosts. The particles shrink over their lifetime.

The other particle effect is "footsteps" left by John as he walks around. This lets the player clearly see where they've been, to help them find the exit.