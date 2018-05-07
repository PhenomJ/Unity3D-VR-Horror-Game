using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    public enum PlayerState { Idle, Run };
    public float speed;
    public CharacterController character;
    public float gravity;
    public PlayerState playerstate;
    public GameObject cameraobject;
    public Vector3 moveDirection;
    public Transform direction_Transform;
    public bool isground = true;
    public float yVelocity = 0.0f;
    
	// Use this for initialization
	void Start () {
        playerstate = PlayerState.Idle;
        character = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        moveDirection = new Vector3 (direction_Transform.position.x - cameraobject.transform.position.x, 
                                     0, 
                                     direction_Transform.position.z - cameraobject.transform.position.z);
        
        if (Input.GetButtonDown("Fire1"))
        {
            playerstate = PlayerState.Run;
        }

        else if (Input.GetButton("Fire1"))
        {
            Vector3 moveDirection = direction_Transform.position - cameraobject.transform.position;
            moveDirection = cameraobject.transform.TransformDirection(moveDirection);
            moveDirection *= speed;


            yVelocity += (gravity * Time.deltaTime);

            if (character.isGrounded)
                yVelocity = 0.0f;

            moveDirection.y = yVelocity;

            character.Move(moveDirection * Time.deltaTime);
        }

        else if (Input.GetButtonUp("Fire1"))
        {
            playerstate = PlayerState.Idle;
            
        }

        
	}
}
