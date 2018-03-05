using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    public GameObject bulletType;
    float Timer;
    float MaxTime = 0.3f; //limit for bullet creating interval
	// Use this for initialization
	void Start () {
        Timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
        Timer -= Time.deltaTime;
        if (Input.GetKey(KeyCode.DownArrow) && Timer <= 0.0f)
        {
            Timer = MaxTime;
            Instantiate(bulletType, transform.position + transform.forward * 9f, transform.rotation);
        }
    }
}
