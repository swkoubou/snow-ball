using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontolloer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector2(0, 0.1f));
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-0.2f, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(0.2f, 0));
        }
    }
    
}
