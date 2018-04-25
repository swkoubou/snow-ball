using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercon : MonoBehaviour {
     float time = 60;
    public bool fin;
    public float jump_power = 1000;
    public static int score=0;

   
    bool fl = false;
	// Use this for initialization
	void Start () {
        fin = false;
	}
   
	// Update is called once per frame
	void Update () {
        
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
   

        if (fl==true && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(new Vector2(0, jump_power));
            fl = false;
        }

	}

    private void OnTriggerEnter2D(Collider2D col)
    {
      //  GameObject item = GameObject.FindWithTag("item1");
        if (col.gameObject.tag == "item1")
        {
           Destroy(col.gameObject);//触れたアイテムの消去
            score += 100;
        }
        if (col.gameObject.tag == "item2")
        {
            Destroy(col.gameObject);
            score += 200;
        }
      
        
        }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "danger")
        {
        
            fin = true;
        }

        if (col.gameObject.tag == "floor") {
            fl = true;
        }
    }


}
