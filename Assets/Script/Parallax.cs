using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {
    public float speed = 4;

	
	void Start () {
		
	}
	
	
	void Update () {
        
        transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        if (transform.position.x < -GetComponent<SpriteRenderer>().size.x)
        {
            transform.position = new Vector3(0,transform.position.y,0);
        }
	}
}