using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	public bool isLocked = true;
	public bool isOpen = false;
	public AudioSource audioSource;
	public AudioClip openDoorSound;
	public AudioClip closeDoorSound;

    void Update() {

		if (isOpen == true) {
			if (transform.position.y < 8.0f) {
				transform.Translate (0, 2.5f * Time.deltaTime, 0, Space.World);
			}
		}


    }

    public void OnDoorClicked() {

		if (Key.isCollected == true) {
			// Unlock door ;
			Unlock ();

			isOpen = true;

			audioSource.clip = openDoorSound;
			audioSource.Play ();

		} else {

			audioSource.clip = closeDoorSound ;
			audioSource.Play ();

		
		}



    }

    public void Unlock() {

		isLocked = false;

	}
}
