using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

	public GameObject keyProof ;
	public GameObject Door;
	public float keySpeed;
	// CAN CONTROLL FROM DOOR
	public static bool isCollected = false ;


	void Update() {

		transform.Rotate (new Vector3(60 , 60 , 60) * keySpeed);

	}

	public void OnKeyClicked()
	{
		Object.Instantiate (keyProof, transform.position, Quaternion.identity);

		// Key is Collected DONE
		isCollected = true;

		// Destroy GameObject
		Destroy (gameObject , 0.5f);
    }

}
