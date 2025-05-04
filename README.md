# Welcome!

## Description:
This is a 3D top-down shooting game where the player controls a tank that engages in combat with enemy tanks.
The objective is to destroy enemy tanks to earn points. Each enemy tank requires three hits to be destroyed. 
Similarly, the player's tank can withstand three collisions with enemy tanks before being destroyed, resulting in game over. 
A health bar is displayed above the player's tank to indicate its remaining durability.

## Player Tank:
The player tank can move left and right using the 'A' and 'D' keys. 
The tank barrel can rotate along the X-axis using mouse input, allowing for precise aiming. 
Pressing the Spacebar fires a bullet from the barrel. 
The player tank has three lives, and it is destroyed after sustaining three collisions with enemy tanks.

## Enemy Tank:
Enemy tanks spawn continuously in a random pattern along the road and accelerate toward the player's tank. 
Upon collision, an enemy tank self-destructs and deducts one life from the player. 
Each enemy tank requires three bullet hits to be destroyed and also has three lives.

## Map:
The map consists of a road and various vehicles, all of which are assets imported from the Unity Asset Store.

## Bullet:
Bullets are fired from the position of the tank barrel. 
Each bullet has a lifespan of three seconds before self-destruction and can only destroy enemy tanks upon collision.

## Walls:
There are three walls on the map. 
The side walls prevent the player tank from falling off the road, while the back wall destroys enemy tanks that collide with it.

## Score System:
The player earns 1 point for each enemy tank destroyed.
