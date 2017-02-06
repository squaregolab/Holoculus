using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Commencer : MonoBehaviour {

    private Text commencer;
    private Color couleurBasse = new Color(1f, 1f, 1f, 0.3f);
    private Color couleurHaute = new Color(1f, 1f, 1f, 1f);
    private float temps = 20f;
    private bool rez = false;

	void Start () {
        commencer = GetComponent<Text>();
	}
	
	void Update () {
        if (commencer.color.a <= 1f && commencer.color.a >= 0.4f)
        {
            commencer.color = Color.Lerp(couleurHaute, couleurBasse, temps * 0.001f);
            temps = temps + 40f;
            rez = false;
        }
        else
        {
            if (rez == false)
            {
                rez = true;
                temps = 0f;
            }
            commencer.color = Color.Lerp(couleurBasse, couleurHaute, temps * 0.001f);
            temps = temps + 40f;
        }
	}
}
