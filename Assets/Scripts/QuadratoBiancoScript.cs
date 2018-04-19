using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadratoBiancoScript : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "PlayerCerchioNero")
        {
            Destroy(gameObject);
        }

        else
            Debug.Log("gameover");
    }
}
