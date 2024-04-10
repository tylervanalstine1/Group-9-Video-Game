using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //floats used 
    public float speed = 30;
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
        pos.x += hAxis * speed * Time.deltaTime;
        pos.y += hAxis * speed * Time.deltaTime;
        //this is supposted to make the z axis still however i fucked it
       // pos.z = 6.7;
        transform.position = pos;


       // transform.rotation = Quaternion.Euler(vAxis * pitchMult, hAxis * rollMult, 0);
    }


}
