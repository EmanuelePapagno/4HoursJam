using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Rigidbody quadratonero;
    public Rigidbody quadratobianco;
    public Rigidbody cerchionero;
    public Rigidbody cerchiobianco;

    public Transform Left;
    public Transform Right;

    public float timer;
    public float gravityTimer;


    private void FixedUpdate()
    {
        timer = timer + Time.deltaTime;
        gravityTimer = gravityTimer + Time.deltaTime;

        if (timer >= 2f)
        {
            Transform currentTransform = GetRandomTransform();
            Rigidbody currentRigidbody = GetRandomRigidBody();
            Instantiate(currentRigidbody, currentTransform.position, currentTransform.rotation);
            timer = 0f;
        }

        if(gravityTimer > 5f)
        {
            
        }

    }

    Rigidbody GetRandomRigidBody()
    {
        int results = Random.Range(0, 4);
        if (results == 0)
        {
            return quadratonero;
        }

        if (results == 1)
        {
            return quadratobianco;
        }

        if (results == 2)
        {
            return cerchionero;
        }

        else
        {
            return cerchiobianco;
        }
    }

 Transform GetRandomTransform()
    {
        int results = Random.Range(0, 2);
        if (results == 0)
        {
            return Left;
        }
        else
        {
            return Right;
        }
            
    }



}



