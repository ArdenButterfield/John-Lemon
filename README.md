# Project 2 (John Lemon's Haunted Jaunt)

## Project Members and Contributions

Arden Butterfield: 
- Getting started section
- Enimies part 1 and 2 sections
- Audio section
- Linear interpolation element
- particle effect

## Dot Product Element

## Linear Interpolation Element

Linear interpolation is used to change the color of the bubble particles on the ghosts. There are two colors, stored as vectors in the script. We take a sine of time, and rescale it to be between 0 and 1 instead of between -1 and 1, and use those changing sine values to smoothly interpolate from the first color to the second color, and back again.

## Particle Effect

There are two simple particle effects used in this game. One effect uses moving particle "bubbles" that come out of the back side of the ghosts. The particles shrink over their lifetime.

The other particle effect is "footsteps" left by John as he walks around. This lets the player clearly see where they've been, to help them find the exit.