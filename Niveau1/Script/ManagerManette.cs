using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerManette : MonoBehaviour {

    bool etat;
    bool boutonA;
    public GameObject laser;
    public GameObject ABouton;
    public GameObject commencer;
    float TempsDebut;
    float TempsLaserDebut;
    float TempsLaserFin;
    //ValeurTempsLaser represente le temps de tir du joueur
    float ValeurTempsLaser = 0;
    float differentielTemps;
    bool testTemps = false;
    bool testTemps2 = false;
    bool depart = false;
    BarreEnergie energie;
    static bool Tir = true;
    static float temps;
    bool testCommencerTemps = false;
    float suiviTemps;
    static bool testfin = true;

	// Use this for initialization
	void Start () {
        TempsDebut = Time.time;
        energie = new BarreEnergie();
	}
	
	// Update is called once per frame
	void Update () {
        if(testfin){
            etat = Input.GetKey(KeyCode.Space);
        }
        boutonA = Input.GetKeyDown(KeyCode.E);
        
        TempsDebut = Time.time;

        if (testCommencerTemps == true)
        {
            temps = Time.time - suiviTemps;
        }
        if (boutonA == true)
        {

            Destroy(ABouton) ;
            Destroy(commencer);
            depart = true;
            testCommencerTemps = true;
            suiviTemps = TempsDebut;
        }

        if (etat == true && Tir == true)
        {
            if (depart == true)
            {
                testTemps2 = false;
                if (testTemps == false)
                {
                    testTemps = true;
                    TempsLaserDebut = Time.time;
                }
                TempsLaserFin = Time.time;
                laser.SetActive(true);
            }
            differentielTemps = TempsLaserFin - TempsLaserDebut;
            energie.getEnergie(differentielTemps + ValeurTempsLaser);
        }
        else
        {

            if (testTemps2 == false)
            {
                testTemps2 = true;
                ValeurTempsLaser = ValeurTempsLaser + differentielTemps;
            }
            energie.getEnergie(ValeurTempsLaser);
            testTemps = false;
            laser.SetActive(false);
        }
	}

    public void ArretTir()
    {
        Tir = false;
    }

    public float getTemps()
    {
        return temps;
    }

    public void arretEcrire()
    {
        testfin = false;
    }
}
