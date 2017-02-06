using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoutonA : MonoBehaviour {

    private SpriteRenderer boutonA;
    private Color couleurBasse = new Color(1f, 1f, 1f, 0.3f);
    private Color couleurHaute = new Color(1f, 1f, 1f, 1f);
    private float temps = 20f;
    private bool rez = false;

	void Start () {
        boutonA = GetComponent<SpriteRenderer>();
	}
	
	void Update () {
        if (boutonA.color.a <= 1f && boutonA.color.a >= 0.4f)
        {
            boutonA.color = Color.Lerp(couleurHaute, couleurBasse, temps * 0.001f);
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
            boutonA.color = Color.Lerp(couleurBasse, couleurHaute, temps * 0.001f);
            temps = temps + 40f;
        }
	}
}
