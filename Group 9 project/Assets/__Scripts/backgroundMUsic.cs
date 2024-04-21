using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMUsic : MonoBehaviour
{
    public static backgroundMUsic instance;



    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
                instance = this;
        }
        else
        {
            Destroy(gameObject);
        }


    }


}
