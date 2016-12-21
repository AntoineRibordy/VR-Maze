using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {
	public int score = 0;
	// Use this for initialization
	void Start () {
		
	}

	public void IncrementScore(int points)
	{
		score += points;
	}
}
