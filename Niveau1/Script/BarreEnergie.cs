using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarreEnergie : MonoBehaviour {

    private RectTransform carre;
    static float monEnergie;
    Vector3 tailleDebut;
    static float tailleActuelle = 0;
    public GameObject Laser;
    ManagerManette objetManager;
    static bool testBaril = false;
    bool tempsRecharge = true;
    TailleEnergie objetTailleEnergie;
    MenuFinal objetMenuFinal;

	void Start () {
        carre = GetComponent<RectTransform>();
        tailleDebut = carre.localScale;
        objetManager = new ManagerManette();
        objetTailleEnergie = new TailleEnergie();
        objetMenuFinal = new MenuFinal();
	}
	
	void Update () {
        if (carre.localScale.x <= 0)
        {
            //Plus d'energie
            carre.localScale = new Vector3(0, tailleDebut.y, tailleDebut.z);
            Laser.SetActive(false);
            objetManager.ArretTir();
            objetMenuFinal.finDuJeu();
        }
        else{
            tailleActuelle = tailleDebut.x - (monEnergie / 20f);
            carre.localScale = new Vector3(tailleDebut.x - (monEnergie / 20f), tailleDebut.y, tailleDebut.z);
        }

        if (testBaril == true && carre.localScale.x <= 0.75 && tempsRecharge == true)
        {
            tailleDebut.x = tailleDebut.x + 0.001f;
            objetTailleEnergie.Agrandir();
            StartCoroutine(boucle());
        }
	}

    IEnumerator boucle()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(2f);
            tempsRecharge = false;
            objetTailleEnergie.stop();
        }
    }

    public void getEnergie(float energie)
    {
        monEnergie = energie;
    }

    public void baril()
    {
        testBaril = true;
    }

    public float retourEnergie()
    {
        return ((tailleActuelle * 10) / 6) * 100;
    }
}
