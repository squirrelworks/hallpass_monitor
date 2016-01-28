using UnityEngine;
using System.Collections;

public class sceneController : MonoBehaviour {


	public void changeScene(string myScene) {
		

		switch (myScene)
		{

		case "select player":
			DontDestroyOnLoad (GameState.Instance);
			GameState.Instance.selectPlayer ();
			break;

		case "select team":
			
			GameState.Instance.selectTeam ();

			break;

		case "start game":

			GameState.Instance.startState ();

			break;

		case "main":

			GameState.Instance.mainScene ();

			break;

		case "quit":

			GameState.Instance.quitApp ();

			break;

		


		}



		//DontDestroyOnLoad(PlayerState.Instance);
		//PlayerState.Instance.initializePlayer("Default name");

		//DontDestroyOnLoad(InventoryManager.Instance);
		//InventoryManager.Instance.initializePlayer("Default name");
	}
}
