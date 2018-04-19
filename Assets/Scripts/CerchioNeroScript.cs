using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerchioNeroScript : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "PlayerQuadratoBianco")
        {
            Destroy(gameObject);
        }

        else
            Debug.Log("gameover");
    }
}
