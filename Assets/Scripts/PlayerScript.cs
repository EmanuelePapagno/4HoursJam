using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public GameObject WhiteCircle;
    public GameObject BlackCircle;
    public GameObject WhiteSquare;
    public GameObject BlackSquare;

    public bool isBlack;
    public bool isSquare;
    public bool isRight;

    // Use this for initialization
    void Start()
    {
        WhiteCircle.SetActive(true);
        BlackCircle.SetActive(false);
        WhiteSquare.SetActive(false);
        BlackSquare.SetActive(false);
    }

    private void Update()
    {
        // con spazio cambia il colore
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isBlack = !isBlack;
            ChangeColor();
        }

        // con A cambia la forma
        if(Input.GetKeyDown(KeyCode.A))
        {
            isSquare = !isSquare;
            ChangeShape();
        }

        //con L si sposta da dx a sx
        if (Input.GetKeyDown(KeyCode.L))
        {
            isRight = !isRight;
            ChangePlace();
        }

    }


    void ChangePlace()
    {
        if (isRight == true)
        {
            transform.position = new Vector3(0, -9, 0);
        }

        if(isRight == false)
        {
            transform.position = new Vector3(2, -9, 0);
        }

    }

    void ChangeShape()
    {
        if(isSquare == true && isBlack == false)
        {
            WhiteCircle.SetActive(false);
            WhiteSquare.SetActive(true);
            isSquare = true;
        }

        if (isSquare == true && isBlack == true)
        {
            BlackCircle.SetActive(false);
            BlackSquare.SetActive(true);
            isSquare = true;
        }

        if (isSquare == false && isBlack == false)
        {
            WhiteSquare.SetActive(false);
            WhiteCircle.SetActive(true);
            isSquare = false;
        }

        if (isSquare == false && isBlack == true)
        {
            BlackSquare.SetActive(false);
            BlackCircle.SetActive(true);
            isSquare = false;
        }

    }

    void ChangeColor()
    {
        if (isBlack == true && isSquare == false)
        {
            WhiteCircle.SetActive(false);
            BlackCircle.SetActive(true);

        }

        if (isBlack == true && isSquare == true)
        {
            WhiteSquare.SetActive(false);
            BlackSquare.SetActive(true);
            
        }


        if (isBlack == false && isSquare == false)
        {
            BlackCircle.SetActive(false);
            WhiteCircle.SetActive(true);
        }

        if (isBlack == false && isSquare == true)
        {
            BlackSquare.SetActive(false);
            WhiteSquare.SetActive(true);
        }
    }
}
