using UnityEngine;
using System.Collections;

public class playerSelector : MonoBehaviour {


	bool amSelected=false;
	// Use this for initialization

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(GameState.Instance.getLevel()=="select player" | GameState.Instance.getLevel()=="select team"){
			
		if (Input.GetMouseButtonDown(0))
		{


			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);



			if (Physics.Raycast(ray, out hit))

			{
				if(hit.transform.gameObject.name==gameObject.name){
					

					if (!amSelected) {
						transform.Translate (0, 1, 0);	
						amSelected = true;
						GameState.Instance.selectPlayer (gameObject.name);

					} else {
						transform.Translate (0, - 	1, 0);
						amSelected = false;
						GameState.Instance.deselectPlayer (gameObject.name);
					}	
				}

			}
		}
	}
	}
}
