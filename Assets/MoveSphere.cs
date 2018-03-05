using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour {

    Rigidbody r;

	// Use this for initialization
	void Start () {
        r = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * Time.deltaTime * 25;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.AngleAxis(2, Vector3.up);
            transform.position += transform.right * Time.deltaTime * 25;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation *= Quaternion.AngleAxis(2, Vector3.down);
            transform.position -= transform.right * Time.deltaTime * 25;
        }
        //if(Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.position -= transform.forward * Time.deltaTime * 25;
        //}
        //if(Input.GetKeyDown(KeyCode.Space))
        //{
        //    //transform.position += transform.up * Time.deltaTime * 400;
        //    r.AddForce(transform.up * 500);
        //}		
	}
}
