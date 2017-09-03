using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI ;

public class SignPost : MonoBehaviour
{	
	public static int numOfCollectableCoin = 0;

	// public TextMesh win ;
	public Text win ;

	void Start() {
	}

	void Update() {

		win.text = "You win \n You Collect : " + numOfCollectableCoin.ToString ();

	}
	
	public void ResetScene() 
	{
		Debug.Log ("Reload Scene");
		// Reload Scene
		SceneManager.LoadScene ("A Maze");
	}
}