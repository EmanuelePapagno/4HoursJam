using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuadratoBiancoScript : MonoBehaviour {


 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "PlayerCerchioNero")
        {
            Destroy(gameObject);
        }
        if (collision.collider.name == "InvisibleWall")
        {
            GameOver();
        }

        if (collision.collider.name == "PlayerCerchioBianco")
        {
            GameOver();
        }

        if (collision.collider.name == "PlayerQuadratoNero")
        {
            GameOver();
        }

        if (collision.collider.name == "PlayerQuadratoBianco")
        {
            GameOver();
        }

    }

    void Distruggi()
    {
        Destroy(gameObject);
    }

    void GameOver()
    {
        SceneManager.LoadScene("GameOverScene");
        Debug.Log("gameover");
    }

}
