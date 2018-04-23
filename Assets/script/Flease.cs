using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flease: MonoBehaviour
{

    public GameObject test;


    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                Time.timeScale = 1.0f;//開始
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                Time.timeScale = 0;//停止

                //    Instantiate(Flease);
                Instantiate(test, this.transform.parent.position, Quaternion.identity);
            }
        }
    }
}
