using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour {


	// Declare properties

	private bool displayBackpack = true;
	private Dictionary<int,Hashtable> myInventory = new Dictionary<int,Hashtable>();

	private static InventoryManager instance;


	//private string activeLevel; // Active level


	// --------------------------------------------------------------------------------------------------- 
	// gamestate()
	// ---------------------------------------------------------------------------------------------------
	// Creates an instance of gamestate as a gameobject if an instance does not exist
	// ---------------------------------------------------------------------------------------------------

	public static InventoryManager Instance {

		get

		{
			if(instance == null)

			{
				instance = new GameObject("InventoryManager").AddComponent<InventoryManager> ();

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
	// OnGUI()
	// ---------------------------------------------------------------------------------------------------
	// show/hide backpack or inventory
	// ---------------------------------------------------------------------------------------------------



	void OnGUI() {
		
		
		if (displayBackpack) {
			
			GUI.Label (new Rect (30, 100, 400, 30), "backpack");
			if (GUI.Button (new Rect (30, 30, 150, 30), "hide backpack")) {
				displayBackpack = false;
			}
		}
		else{
			if (GUI.Button (new Rect (30, 30, 150, 30), "show backpack")) {
				displayBackpack=true;
			}
			
		}

		
	}



	// ---------------------------------------------------------------------------------------------------
	// ---------------------------------------------------------------------------------------------------
	// startState()
	// ---------------------------------------------------------------------------------------------------
	// Creates a new game state
	// ---------------------------------------------------------------------------------------------------

	public void resetInventory() {
		print ("Creating a new inventory");

	}
	


	// ---------------------------------------------------------------------------------------------------
	// addItem()
	// ---------------------------------------------------------------------------------------------------
	// adds picked up item to inventory  and destroys it in world
	// ---------------------------------------------------------------------------------------------------

	public void addItem(GameObject myPickup, Hashtable pickupProperties) {

		int intemNumber = myInventory.Count+1; 

		myInventory.Add(intemNumber,pickupProperties);

		//Hashtable latestAdded = myInventory [intemNumber];

		Destroy(myPickup);
	} 


}

