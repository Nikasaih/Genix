using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NewBehaviourScript : MonoBehaviour
{


	public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;
    public float speed = 6f;
    public float jumpSpeed = 8f;
    public float gravity = 20f;
    private Vector3 moveDirection = Vector3.zero;
    CharacterController Cc;
    
   	Vector3 euler = new Vector3();
   	float sensitivity = 1;
	


    // Start is called before the first frame update
    void Start()
    {	
    	Cc = GetComponent<CharacterController>();
        euler = transform.localEulerAngles; // save initial euler angles  
    }

    // Update is called once per frame
    void Update ()

	{
		// Création d'un nouveau vecteur de déplacement

		//moveDirection.y-=gravity*Time.deltaTime;
		//Cc.Move (moveDirection * Time.deltaTime);


		Vector3 move = new Vector3();

		//recuperation de la sensibilité horizontale
		float h = horizontalSpeed * Input.GetAxis("Mouse X");



		var test = euler.y;	
		euler.y += Input.GetAxis("Mouse X") * 4 * sensitivity;
		// euler.z =Mathf.Sin(Input.GetAxis("Mouse X") * sensitivity);
		transform.localEulerAngles = euler; 
		//getAscis
       	if(Input.GetAxis("Vertical")>0) {

	        move.x = 0.025f*Mathf.Sin(euler.y*3.1415f/180);//301415 = Pi
	        move.z = 0.025f*Mathf.Cos(euler.y*3.1415f/180);
	    }

	    if(Input.GetAxis("Vertical")<0) {

	        move.x = -0.025f*Mathf.Sin(euler.y*3.1415f/180);//301415 = Pi
	        move.z = -0.025f*Mathf.Cos(euler.y*3.1415f/180);
	    }

	    if(Input.GetAxis("Horizontal")<0) {

	        move.z= -0.025f*Mathf.Sin(euler.y*3.1415f/180);//301415 = Pi
	        move.x = -0.025f*Mathf.Cos(euler.y*3.1415f/180);
	    }

	    if(Input.GetAxis("Horizontal")>0) {

	        move.z= 0.025f*Mathf.Sin(euler.y*3.1415f/180);//301415 = Pi
	        move.x = 0.025f*Mathf.Cos(euler.y*3.1415f/180);
	    }
	    //if (Input.GetButtonDown("Jump")){
	    //	moveDirection.y+=jumpSpeed;
	    //}

		// On applique le mouvement à l'objet


		
		
	    if (Cc.isGrounded){

			moveDirection = new Vector3(0,0,Input.GetAxis("Vertical"));
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;

			if (Input.GetButtonDown("Jump")){
		    	moveDirection.y+=jumpSpeed;
		    }

		// On applique le mouvement à l'objet
	    }

	    moveDirection.y-=(gravity*Time.deltaTime);
	    Cc.Move (moveDirection * Time.deltaTime);



		transform.position += move;


	
		

	}
}
