using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.forward * Time.deltaTime * 50;
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetType() != null)
            Destroy(this.gameObject);
    }
}
