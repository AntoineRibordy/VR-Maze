using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {
	Text text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ScoreKeeper scoreKeeper = FindObjectOfType<ScoreKeeper> ();
		text = GetComponent<Text> ();
		text.text = ("You Win!\nCoins collected: " +  scoreKeeper.score + "/" + Coin.coinsCount);
	}
}
