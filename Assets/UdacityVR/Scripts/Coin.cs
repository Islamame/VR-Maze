using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoof ;
//	public AudioSource audioSource;
//	public AudioClip CoinSound ;
	public float coninSpeed = 5.0f;


	void update() {

		transform.Rotate (new Vector3(60 , 60 , 60) * coninSpeed);

	}

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
		Object. Instantiate(coinPoof, transform.position, Quaternion.identity);
        // Make sure the poof animates vertically
		// DONE

		// CoinSound
//		audioSource.clip = CoinSound;
//		audioSource.Play ();


		// Increase number of Collected Coins by one
		SignPost.numOfCollectableCoin += 1 ;

        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
    }

}
