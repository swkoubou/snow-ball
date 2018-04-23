using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Destroy(gameObject);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {

            Time.timeScale = 1.0f;//開始
            SceneManager.LoadScene("snow");
        }
        else if (Input.GetKeyDown(KeyCode.Delete))
        {
            SceneManager.LoadScene("first");
        }

    }
}
