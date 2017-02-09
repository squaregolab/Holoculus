using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailleEnergie : MonoBehaviour {

    static bool demarrage = false;
    private RectTransform mongameObject;
    private bool testTaille = true;

	void Start () {
        mongameObject = GetComponent<RectTransform>();
	}
	
	void Update () {
        if (demarrage == true)
        {
            if (testTaille == true)
            {
                mongameObject.localScale = new Vector3(mongameObject.localScale.x + 0.01f, mongameObject.localScale.y + 0.01f, mongameObject.localScale.z + 0.01f);
                if (mongameObject.localScale.x >= 0.9f)
                {
                    testTaille = false;
                }
            }
            else
            {
                mongameObject.localScale = new Vector3(mongameObject.localScale.x - 0.01f, mongameObject.localScale.y - 0.01f, mongameObject.localScale.z - 0.01f);
                if (mongameObject.localScale.x <= 0.7f)
                {
                    testTaille = true;
                }
            }
        }
	}

    public void Agrandir()
    {
        demarrage = true;
    }

    public void stop()
    {
        demarrage = false;
    }
}
