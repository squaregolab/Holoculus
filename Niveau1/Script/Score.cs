using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private Text montexte;
    static int score = 0;

	void Start () {
		montexte = GetComponent<Text>();
	}
	
	void Update () {
        if (score == 0)
        {
            montexte.text = score + " POINT";
        }
        else
        {
            montexte.text = score + " POINTS";
        }
	}

    public void incrementer()
    {
        score += 10;
    }

    public void incNavette()
    {
        score += 15;
    }

    public void decTerre()
    {
        score -= 15;
    }

    public int RetourScore()
    {
        return score;
    }
}
