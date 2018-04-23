using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Y))
        {
            SceneManager.LoadScene("snow");
        }
        if (Input.GetKey(KeyCode.N))
        {
            SceneManager.LoadScene("first");
        }
	}
}
