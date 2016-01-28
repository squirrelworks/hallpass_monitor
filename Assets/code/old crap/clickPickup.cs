using UnityEngine;
using System.Collections;

public class clickPickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


		if (Input.GetMouseButton(0))
		{
			RaycastHit hit;
			Ray ray = (Camera.main.ScreenPointToRay(Input.mousePosition));
			
			if (Physics.Raycast(ray, out hit))
			{
				Debug.Log("Hit: " + hit.transform.gameObject);
				if (hit.transform.name == "Ground")
				{
					//Debug.DrawLine(Camera.main.transform.position,hit.point,Color.red,10.0f,false);
				}
				else{
					//pickMeUp();
					hit.transform.gameObject.SendMessage("pickMeUp");

				}
			}                   
		}

	}
}
