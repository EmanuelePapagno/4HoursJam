using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadratoNeroScript : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "PlayerCerchioBianco")
        {
            Destroy(gameObject);
        }

        else
            Debug.Log("gameover");
    }
}
