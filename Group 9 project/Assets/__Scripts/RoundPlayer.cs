using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundPlayer : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    public float speed = 20f;





    // Start is called before the first frame update
    void Start()
    {

        playerRigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    //void Update() {}

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        playerRigidbody.AddForce(movement * speed * Time.deltaTime);
    }

}
