using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingZ : MonoBehaviour
{
    // speed -Knl
    public float speed = 1f;

    //turns the wall around -KNL
    public float distance = 10f;

    //floats needed to make sure it turns around when its supposed to -KNL
    public float BounceBack = 0f;
    public float BounceBack2 = 0f;


    //happens when the program beings -KNL
    void Start()
    {


        //Vecotr obtains the current position, changes the x cords by speed -KNL 
        Vector3 pos = transform.position;
        pos.z += speed * Time.deltaTime;
        transform.position = pos;

        //this variable is to find the edges of how far it would go -KNL
        BounceBack = pos.z - distance;
        BounceBack2 = pos.z + distance;

    }



    // Update is called once per frame
    void Update()
    {


        //basic movemnet  -KNL
        Vector3 pos = transform.position;
        pos.z += speed * Time.deltaTime;
        transform.position = pos;



        // changing directions -KNL
        if (pos.z < BounceBack)
        {
            speed = Mathf.Abs(speed);  //make the wall go back the way it came -KNL
        }
        else if (pos.z > BounceBack2)
        {
            speed = -Mathf.Abs(speed);  //make the wall go back the way it came -KNL
        }
    }
}
