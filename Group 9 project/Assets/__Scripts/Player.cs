using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))] //Anything with this script must have a Rigidbody component
public class Player : MonoBehaviour
{
    [Header("Inscribed")]
    //floats used 
    public float speed = 5f; //walk speed
    //public float rollMult = -45;
    //public float pitchMult = 30;
    [Header("Dynamic")]
    Vector2 moveInput; //2D vector determining what buttons are being pressed
    public bool IsMoving { get; private set; }

    Rigidbody rb; //The player's Rigidbody component

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    

    // Update is called once per frame
    void Update()
    {



        //the flaots take the input
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        
        //this is what moves the object
        Vector3 pos = transform.position;
        pos.x += hAxis * speed * Time.deltaTime;
        pos.z += vAxis * speed * Time.deltaTime;
        transform.position = pos;


       // transform.rotation = Quaternion.Euler(vAxis * pitchMult, hAxis * rollMult, 0);
    }
    /*
    public void FixedUpdate()
    {
        rb.velocity = new Vector3(moveInput.x * speed, 0, moveInput.y * speed);
    
    }
    */

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        IsMoving = moveInput != Vector2.zero;

    }


}