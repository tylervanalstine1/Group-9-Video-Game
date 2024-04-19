using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surface : MonoBehaviour
{
    void OnTriggerExit(Collider other){
        Player you = other.GetComponent<Player>();
        if(you != null){
            you.canJump = false;
        }
    }

    void OnTriggerStay(Collider other){
        Player you = other.GetComponent<Player>();
        if(you != null){
            you.canJump = true;
        }
    }
}
