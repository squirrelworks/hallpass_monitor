using UnityEngine;
using System.Collections;

public class followTarget : MonoBehaviour {
	
	public GameObject goal;
	public GameObject punishmentGoal;
	//public GameObject levelManagerObject;

	public float goalDistance=2.0f;
	public float myStamina=1000.0f;

	NavMeshAgent myAgent;

	void Start () {
		

		punishmentGoal= GameObject.FindWithTag("endGoal");

		if (gameObject.tag == "Player") {

		}
		else{
			GameObject myObject = GameObject.FindWithTag ("Player");

			Debug.Log ("team member goal: "+myObject.tag);
			goal= GameObject.FindWithTag("Player");
		}

		myAgent = GetComponent<NavMeshAgent>();

		myAgent.destination = goal.transform.position;

	}

	void Update()
	{





		//float myDist=Vector3.Distance(transform.position, myAgent.destination);
		
		//Debug.Log("distance to target: "+myDist);
		
		
		if (Vector3.Distance (transform.position, myAgent.destination) <= goalDistance) {

			myAgent.Stop();
		} else {

			myAgent.Resume();

		}


		myAgent.destination = goal.transform.position;

	}

	void reciveDamage(float myDamage){

		myStamina = myStamina - myDamage;


		if(myStamina<=0){
			Debug.Log ("awwwwww");

			goal=punishmentGoal;

			if (gameObject.tag=="Player"){

				// husk at fixe så det først er når målet er nået  gameover
				//levelManagerObject.SendMessage("gameOver");
				GameState.Instance.gameOver();

			}
		

		}
	}


	void OnGUI()
	{
		
		string myLevel = GameState.Instance.getLevel ();
		
		if (myLevel == "Level_1") {
			
			Vector2 targetPos;
			targetPos = Camera.main.WorldToScreenPoint (transform.position);

			GUI.Box (new Rect (targetPos.x - 50, (Screen.height - targetPos.y) - 30, 100, 20), transform.name + ": " + myStamina);
		}
	}

}
