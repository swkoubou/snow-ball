using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercon : MonoBehaviour {
     float time = 60;
    public bool fin;
    public float jump_power = 1000;
	// Use this for initialization
	void Start () {
        fin = false;
	}
   
	// Update is called once per frame
	void Update () {
        
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
   

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(new Vector2(0, jump_power));
        }

	}

    private void OnTriggerEnter2D(Collider2D col)
    {
      //  GameObject item = GameObject.FindWithTag("item1");
        if (col.gameObject.tag == "item1")
        {
           Destroy(col.gameObject);//触れたアイテムの消去
        }

      
        
        }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "danger")
        {
        
            fin = true;
        }
    }
}
