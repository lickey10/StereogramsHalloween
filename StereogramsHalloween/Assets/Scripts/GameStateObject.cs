//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;

namespace HappyPlane
{
	[Serializable]
	public class GameStateObject
	{
		public int activeLevel = 1;                     // Active level
		public int levelProgress = 1;					//the max level the have achieved
		public int numberOfLevels = 1;						//the number of levels that exist in the game
		public int score = 0;							//the current game score
		public int highScore = 0;						//the highScore for the game since install
		public int lives = 3;							//the number of lives the player has
		public int health = 1;
		public bool gameRunning = false;				//whether the game is actually being played or not

		public GameStateObject ()
		{
			activeLevel = gamestate.Instance.getActiveLevel();                     // Active level
			levelProgress = gamestate.Instance.getLevelProgress();					//the max level the have achieved
			numberOfLevels = gamestate.Instance.GetNumberOfLevels();						//the number of levels that exist in the game
			score = gamestate.Instance.getScore();							//the current game score
			highScore = gamestate.Instance.getHighScore();						//the highScore for the game since install
			lives = gamestate.Instance.getLives();							//the number of lives the player has
			health = gamestate.Instance.GetHealth();
			gameRunning = gamestate.Instance.IsGameRunning();
		}
	}
}

