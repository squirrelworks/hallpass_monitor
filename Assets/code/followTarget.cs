using UnityEngine;
using System.Collections;

public class followTarget : MonoBehaviour {
	
	public Transform goal;
	public Transform punishmentGoal;

	public float goalDistance=2.0f;
	public float myStamina=1000.0f;

	NavMeshAgent myAgent;

	void Start () {
		 myAgent = GetComponent<NavMeshAgent>();
		myAgent.destination = goal.position;
	}

	void Update()
	{





		float myDist=Vector3.Distance(transform.position, myAgent.destination);
		
		//Debug.Log("distance to target: "+myDist);
		
		
		if (Vector3.Distance (transform.position, myAgent.destination) <= goalDistance) {

			myAgent.Stop();
		} else {

			myAgent.Resume();

		}


		myAgent.destination = goal.position;

	}

	void reciveDamage(float myDamage){

		myStamina = myStamina - myDamage;


		if(myStamina<=0){
			Debug.Log ("awwwwww");

			goal=punishmentGoal;

			if (gameObject.tag=="Player"){
				Debug.Log ("gameOver");
			}
		

		}
	}

}
