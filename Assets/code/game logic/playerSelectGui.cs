using UnityEngine;
using System.Collections;

public class playerSelectGui : MonoBehaviour {


	// Our Startscreen GUI
	void OnGUI () { 
		if(GUI.Button(new Rect (30, 30, 150, 30), "select team")) {
			startGame();
		} 
	
	}


	private void startGame() {
		print("select team");

		//DontDestroyOnLoad(GameState.Instance);
		GameState.Instance.selectTeam();

		//DontDestroyOnLoad(PlayerState.Instance);
		//PlayerState.Instance.initializePlayer("Default name");

		//DontDestroyOnLoad(InventoryManager.Instance);
		//InventoryManager.Instance.initializePlayer("Default name");
	}
}
