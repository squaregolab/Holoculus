using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAsteroid : MonoBehaviour {

    float vitesse;

	void Start () {
        Random.seed = System.DateTime.Now.Millisecond;
        vitesse = Random.Range(30, 80);
	}
	
	void Update () {
        transform.Rotate(Vector3.one * vitesse * Time.deltaTime);
	}
}
