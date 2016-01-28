using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {

	/*
	// Our Startscreen GUI
	void OnGUI () { 
		if(GUI.Button(new Rect (30, 30, 150, 30), "Start Game")) {
			startGame();
		} 
	
	}

	*/
	public void startGame() {
		print("Starting game");

		DontDestroyOnLoad(GameState.Instance);
		GameState.Instance.selectPlayer();

		//DontDestroyOnLoad(PlayerState.Instance);
		//PlayerState.Instance.initializePlayer("Default name");

		//DontDestroyOnLoad(InventoryManager.Instance);
		//InventoryManager.Instance.initializePlayer("Default name");
	}
}
