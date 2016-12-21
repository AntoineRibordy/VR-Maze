using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoofPrefab;
	public static int coinsCount = 0;

	void Start()
	{
		coinsCount++;	
	}

	void Update()
	{
		transform.Rotate(0,90f * Time.deltaTime,0);
	}

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
		ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper> ();
		scoreKeeper.IncrementScore (1);
		Instantiate(coinPoofPrefab,transform.position, Quaternion.Euler(-90,0,0));
		Destroy(gameObject);
    }
		
}
