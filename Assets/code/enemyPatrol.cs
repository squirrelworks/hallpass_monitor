using UnityEngine;
using System.Collections;

public class enemyPatrol : MonoBehaviour
{

	private GameObject[] wayPoints;
	private GameObject[] myEnemies;


	public float myTargetDistance = 2.0f;
	int myMode = 1;


	public float enemyCatchDist=5.0f;
	public float myEvilness=1.0f;

	public GameObject myYellingObject;

	Transform goal;
	GameObject mySelectedTarget;


	int myTargetArrayPos;
	NavMeshAgent myAgent;



	// Use this for initialization
	void Start ()
	{


		wayPoints = GameObject.FindGameObjectsWithTag("wayPoint");

		myEnemies = GameObject.FindGameObjectsWithTag("teamMembers");

		//myEnemies.Add(GameObject.FindWithTag("Player"));

		myYellingObject.SetActive(false);

		myAgent = GetComponent<NavMeshAgent> ();

		myTargetArrayPos = Random.Range (0, 5);
		goal = wayPoints [myTargetArrayPos].transform;
		myAgent.destination = goal.position;

	

	}
	
	// Update is called once per frame
	void Update ()
	{

		switch (myMode)
		{

		case 1:


   if (Vector3.Distance (transform.position, myAgent.destination) <= myTargetDistance) {
				getNewTarget();
			
			}


               foreach (GameObject enemy in myEnemies) {

				float myEnemyDist = Vector3.Distance (transform.position, enemy.transform.position);


				if (myEnemyDist <= enemyCatchDist) {
					//Debug.Log ("Hunting");
					myMode = 2;
					//myAgent.destination = enemy.transform.position;
					mySelectedTarget=enemy;
					goal=enemy.transform;
					break;
					
				}
			}

				break;

				case 2:

			float myEnemyDist = Vector3.Distance (transform.position, mySelectedTarget.transform.position);
					
					


					if (myEnemyDist >= enemyCatchDist) {
					//Debug.Log ("back to patrol");

				myYellingObject.SetActive(false);
					myMode = 1;
				getNewTarget();

				}


			if (myEnemyDist <= 2.0f) {

					//mySelectedTarget.reciveDamage();
				followTarget myTargetScript = mySelectedTarget.GetComponent<followTarget>();



				if (myTargetScript.myStamina<=0){
					myMode = 1;
					//Debug.Log ("back to patrol");
					myYellingObject.SetActive(false);
					getNewTarget();

				}
				else
				{
					Debug.Log ("shouting");
				
					myYellingObject.SetActive(true);
					mySelectedTarget.SendMessage("reciveDamage", myEvilness);
				}



					}


				break;

			}

		myAgent.destination = goal.position;
		}

		//reciveDamage
	


			





	void getNewTarget(){
		myTargetArrayPos = Random.Range (0, 5);
		
		//Debug.Log ("new target: " + myTargetArrayPos);
		
		goal = wayPoints [myTargetArrayPos].transform;

	}


}
