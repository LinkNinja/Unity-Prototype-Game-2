# Unity-Prototype-Game-2
This game is a prototype created from Unity Create with code series on Unitylearn.com. This prototype offers an overhead perspective for the player. The player takes control of a non animated farmer. The farmer is constrained to the bottom half of the screen. The player is only able to move the farmer from left to right. The objective of the game is to avoid the incoming animals. You can also fight back against the animals by throwing a piece of food at the them with the space bar.
Three different animals are spawned at the top of the screen and will begin moving towards the bottom where the player is positioned. The animals are spawned at random points at the top of the map. They only move in one direction once spawned. The three different animals that are spawning all have varying speeds. 
There is no sound, GUI, or game over screen. 

Things I Learned.
1.	How to set up a prefab to use later
2.	How to create an array of Game Objects for the animal prefabs to used within the spawn manager script
3.	Wrote a spawn manager script that held logic for spawning the animals at the position located above the map. This was done using the Z and X positions.
4.	Wrote a function SpawnRandomAnimal function to control the logic of spawning animals.
5.	Used the unity method InvokeRepeating along with my SpawnRandomAnimal function.
6.	Wrote a player controller script to control where the player can move up to and where the logic is contained to shoot the food from the player towards the animals. This script instantiates the projectileprefab.
7.	Wrote a move forward script that is attached onto the animals prefabs that tells the animals where to move to.
8.	Wrote a detect collisions script that uses the OnTriggerEnter method and destroys the animal along with the food that collided with it. 
9.	Wrote a destroy out of bound script that will eliminate any objects that move past the determined points within the logic of the script. 


Things I want to Add
1.	Game Over Screen
2.	Pause screen
3.	Restart button
4.	Score Counter
5.	Fix bugs and issues
6.	Animate player
7.	Insert sounds and music.


