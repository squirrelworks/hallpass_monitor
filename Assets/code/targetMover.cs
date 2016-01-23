using UnityEngine;
using System.Collections;

public class targetMover : MonoBehaviour
{

	Vector3 newPosition;
	public GameObject targetObject;

	void Start () {
		newPosition = transform.position;
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{


			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		

			if (Physics.Raycast(ray, out hit))

			{

				newPosition = hit.point;
				targetObject.transform.position = newPosition;
			}
		}
	}
}