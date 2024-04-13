using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{

    static public GameObject POI;

   
    public float camZ;

    void Awake()
    {
        camZ = this.transform.position.z;
    }

    private void FixedUpdate()
    {
        if (POI == null) return;
        //Get position of POI   
        Vector3 destination= POI.transform.position;
        //Force Destination.z to be camZ to keep cam far away enough 
        destination.z = camZ;
        //Set the camera to the destination    
        transform.position = destination;
    }

}
