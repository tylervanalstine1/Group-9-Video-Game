using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class __scrpits : MonoBehaviour
{

    static public Hero S { get; private set; }

    [Header("inscribed")]

    public float speed = 30;
    public float rollMult = -45;
    public float pitchMult = 30

    [Header("Dynamic")] [Range(0,4)]
        public float ShieldLevel = 1;


    public void Awake()
    {
        if (S == null)
        {
            S = this;
        }
        else
        {
            Debug.LogError("Hero.Awake() - Attempt to assign second Hero.S!");

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //pull info from input class
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("vertical");

        Vector3 pos = transform.position;
        pos.x += hAxis * speed * Time.deltaTime;
        pos.y += hAxis * speed * Time.deltaTime;
        transform.position = pos;

        //rotate the ship to make it feel dynamic
        //transform.rotation = Quaternion.Euler(vAxis * pitchMult, hAxis * rollMult, 0);
            
    
    }
}
