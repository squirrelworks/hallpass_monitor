

using UnityEngine;
using System.Collections;

public class textureswap : MonoBehaviour {
	public Texture[] textures;
	public GameObject upButton;
	public GameObject downButton;
	public Renderer rend;
	int index=0;

	void Start() {
		//rend = GetComponent<Renderer>();
	}

	void Update() {

		if (textures.Length == 0){
			return;
	}


		if (Input.GetMouseButtonDown(0))
		{


			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);



			if (Physics.Raycast(ray, out hit))

			{
				if(hit.transform.gameObject.name==upButton.name){
					index++;
					if (index >textures.Length-1) {
						index = 0;
					}

					Debug.Log ("up button: "+index);

					rend.material.mainTexture = textures[index];
				}

				if(hit.transform.gameObject.name==downButton.name){

					index--;

					if (index <0) {
						index = textures.Length-1;
					}
					Debug.Log ("down button: "+index);
					rend.material.mainTexture = textures[index];
				}

			}
		}
	

	

	}
}