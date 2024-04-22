using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMUsic : MonoBehaviour
{
    //
    public static backgroundMUsic instance;


    //when the game starts
    private void Awake()
    {
        // make sure it isnt reload the music stacking
        if (instance == null)
        {
            //make sure the music isnt repeated every lvl
            DontDestroyOnLoad(this.gameObject);
                instance = this;
        }
        else
        {
            //if it repeats destroy one of em.
            Destroy(gameObject);
        }


    }


}
