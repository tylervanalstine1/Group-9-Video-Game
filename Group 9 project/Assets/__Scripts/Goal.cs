using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameObject collidedWith = collision.gameObject;



        // when the player collids with cube start next scene -KNL
        if (collidedWith.CompareTag("Player"))
        {
            //this calls to change the next lvl -KNL
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }

    }
}
