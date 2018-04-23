using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeUp : MonoBehaviour {

    public float time;
    Text TimeText;
    // Use this for initialization
    void Start()
    {
        TimeText = GetComponent<Text>();
        TimeText.text = "test";
    }

    // Update is called once per frame
    void Update()
    {
        time -= 1 * Time.deltaTime;
        int time2 = (int)time;
        TimeText.text = "残り:" + time2.ToString();
    }
}
