using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoofPrefab;
	public static bool keyCollected = false;

	private Color color;

	void Start()
	{
		color = GetComponent<Renderer> ().material.color;
	}

	void Update()
	{
		//Bonus: Key Animation
		transform.Rotate(0,180f * Time.deltaTime,0);
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Destroy the key. Check the Unity documentation on how to use Destroy
		keyCollected = true;
		Instantiate(keyPoofPrefab,transform.position, Quaternion.Euler(-90,0,0));
		//FindObjectOfType<Door> ().GetComponent<Door> ().Unlock ();
		Destroy(gameObject);
    }

	public void SetGazedAt(bool gazedAt) {
		GetComponent<Renderer>().material.color = gazedAt ? Color.green : color;
	}

	public void OnGazeEnter() {
		SetGazedAt(true);
	}

	/// Called when the user stops looking on the GameObject, after OnGazeEnter
	/// was already called.
	public void OnGazeExit() {
		SetGazedAt(false);
	}
		

}
