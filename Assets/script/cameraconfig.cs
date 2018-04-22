using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraconfig : MonoBehaviour {
   public  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject player = GameObject.FindWithTag("Player");
        Vector3 cpos = transform.position;
        Vector3 ppos = player.transform.position;
        cpos.x = ppos.x+4;
        cpos.y = ppos.y-1;
        cpos.z = -20;
        transform.position = cpos;
	}
}
