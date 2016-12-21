using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour 
{
	// Sounds to play when the door is locked or opened
	public AudioClip[] soundFiles;
	public AudioSource soundSource;

	private Color color;

	// Create a boolean value called "locked" that can be checked in Update() 
	private bool locked = true;
	//private bool opened = false;

	private GameObject signPost;

	void Start()
	{
		color = GetComponent<Renderer> ().material.color;
		signPost = GameObject.Find ("SignPost");
	}

    void Update() {
        // If the door is unlocked and it is not fully raised
        // Animate the door raising up
		if (!locked && transform.position.y < 20){
			transform.Translate (0, 3.0f * Time.deltaTime, 0);
		}
		// Display Sign Post if door is half opened
		if (transform.position.y > 15) {
			signPost.GetComponent<Text> ().enabled = true;
		}

    }

	public void OnDoorClicked()
	{
		if (Key.keyCollected) {
			Unlock ();
			soundSource.clip = soundFiles [0];
		} else {
			soundSource.clip = soundFiles [1];
		}
		soundSource.Play();
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

    public void Unlock()
    {
        // You'll need to set "locked" to false here
		locked = false;
    }
}
