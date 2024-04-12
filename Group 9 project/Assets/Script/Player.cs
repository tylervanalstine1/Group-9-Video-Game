using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Vector2 moveInput;

    public bool IsMoving { get; private set; }

    Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    //floats used 
    public float speed = 30f; //walk speed
    //public float rollMult = -45;
   // public float pitchMult = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        //the flaots take the input
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");
        
        //this is what moves the object
        Vector3 pos = transform.position;
      //  pos.x += hAxis * speed * Time.deltaTime;
        //pos.y += hAxis * speed * Time.deltaTime;
        //this is supposted to make the z axis still however i fucked it
       // pos.z = 6.7;
       // transform.position = pos;


       // transform.rotation = Quaternion.Euler(vAxis * pitchMult, hAxis * rollMult, 0);
    }

    public void FixedUpdate()
    {
        rb.velocity = new Vector2(moveInput.x*speed,rb.velocity.y);
    
    }


    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        IsMoving = moveInput != Vector2.zero;

    }


}
