using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementBalle : MonoBehaviour {

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
    public GameObject camera;
    public GameObject ABouton;
    bool posBalle1 = false;
    bool posBalle2 = false;
    bool posBalle3 = false;
    bool posBalle4 = false;
    bool posBalle5 = false;
    bool posBalle6 = false;
    bool posBalle7 = false;
    bool posBalle8 = false;
    bool posBalle9 = false;
    bool posBalle10 = false;
    bool posBalle11 = false;
    bool posBalle12 = false;
    bool posBalle13 = false;
    bool posBalle14 = false;
    bool posBalle15 = false;
    bool posBalle16 = false;
    bool posBalle17 = false;
    bool posBalle18 = false;
    bool posBalle19 = false;
    bool posBalle20 = false;
    bool posBalle21 = false;
    bool posBalle22 = false;
    bool posBalle23 = false;
    bool posBalle24 = false;
    bool posBalle25 = false;
    bool posBalle26 = false;
    bool posBalle27 = false;
    bool posBalle28 = false;
    bool posBalle29 = false;
    bool posBalle30 = false;
    bool posBalle31 = false;
    bool posBalle32 = false;
    bool posBalle33 = false;
    bool posBalle34 = false;
    bool posBalle35 = false;
    bool posBalle36 = false;
    bool posBalle37 = false;
    bool posBalle38 = false;
    bool posBalle39 = false;
    bool posBalle40 = false;

    float TempsDebut;
    float posAleaX;
    float posAleaY;
    float posAleaZ;
    bool testDepart = true;
    MenuFinal objetMenuFinal;


	void Start () {
        Random.seed = System.DateTime.Now.Millisecond;
        objetMenuFinal = new MenuFinal();
	}

	void Update () {

        if(!balle1 && !balle2 && !balle3 && !balle4 && !balle5 && !balle6 && !balle8 && !balle9 && !balle10 && !balle11 && !balle12 && !balle13 && !balle14 && !balle15 && !balle16 && !balle17 && !balle18 && !balle19 && !balle20 && !balle21 && !balle22 && !balle23 && !balle24 && !balle25 && !balle26 && !balle27 && !balle29 && !balle30 && !balle31 && !balle32 && !balle33 && !balle34 && !balle35 && !balle36 && !balle38 && !balle39 && !balle40){
            objetMenuFinal.finDuJeu();
        }

        if (ABouton == null)
        {
            if (testDepart == true)
            {
                testDepart = false;
                TempsDebut = Time.time;
            }
            float tempsDepuisDebut = Time.time - TempsDebut;
            if (tempsDepuisDebut > 3)
            {//spawn d'autres boules

                //Balle1
                if (balle1 != null && posBalle1 == false)
                {
                    posBalle1 = true;
                    posAleaX = Random.Range(0.6f, 1f);
                    posAleaY = Random.Range(-0.7f, 0.7f);
                    posAleaZ = Random.Range(-2.8f, -1.5f);
                    balle1.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle1 != null)
                {
                    balle1.transform.RotateAround(camera.transform.position, balle1.transform.up, 20 * Time.deltaTime);
                }

                //Balle2
                if (balle2 != null && posBalle2 == false)
                {
                    posBalle2 = true;
                    posAleaX = Random.Range(-1.8f, -1f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.5f, 2.8f);
                    balle2.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle2 != null)
                {
                    balle2.transform.RotateAround(camera.transform.position, balle2.transform.up * -1, 30 * Time.deltaTime);
                }

                //Balle3
                if (balle3 != null && posBalle3 == false)
                {
                    posBalle3 = true;
                    posAleaX = Random.Range(0.4f, 1f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.8f, -1.5f);
                    balle3.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle3 != null)
                {
                    balle3.transform.RotateAround(camera.transform.position, balle3.transform.up, 45 * Time.deltaTime);
                }

                //Balle4
                if (balle4 != null && posBalle4 == false)
                {
                    posBalle4 = true;
                    posAleaX = Random.Range(-1.8f, -0.6f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.5f, 3f);
                    balle4.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle4 != null)
                {
                    balle4.transform.RotateAround(camera.transform.position, balle4.transform.up * -1, 25 * Time.deltaTime);
                }
            }


            if (tempsDepuisDebut > 10)
            {//spawn d'autres boules

                //Balle5
                if (balle5 != null && posBalle5 == false)
                {
                    posBalle5 = true;
                    posAleaX = Random.Range(0.6f, 1f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.6f, 3f);
                    balle5.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle5 != null)
                {
                    balle5.transform.RotateAround(camera.transform.position, balle5.transform.up, 20 * Time.deltaTime);
                }

                //Balle6
                if (balle6 != null && posBalle6 == false)
                {
                    posBalle6 = true;
                    posAleaX = Random.Range(-1.7f, -0.8f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.7f, -1.3f);
                    balle6.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle6 != null)
                {
                    balle6.transform.RotateAround(camera.transform.position, balle6.transform.up * -1, 30 * Time.deltaTime);
                }

                //Balle7
                if (balle7 != null && posBalle7 == false)
                {
                    posBalle7 = true;
                    posAleaX = Random.Range(0.4f, 1f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.5f, 3f);
                    balle7.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle7 != null)
                {
                    balle7.transform.RotateAround(camera.transform.position, balle7.transform.up * -1, 40 * Time.deltaTime);
                }

                //Balle8
                if (balle8 != null && posBalle8 == false)
                {
                    posBalle8 = true;
                    posAleaX = Random.Range(-2f, -1f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.8f, -1.4f);
                    balle8.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle8 != null)
                {
                    balle8.transform.RotateAround(camera.transform.position, balle8.transform.up, 25 * Time.deltaTime);
                }
            }

            if (tempsDepuisDebut > 17)
            {//spawn d'autres boules

                //Balle9
                if (balle9 != null && posBalle9 == false)
                {
                    posBalle9 = true;
                    posAleaX = Random.Range(0.6f, 0.9f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.3f, 2.7f);
                    balle9.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle9 != null)
                {
                    balle9.transform.RotateAround(camera.transform.position, balle9.transform.up, 20 * Time.deltaTime);
                }

                //Balle10
                if (balle10 != null && posBalle10 == false)
                {
                    posBalle10 = true;
                    posAleaX = Random.Range(-1.8f, -0.6f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.9f, -1.3f);
                    balle10.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle10 != null)
                {
                    balle10.transform.RotateAround(camera.transform.position, balle10.transform.up * -1, 30 * Time.deltaTime);
                }

                //Balle11
                if (balle11 != null && posBalle11 == false)
                {
                    posBalle11 = true;
                    posAleaX = Random.Range(0.4f, 0.8f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.3f, 2.6f);
                    balle11.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle11 != null)
                {
                    balle11.transform.RotateAround(camera.transform.position, balle11.transform.up, 40 * Time.deltaTime);
                }

                //Balle12
                if (balle12 != null && posBalle12 == false)
                {
                    posBalle12 = true;
                    posAleaX = Random.Range(-1.7f, -0.9f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.8f, -1f);
                    balle12.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle12 != null)
                {
                    balle12.transform.RotateAround(camera.transform.position, balle12.transform.up, 25 * Time.deltaTime);
                }
            }

            if (tempsDepuisDebut > 24)
            {//spawn d'autres boules

                //Balle13
                if (balle13 != null && posBalle13 == false)
                {
                    posBalle13 = true;
                    posAleaX = Random.Range(0.5f, 0.7f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.3f, 3f);
                    balle13.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle13 != null)
                {
                    balle13.transform.RotateAround(camera.transform.position, balle13.transform.up, 20 * Time.deltaTime);
                }

                //Balle14
                if (balle14 != null && posBalle14 == false)
                {
                    posBalle14 = true;
                    posAleaX = Random.Range(-1.7f, -0.6f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.5f, -1.4f);
                    balle14.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle14 != null)
                {
                    balle14.transform.RotateAround(camera.transform.position, balle14.transform.up * -1, 30 * Time.deltaTime);
                }

                //Balle15
                if (balle15 != null && posBalle15 == false)
                {
                    posBalle15 = true;
                    posAleaX = Random.Range(0.5f, 0.9f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.5f, 2.5f);
                    balle15.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle15 != null)
                {
                    balle15.transform.RotateAround(camera.transform.position, balle15.transform.up, 40 * Time.deltaTime);
                }

                //Balle16
                if (balle16 != null && posBalle16 == false)
                {
                    posBalle16 = true;
                    posAleaX = Random.Range(-1.9f, -0.8f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.8f, -1.6f);
                    balle16.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle16 != null)
                {
                    balle16.transform.RotateAround(camera.transform.position, balle16.transform.up, 25 * Time.deltaTime);
                }
            }

            if (tempsDepuisDebut > 31)
            {//spawn d'autres boules

                //Balle17
                if (balle17 != null && posBalle17 == false)
                {
                    posBalle17 = true;
                    posAleaX = Random.Range(0.6f, 1f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.4f, 2.9f);
                    balle17.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle17 != null)
                {
                    balle17.transform.RotateAround(camera.transform.position, balle17.transform.up, 20 * Time.deltaTime);
                }

                //Balle18
                if (balle18 != null && posBalle18 == false)
                {
                    posBalle18 = true;
                    posAleaX = Random.Range(-1.8f, -0.6f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.5f, -1.2f);
                    balle18.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle18 != null)
                {
                    balle18.transform.RotateAround(camera.transform.position, balle18.transform.up * -1, 30 * Time.deltaTime);
                }

                //Balle19
                if (balle19 != null && posBalle19 == false)
                {
                    posBalle19 = true;
                    posAleaX = Random.Range(1f, 1.3f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.5f, 3f);
                    balle19.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle19 != null)
                {
                    balle19.transform.RotateAround(camera.transform.position, balle19.transform.up, 40 * Time.deltaTime);
                }

                //Balle20
                if (balle20 != null && posBalle20 == false)
                {
                    posBalle20 = true;
                    posAleaX = Random.Range(-1.9f, -1f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.7f, 1.8f);
                    balle20.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle20 != null)
                {
                    balle20.transform.RotateAround(camera.transform.position, balle20.transform.up, 25 * Time.deltaTime);
                }
            }

            if (tempsDepuisDebut > 38)
            {//spawn d'autres boules

                //Balle1
                if (balle21 != null && posBalle21 == false)
                {
                    posBalle21 = true;
                    posAleaX = Random.Range(0.6f, 1f);
                    posAleaY = Random.Range(-0.7f, 0.7f);
                    posAleaZ = Random.Range(-2.8f, -1.5f);
                    balle21.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle21 != null)
                {
                    balle21.transform.RotateAround(camera.transform.position, balle21.transform.up, 20 * Time.deltaTime);
                }

                //Balle22
                if (balle22 != null && posBalle22 == false)
                {
                    posBalle22 = true;
                    posAleaX = Random.Range(-1.8f, -1f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.5f, 2.8f);
                    balle22.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle22 != null)
                {
                    balle22.transform.RotateAround(camera.transform.position, balle22.transform.up * -1, 30 * Time.deltaTime);
                }

                //Balle23
                if (balle23 != null && posBalle23 == false)
                {
                    posBalle23 = true;
                    posAleaX = Random.Range(0.4f, 1f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.8f, -1.5f);
                    balle23.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle23 != null)
                {
                    balle23.transform.RotateAround(camera.transform.position, balle23.transform.up, 45 * Time.deltaTime);
                }

                //Balle4
                if (balle24 != null && posBalle24 == false)
                {
                    posBalle24 = true;
                    posAleaX = Random.Range(-1.8f, -0.6f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.5f, 3f);
                    balle24.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle24 != null)
                {
                    balle24.transform.RotateAround(camera.transform.position, balle24.transform.up * -1, 25 * Time.deltaTime);
                }
            }


            if (tempsDepuisDebut > 45)
            {//spawn d'autres boules

                //Balle25
                if (balle25 != null && posBalle25 == false)
                {
                    posBalle25 = true;
                    posAleaX = Random.Range(0.6f, 1f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.6f, 3f);
                    balle25.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle25 != null)
                {
                    balle25.transform.RotateAround(camera.transform.position, balle25.transform.up, 20 * Time.deltaTime);
                }

                //Balle26
                if (balle26 != null && posBalle26 == false)
                {
                    posBalle26 = true;
                    posAleaX = Random.Range(-1.7f, -0.8f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.7f, -1.3f);
                    balle26.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle26 != null)
                {
                    balle26.transform.RotateAround(camera.transform.position, balle26.transform.up * -1, 30 * Time.deltaTime);
                }

                //Balle27
                if (balle27 != null && posBalle27 == false)
                {
                    posBalle27 = true;
                    posAleaX = Random.Range(0.4f, 1f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.5f, 3f);
                    balle27.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle27 != null)
                {
                    balle27.transform.RotateAround(camera.transform.position, balle27.transform.up * -1, 40 * Time.deltaTime);
                }

                //Balle28
                if (balle28 != null && posBalle28 == false)
                {
                    posBalle28 = true;
                    posAleaX = Random.Range(-2f, -1f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.8f, -1.4f);
                    balle28.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle28 != null)
                {
                    balle28.transform.RotateAround(camera.transform.position, balle28.transform.up, 25 * Time.deltaTime);
                }
            }

            if (tempsDepuisDebut > 52)
            {//spawn d'autres boules

                //Balle29
                if (balle29 != null && posBalle29 == false)
                {
                    posBalle29 = true;
                    posAleaX = Random.Range(0.6f, 0.9f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.3f, 2.7f);
                    balle29.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle29 != null)
                {
                    balle29.transform.RotateAround(camera.transform.position, balle29.transform.up, 20 * Time.deltaTime);
                }

                //Balle30
                if (balle30 != null && posBalle30 == false)
                {
                    posBalle30 = true;
                    posAleaX = Random.Range(-1.8f, -0.6f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.9f, -1.3f);
                    balle30.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle30 != null)
                {
                    balle30.transform.RotateAround(camera.transform.position, balle30.transform.up * -1, 30 * Time.deltaTime);
                }

                //Balle31
                if (balle31 != null && posBalle31 == false)
                {
                    posBalle31 = true;
                    posAleaX = Random.Range(0.4f, 0.8f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.3f, 2.6f);
                    balle31.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle31 != null)
                {
                    balle31.transform.RotateAround(camera.transform.position, balle31.transform.up, 40 * Time.deltaTime);
                }

                //Balle32
                if (balle32 != null && posBalle32 == false)
                {
                    posBalle32 = true;
                    posAleaX = Random.Range(-1.7f, -0.9f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.8f, -1f);
                    balle32.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle32 != null)
                {
                    balle32.transform.RotateAround(camera.transform.position, balle32.transform.up, 25 * Time.deltaTime);
                }
            }

            if (tempsDepuisDebut > 59)
            {//spawn d'autres boules

                //Balle33
                if (balle33 != null && posBalle33 == false)
                {
                    posBalle33 = true;
                    posAleaX = Random.Range(0.5f, 0.7f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.3f, 3f);
                    balle33.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle33 != null)
                {
                    balle33.transform.RotateAround(camera.transform.position, balle33.transform.up, 20 * Time.deltaTime);
                }

                //Balle34
                if (balle34 != null && posBalle34 == false)
                {
                    posBalle34 = true;
                    posAleaX = Random.Range(-1.7f, -0.6f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.5f, -1.4f);
                    balle34.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle34 != null)
                {
                    balle34.transform.RotateAround(camera.transform.position, balle34.transform.up * -1, 30 * Time.deltaTime);
                }

                //Balle35
                if (balle35 != null && posBalle35 == false)
                {
                    posBalle35 = true;
                    posAleaX = Random.Range(0.5f, 0.9f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.5f, 2.5f);
                    balle35.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle35 != null)
                {
                    balle35.transform.RotateAround(camera.transform.position, balle35.transform.up, 40 * Time.deltaTime);
                }

                //Balle36
                if (balle36 != null && posBalle36 == false)
                {
                    posBalle36 = true;
                    posAleaX = Random.Range(-1.9f, -0.8f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.8f, -1.6f);
                    balle36.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle36 != null)
                {
                    balle36.transform.RotateAround(camera.transform.position, balle36.transform.up, 25 * Time.deltaTime);
                }
            }

            if (tempsDepuisDebut > 66)
            {//spawn d'autres boules

                //Balle37
                if (balle37 != null && posBalle37 == false)
                {
                    posBalle37 = true;
                    posAleaX = Random.Range(0.6f, 1f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.4f, 2.9f);
                    balle37.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle37 != null)
                {
                    balle37.transform.RotateAround(camera.transform.position, balle37.transform.up, 20 * Time.deltaTime);
                }

                //Balle38
                if (balle38 != null && posBalle38 == false)
                {
                    posBalle38 = true;
                    posAleaX = Random.Range(-1.8f, -0.6f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.5f, -1.2f);
                    balle38.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle38 != null)
                {
                    balle38.transform.RotateAround(camera.transform.position, balle38.transform.up * -1, 30 * Time.deltaTime);
                }

                //Balle39
                if (balle39 != null && posBalle39 == false)
                {
                    posBalle39 = true;
                    posAleaX = Random.Range(1f, 1.3f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(1.5f, 3f);
                    balle39.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle39 != null)
                {
                    balle39.transform.RotateAround(camera.transform.position, balle39.transform.up, 40 * Time.deltaTime);
                }

                //Balle40
                if (balle40 != null && posBalle40 == false)
                {
                    posBalle40 = true;
                    posAleaX = Random.Range(-1.9f, -1f);
                    posAleaY = Random.Range(-0.8f, 0.8f);
                    posAleaZ = Random.Range(-2.7f, 1.8f);
                    balle40.transform.position = new Vector3(posAleaX, posAleaY, posAleaZ);
                }
                if (balle40 != null)
                {
                    balle40.transform.RotateAround(camera.transform.position, balle40.transform.up, 25 * Time.deltaTime);
                }
            }
        }
	}
}
