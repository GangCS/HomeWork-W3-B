# HomeWork-W4-B

A version of the game can be played here : <br />
https://shaharnik.itch.io/homework4-2


Computer game development assigment for week 4 question 2 <br />
We had to learn and practice boundries, collisions and triggers. <br />
Between each part we made a scence changer so with one project we can display all 3 parts.<br />
We wanted to change the theme a little bit so we made a StarCraft theme game.<br />
So we made a semi functional game where zergs are spawnning from the top of the level and the player (the Battlecrusier) and you can shoot them and destory them but they can't touch the player. <br />
#### ![StarCrat](https://upload.wikimedia.org/wikipedia/en/2/20/StarCraft_II_-_Box_Art.jpg)


**PART A** <br />
The first part was to build a flat world with "hard" boundries, walls that you can see but cannot pass.



#### ![Wall image](https://i.imgur.com/kMyWeLE.png)


The main thing is to make the walls unpassable, when the player hits the wall he is pushed back, the enemy on the other hand can pass them easily.

Example can be seen here :
https://imgur.com/tNTk1BO

Link to the Code of the collisions : 
https://github.com/GangCS/HomeWork-W4-B/blob/b7b28f8515a9d9529bf050f54ec7a57829707b1c/Assets/Scripts/Collisions/WallCollider.cs#L11-L32

**PART B** <br />
The second part was to build a flat world where object passing the camera boundires are destroyed.
So we made invisable walls outside of the camera view that would destory enemy and laser objects that touch them.
#### ![](https://i.imgur.com/JnL9OXc.png)


Example can be seen here :
https://i.imgur.com/DcGzrhN.mp4

link to the code of the object destruction:
https://github.com/GangCS/HomeWork-W4-B/blob/b7b28f8515a9d9529bf050f54ec7a57829707b1c/Assets/Scripts/Collisions/DestroyOnExitMap.cs#L12-L18

**PART C** <br />
The third part was to make a "circular" world where the moment a player is exiting one side of the screen he will appear on the opposite side.
We calculated the camera size for vertical and horizntal from the middle, each time he touches a wall he is moved to the other size so 2 times vertical or horizntal camera size to the oppsite direction.

#### ![](https://i.imgur.com/H3a4ik5.png)

Example can be seen here:
https://i.imgur.com/9hvb8DX.mp4

Link to the code can be seen here:
https://github.com/GangCS/HomeWork-W4-B/blob/b7b28f8515a9d9529bf050f54ec7a57829707b1c/Assets/Scripts/Collisions/MoveToOtherSide.cs#L5-L34
