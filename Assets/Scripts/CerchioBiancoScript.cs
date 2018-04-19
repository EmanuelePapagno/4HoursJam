using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerchioBiancoScript : MonoBehaviour {



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "PlayerQuadratoNero")
        {
            Destroy(gameObject);
        }

        else
            Debug.Log("gameover");
    }
}

