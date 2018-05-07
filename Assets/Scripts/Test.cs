using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public float speed;
    Transform boxtransform;

	void Start () {
        boxtransform = transform;
	}
	
	void Update () {
        float axis = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        boxtransform.position += new Vector3(axis, 0.0f, 0.0f);
	}
}
