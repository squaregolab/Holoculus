using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvementexplosion : MonoBehaviour {

    static int positionBalle;
    public GameObject balle1;
    public GameObject balle2;
    public GameObject balle3;
    public GameObject balle4;
    public GameObject balle5;
    public GameObject balle6;
    public GameObject balle7;
    public GameObject balle8;
    public GameObject balle9;
    public GameObject balle10;
    public GameObject balle11;
    public GameObject balle12;
    public GameObject balle13;
    public GameObject balle14;
    public GameObject balle15;
    public GameObject balle16;
    public GameObject balle17;
    public GameObject balle18;
    public GameObject balle19;
    public GameObject balle20;
    public GameObject balle21;
    public GameObject balle22;
    public GameObject balle23;
    public GameObject balle24;
    public GameObject balle25;
    public GameObject balle26;
    public GameObject balle27;
    public GameObject balle28;
    public GameObject balle29;
    public GameObject balle30;
    public GameObject balle31;
    public GameObject balle32;
    public GameObject balle33;
    public GameObject balle34;
    public GameObject balle35;
    public GameObject balle36;
    public GameObject balle37;
    public GameObject balle38;
    public GameObject balle39;
    public GameObject balle40;
    Exploder objetExploder;
    AudioSource Son;
    BarreEnergie objetBarreEnergie;
    public AudioClip musique;
    public AudioClip rechargeLaser;
    public static Score monScore;
    ScoreMoins objectScoreMoins; 

    void Start()
    {
        objetExploder = new Exploder();
        monScore = new Score();
        Son = GetComponent<AudioSource>();
        objectScoreMoins = new ScoreMoins();
        objetBarreEnergie = new BarreEnergie();
    }

	public void mouvement(int position)
    {
        positionBalle = position;
    }

    void Update()
    {
        if (positionBalle == 1 && balle1 != null)
        {
            transform.position = balle1.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle1);
        }
        else if (positionBalle == 2 && balle2 != null)
        {
            transform.position = balle2.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle2);
        }
        else if (positionBalle == 3 && balle3 != null)
        {
            transform.position = balle3.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle3);
        }
        else if (positionBalle == 4 && balle4 != null)
        {
            transform.position = balle4.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle4);
        }
        else if (positionBalle == 5 && balle5 != null)
        {
            transform.position = balle5.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle5);
        }
        if (positionBalle == 6 && balle6 != null)
        {
            transform.position = balle6.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle6);
        }
        else if (positionBalle == 7 && balle7 != null)
        {
            transform.position = balle7.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.decTerre();
            objectScoreMoins.scm();
            Destroy(balle7);
        }
        else if (positionBalle == 8 && balle8 != null)
        {
            transform.position = balle8.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle8);
        }
        else if (positionBalle == 9 && balle9 != null)
        {
            transform.position = balle9.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle9);
        }
        else if (positionBalle == 10 && balle10 != null)
        {
            transform.position = balle10.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incNavette();
            Destroy(balle10);
        }
        if (positionBalle == 11 && balle11 != null)
        {
            transform.position = balle11.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle11);
        }
        else if (positionBalle == 12 && balle12 != null)
        {
            transform.position = balle12.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle12);
        }
        else if (positionBalle == 13 && balle13 != null)
        {
            transform.position = balle13.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle13);
        }
        else if (positionBalle == 14 && balle14 != null)
        {
            transform.position = balle14.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle14);
        }
        else if (positionBalle == 15 && balle15 != null)
        {
            transform.position = balle15.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle15);
        }
        if (positionBalle == 16 && balle16 != null)
        {
            transform.position = balle16.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incNavette();
            Destroy(balle16);
        }
        else if (positionBalle == 17 && balle17 != null)
        {
            transform.position = balle17.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle17);
        }
        else if (positionBalle == 18 && balle18 != null)
        {
            transform.position = balle18.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle18);
        }
        else if (positionBalle == 19 && balle19 != null)
        {
            transform.position = balle19.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle19);
        }
        else if (positionBalle == 20 && balle20 != null)
        {
            transform.position = balle20.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle20);
        }
        if (positionBalle == 21 && balle21 != null)
        {
            transform.position = balle21.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle21);
        }
        else if (positionBalle == 22 && balle22 != null)
        {
            transform.position = balle22.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incNavette();
            Destroy(balle22);
        }
        else if (positionBalle == 23 && balle23 != null)
        {
            transform.position = balle23.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle23);
        }
        else if (positionBalle == 24 && balle24 != null)
        {
            transform.position = balle24.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle24);
        }
        else if (positionBalle == 25 && balle25 != null)
        {
            transform.position = balle25.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle25);
        }
        if (positionBalle == 26 && balle26 != null)
        {
            transform.position = balle26.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle26);
        }
        else if (positionBalle == 27 && balle27 != null)
        {
            transform.position = balle27.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle27);
        }
        else if (positionBalle == 28 && balle28 != null)
        {
            Son.PlayOneShot(rechargeLaser,0.6f);
            objetBarreEnergie.baril();
            Destroy(balle28);
        }
        else if (positionBalle == 29 && balle29 != null)
        {
            transform.position = balle29.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle29);
        }
        else if (positionBalle == 30 && balle30 != null)
        {
            transform.position = balle30.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle30);
        }
        if (positionBalle == 31 && balle31 != null)
        {
            transform.position = balle31.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle31);
        }
        else if (positionBalle == 32 && balle32 != null)
        {
            transform.position = balle32.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle32);
        }
        else if (positionBalle == 33 && balle33 != null)
        {
            transform.position = balle33.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle33);
        }
        else if (positionBalle == 34 && balle34 != null)
        {
            transform.position = balle34.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle34);
        }
        else if (positionBalle == 35 && balle35 != null)
        {
            transform.position = balle35.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle35);
        }
        if (positionBalle == 36 && balle36 != null)
        {
            transform.position = balle36.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle36);
        }
        else if (positionBalle == 37 && balle37 != null)
        {
            transform.position = balle37.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.decTerre();
            objectScoreMoins.scm();
            Destroy(balle37);
        }
        else if (positionBalle == 38 && balle38 != null)
        {
            transform.position = balle38.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle38);
        }
        else if (positionBalle == 39 && balle39 != null)
        {
            transform.position = balle39.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incrementer();
            Destroy(balle39);
        }
        else if (positionBalle == 40 && balle40 != null)
        {
            transform.position = balle40.transform.position;
            objetExploder.VerifPosition(true);
            Son.PlayOneShot(musique, 0.6f);
            monScore.incNavette();
            Destroy(balle40);
        }
    }
}
