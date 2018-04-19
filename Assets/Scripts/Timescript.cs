using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timescript : MonoBehaviour {


    public float timer;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer = timer +Time.deltaTime;

	}
}
