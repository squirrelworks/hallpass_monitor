using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class circleSelector : MonoBehaviour {


	public float speed = 1;
	private GameObject endRotation;

	public GameObject spawnPointer;
	public float circleRadius=6.0f;

	public static List <GameObject> myListObjects = new List<GameObject>();


	private int num_Objects=0;
	private float angle =  360f/5;


	void Start () {
		endRotation = new GameObject();


		//Important note: place your prefabs folder(or levels or whatever)
		//in a folder called "Resources" like this "Assets/Resources/Prefabs"
		Object[] subListObjects = Resources.LoadAll("players", typeof(GameObject));


		//This may be sloppy (I've only been programing for a short time)
		//It works though :)

		foreach (GameObject subListObject in subListObjects)
		{
			GameObject lo = (GameObject)subListObject;
			myListObjects.Add(lo);
			num_Objects++; 
		}

		angle =  360f/num_Objects;


		spawnPointer.transform.position += new Vector3(0,0,circleRadius);

		Vector3 objectPos = spawnPointer.transform.position;

	
		while (num_Objects>0) {


			GameObject go;




             go=Instantiate (myListObjects[num_Objects-1], objectPos, transform.rotation)as GameObject;

			go.name = myListObjects [num_Objects - 1].name;
			go.GetComponent<followTarget>().enabled=false;
             num_Objects--;
			spawnPointer.transform.RotateAround (transform.position, Vector3.up, angle);
			objectPos=spawnPointer.transform.position;


			go.transform.parent=transform;
		}
	}
	



	void Update () {
		
	
		if( Input.GetKeyDown( KeyCode.RightArrow ) ){
			endRotation.transform.Rotate(Vector3.up, angle, Space.World);
		}

		if( Input.GetKeyDown( KeyCode.LeftArrow ) ){
			endRotation.transform.Rotate(Vector3.up, -angle, Space.World);
		}


		this.transform.rotation = Quaternion.Lerp(this.transform.rotation, endRotation.transform.rotation, Time.deltaTime*speed);




	}
}



