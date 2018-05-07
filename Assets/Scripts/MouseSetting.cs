using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSetting : MonoBehaviour {

    Transform cameraTransform;
    float mouseX = 0.0f;
    float mouseY = 0.0f;
    float MAX_ROT = 90.0f;
    float MIN_ROT = -90.0f;
    public float mouseSpeed;

	void Start () {
        cameraTransform = transform;
	}

	void Update () {
        mouseX += (Input.GetAxis("Mouse X") * mouseSpeed * Time.deltaTime);
        mouseY += (Input.GetAxis("Mouse Y") * mouseSpeed * Time.deltaTime);

        mouseY = (mouseY > MAX_ROT) ? MAX_ROT : mouseY;
        mouseY = (mouseY < MIN_ROT) ? MIN_ROT : mouseY;
        Vector3 rotation = new Vector3(-mouseY, mouseX, 0.0f);
        cameraTransform.eulerAngles = rotation;
    }
}
