using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercon : MonoBehaviour {
    private float time = 60;
	// Use this for initialization
	void Start () {
   
	}
   
	// Update is called once per frame
	void Update () {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        float a;
        int se;
         a = Time.realtimeSinceStartup;  //ゲームが始まってからのリアルタイム時間数
        se = (int)a;//小数点の削除     

    
        if (Input.GetKey(KeyCode.F))
          {
              Time.timeScale = 0;//停止
          }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("pp");
            rigidbody.AddForce(new Vector2(0, 700));
        }

	}
}
