using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {


	// Declare properties
	private static GameState instance;

	public List<string> selectedTeam = new List<string>();



	private string activeLevel; // Active level
	public int gameScore=0;

	private string selectedPlayer="none";



	// --------------------------------------------------------------------------------------------------- 
	// gamestate()
	// ---------------------------------------------------------------------------------------------------
	// Creates an instance of gamestate as a gameobject if an instance does not exist
	// ---------------------------------------------------------------------------------------------------

	public static GameState Instance {

		get

		{
			if(instance == null)

			{
				instance = new GameObject("GameState").AddComponent<GameState> ();

		}
			return instance;
		}
	
	} 

	// Sets the instance to null when the application quits

	public void OnApplicationQuit() {

		instance = null;
	
	}

	// ---------------------------------------------------------------------------------------------------
	// ---------------------------------------------------------------------------------------------------
	// startState()
	// ---------------------------------------------------------------------------------------------------
	// Creates a new game state
	// ---------------------------------------------------------------------------------------------------

	public void startState() {

		activeLevel = "Level_1";



			SceneManager.LoadScene ("level_1");


	

	}

	// ---------------------------------------------------------------------------------------------------
	// ---------------------------------------------------------------------------------------------------
	// selectPlayer()
	// ---------------------------------------------------------------------------------------------------
	// Creates a new game state
	// ---------------------------------------------------------------------------------------------------

	public void selectPlayer() {
		print ("Creating a new game state");
		// Set default properties:
		activeLevel = "select player";
		// Load level 1
		SceneManager.LoadScene ("select_Player");
	}



	// ---------------------------------------------------------------------------------------------------
	// ---------------------------------------------------------------------------------------------------
	// selectTeam()
	// ---------------------------------------------------------------------------------------------------
	// Creates a new game state
	// ---------------------------------------------------------------------------------------------------

	public void selectTeam() {

		if (selectedPlayer == "none") {
			Debug.Log ("select your player first");
		}
		else{
			activeLevel = "select team";



			SceneManager.LoadScene ("select_team");

		}

	}


	// ---------------------------------------------------------------------------------------------------
	// ---------------------------------------------------------------------------------------------------
	// gameOver()
	// ---------------------------------------------------------------------------------------------------
	// ends game
	// ---------------------------------------------------------------------------------------------------




	public void gameOver() {
		print ("game over");
		// Set default properties:
		activeLevel = "game over";
		// Load level 1
		SceneManager.LoadScene ("game_over");
	}



	// ---------------------------------------------------------------------------------------------------
	// ---------------------------------------------------------------------------------------------------
	// mainScene()
	// ---------------------------------------------------------------------------------------------------
	// ends game
	// ---------------------------------------------------------------------------------------------------




	public void mainScene() {
		print ("go to main");
		// Set default properties:
		activeLevel = "main";
		// Load level 1
		SceneManager.LoadScene ("main");
	}


	// ---------------------------------------------------------------------------------------------------
	// ---------------------------------------------------------------------------------------------------
	// quitApp()
	// ---------------------------------------------------------------------------------------------------
	// ends game
	// ---------------------------------------------------------------------------------------------------




	public void quitApp() {
		Application.Quit();
	}



	// ---------------------------------------------------------------------------------------------------
	// spawnPlayers()
	// ---------------------------------------------------------------------------------------------------
	// spawns players team
	// ---------------------------------------------------------------------------------------------------


	public void spawnPlayers(){

		Debug.Log("spawning players");
		foreach( string myName in selectedTeam )
		{
			Debug.Log("instantiating: "+myName);

			GameObject myPlayer = (GameObject)Instantiate(Resources.Load("players/"+myName));
			myPlayer.name = myName;
			myPlayer.tag="teamMembers";


			//myPlayer.transform.position;
		}



	}

	// ---------------------------------------------------------------------------------------------------
	// getLevel()
	// ---------------------------------------------------------------------------------------------------
	// Returns the currently active level
	// ---------------------------------------------------------------------------------------------------

	public string getLevel() {
		
		return activeLevel;
	}

	// ---------------------------------------------------------------------------------------------------
	// setLevel()
	// ---------------------------------------------------------------------------------------------------
	// Sets the currently active level to a new value
	// ---------------------------------------------------------------------------------------------------

	public void setLevel(string newLevel) {
		// Set activeLevel to newLevel
		activeLevel = newLevel;
	} 


	// ---------------------------------------------------------------------------------------------------
	// gui stuff
	// ---------------------------------------------------------------------------------------------------
	// 
	// 


	void OnGUI() {

		//GUI.Label (new Rect (30, 100, 400, 30), "score: "+gameScore);
}


	// ---------------------------------------------------------------------------------------------------
	// player selection
	// ---------------------------------------------------------------------------------------------------
	// 
	// 
	public void selectPlayer(string playerName) {

		if(activeLevel=="select player"){
		Debug.Log ("select player: "+playerName);
		selectedPlayer=playerName;
		}

		if (activeLevel == "select team") {
			Debug.Log ("select team menber: " + playerName);
			//selectedTeam;
			selectedTeam.Add(playerName);

		}

	}

	public void deselectPlayer(string playerName) {

		if (activeLevel == "select player") {
			Debug.Log ("deselect player: " + playerName);
			selectedPlayer = "none";

		}


		if (activeLevel == "select team") {
			Debug.Log ("deselect team menber: " + playerName);
			Debug.Log ("at index: " + selectedTeam.IndexOf(playerName));

			int myIndex = selectedTeam.IndexOf (playerName);

			selectedTeam.RemoveAt(myIndex);
			//selectedTeam.Insert (myIndex, "none");

			//Debug.Log(selectedTeam[myIndex]);

		}

	}



}