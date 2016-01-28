using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour {

	// Declare properties
	private static PlayerState instance;
	
	private string activeLevel; // Active level
	private string playerName; // Characters name
	private int maxHP; // Max HP
	private int maxMP; // Map MP
	private int hp; // Current HP
	private int mp; // Current MP
	// --------------------------------------------------------------------------------------------------- 
	// gamestate()
	// ---------------------------------------------------------------------------------------------------
	// Creates an instance of PlayerState as a gameobject if an instance does not exist
	// ---------------------------------------------------------------------------------------------------
	
	public static PlayerState Instance {
		
		get
			
		{
			if(instance == null)
				
			{
				instance = new GameObject("PlayerState").AddComponent<PlayerState> ();
				
			}
			return instance;
		}
		
	} 
	
	// Sets the instance to null when the application quits
	
	public void OnApplicationQuit() {
		
		instance = null;
		
	}

	// ---------------------------------------------------------------------------------------------------


	public void initializePlayer(string myName){
		playerName = myName;

		resetPlayerStats();
}
	// ---------------------------------------------------------------------------------------------------

	void resetPlayerStats(){
		print ("resetting player stats");
		maxHP = 250;
		maxMP = 60;
		hp = maxHP;
		mp = maxMP;
	}

	// ---------------------------------------------------------------------------------------------------



	// setters and getters

	
	// ---------------------------------------------------------------------------------------------------
	// getName()
	// ---------------------------------------------------------------------------------------------------
	// Returns the characters name
	// ---------------------------------------------------------------------------------------------------
	
	public string getName() {
		return playerName;
	}
	
	// ---------------------------------------------------------------------------------------------------
	// getHP()
	// ---------------------------------------------------------------------------------------------------
	// Returns the characters hp
	// ---------------------------------------------------------------------------------------------------
	
	public int getHP() {
		return hp;
	}
	
	// ---------------------------------------------------------------------------------------------------
	// getMP()
	// ---------------------------------------------------------------------------------------------------
	// Returns the characters mp
	// ---------------------------------------------------------------------------------------------------
	
	public int getMP() {
		return mp;
	}
}
