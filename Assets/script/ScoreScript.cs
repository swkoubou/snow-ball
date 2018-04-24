using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour {
    private int scores = playercon.score;
    Text ScoreText;
	// Use this for initialization
	void Start () {
        ScoreText = GetComponent < Text > ();
	}
	
	// Update is called once per frame
	void Update () {
        scores = playercon.score;
        ScoreText.text ="Score:"+ scores.ToString();
	}
}
