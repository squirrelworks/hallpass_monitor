using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class myLevelManager : MonoBehaviour {

	//define a list
	public static List <GameObject> myListObjects = new List<GameObject>();
	
	//I used this to keep track of the number of objects I spawned in the scene.
	public static int numSpawned = 0;

	public int numToSpawn=10;








	void Start()
	{
		GameState.Instance.spawnPlayers();
		/*
		Debug.Log ("level manager startup");
		//Important note: place your prefabs folder(or levels or whatever)
		//in a folder called "Resources" like this "Assets/Resources/Prefabs"
		Object[] subListObjects = Resources.LoadAll("enemies", typeof(GameObject));


		//This may be sloppy (I've only been programing for a short time)
		//It works though :)
		foreach (GameObject subListObject in subListObjects)
		{
			GameObject lo = (GameObject)subListObject;
			Debug.Log("name: "+lo.name);
			myListObjects.Add(lo);
		}

		numSpawned = 100;
		
*/

	}


	/*
	void SpawnRandomObject()
	{
		//spawns item in array position between 0 and 100
		int whichItem = Random.Range (0, myListObjects.Count);
		GameObject myObj = Instantiate (myListObjects [whichItem]) as GameObject;
		numSpawned++;
		myObj.name = "enemy_"+numSpawned;


    myObj.transform.position = new Vector3(Random.Range (-50, 50),0.5f, Random.Range (-50, 50));

	}


	void Update()
	{

		
		if (numToSpawn > numSpawned)
		{
			//where your instantiated object spawns from
			//transform.position = new Vector3(0, 0, 0);
			
			SpawnRandomObject ();
		}

		
	}
*/

	
	

}


