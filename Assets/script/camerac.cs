using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerac : MonoBehaviour {
    
    // Use this for initialization
    float m;
	void Start () {
        GameObject player = GameObject.FindWithTag("Player");
        m = this.transform.position.y - player.transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {
        GameObject player = GameObject.FindWithTag("Player");
        Vector3 cpos = player.transform.position;
        cpos.y  += m;
        cpos.z -= 10;
        transform.position = cpos;
	}
}
