using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class pickUp : MonoBehaviour {

	public string collisionTag="Player";

	public string itemName="unknown";

	public string myCategory="unknown";
	public float foodValue=10;
	public float weightValue=10;

	/*public Dictionary<string,float> myProperties = new Dictionary<string, float> {
		{"foodvalue", 100f},
		{"weight", 50f}
	}; 
	*/

	public Hashtable myProperties = new Hashtable();  

	void Start () {


		myProperties.Add ("name",itemName);
		myProperties.Add ("category",myCategory);
		myProperties.Add ("foodvalue",foodValue);
		myProperties.Add("weight",weightValue);
		
	}



	void OnTriggerEnter ( Collider col) {
       if(col.gameObject.tag==collisionTag){
			pickMeUp();
		}
		
	}

	public void pickMeUp(){

		InventoryManager.Instance.addItem (gameObject,myProperties);
	}
}
