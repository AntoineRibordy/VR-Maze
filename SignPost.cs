using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{	
	public void ResetScene() 
	{
        // Reset the scene and count of coins when the user clicks the sign post
		Coin.coinsCount = 0;
		Key.keyCollected = false;
		SceneManager.LoadScene(0);
	}
}