using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class button : MonoBehaviour {

	
    public void OnClick()
    {
        Debug.Log("popo");
        GameObject player = GameObject.FindWithTag("Player");
        player.transform.Translate(new Vector2(0, 12f));
    }
}
