﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamecont : MonoBehaviour {
    // Use this for initialization
    private playercon p;
    public bool fini=false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
         GameObject player = GameObject.FindWithTag("Player");
        p = player.GetComponent<playercon>();
        fini = p.fin;
  
        float a;
        int se;
     

   
      
        a = Time.realtimeSinceStartup;  //ゲームが始まってからのリアルタイム時間数
        se = (int)a;//小数点の削除     


        if (Input.GetKey(KeyCode.Backspace))
        {
            Time.timeScale = 0;//停止
        }

        if (fini == true)
        {
            SceneManager.LoadScene("end2");
        }
    }
}
