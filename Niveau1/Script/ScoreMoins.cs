using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreMoins : MonoBehaviour {

    private Text ScoreNegatif;
    static bool testDestruction = false;
    private Color couleurBasse = new Color(1f, 0.2f, 0.2f, 0f);
    private Color couleurHaute = new Color(1f, 0.2f, 0.2f, 1f);
    private Color couleurActuelle = new Color(1f, 0.2f, 0.2f, 0f);
    private float temps = 20f;
    private bool rez = false;

	void Start () {
        ScoreNegatif = GetComponent<Text>();
		
	}
	
	
	void Update () {
        if (testDestruction == true)
        {
            //ScoreNegatif.color = new Color(ScoreNegatif.color.r, ScoreNegatif.color.g, ScoreNegatif.color.b, 1f);
            ScoreNegatif.color = Color.Lerp(couleurBasse, couleurHaute, temps * 0.001f);
            couleurActuelle = ScoreNegatif.color;
            temps = temps + 10f;
            rez = false;
            StartCoroutine(boucleTemps());
        }
        else
        {
            if (rez == false)
            {
                rez = true;
                temps = 0f;
            }
            ScoreNegatif.color = Color.Lerp(couleurActuelle, couleurBasse, temps * 0.001f);
            temps = temps + 10f;
            //ScoreNegatif.color = new Color(ScoreNegatif.color.r, ScoreNegatif.color.g, ScoreNegatif.color.b, 0f);
        }
	}

    IEnumerator boucleTemps()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(2f);
            testDestruction = false;
        }
    }

    public void scm()
    {
        testDestruction = true;
    }
}
