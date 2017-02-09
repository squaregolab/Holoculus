using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuFinal : MonoBehaviour {

    public GameObject fondNoir;
    public GameObject titre;
    public GameObject Textescore;
    public GameObject Score;
    public GameObject TexteTemps;
    public GameObject Temps;
    public GameObject TexteEnergie;
    public GameObject Energie;
    public GameObject TexteClassement;
    public GameObject Classement;
    public GameObject inputText;
    public GameObject entrezNom;
    public GameObject titreClassement;
    public GameObject nom1;
    public GameObject score1;
    public GameObject nom2;
    public GameObject score2;
    public GameObject nom3;
    public GameObject score3;
    public GameObject nom4;
    public GameObject score4;
    public GameObject nom5;
    public GameObject score5;
    public GameObject nom6;
    public GameObject score6;
    public GameObject nom7;
    public GameObject score7;
    public GameObject nom8;
    public GameObject score8;
    public GameObject nom9;
    public GameObject score9;
    public GameObject nom10;
    public GameObject score10;
    static bool finNiveau = false;
    int monEnergiiiiiiiie;
    Score objetScore;
    BarreEnergie objetBarreEnerergie;
    ManagerManette objetManagerManette;
    int scoreFinal = 0;
    Color monfondNoir;
    Color monTitre;
    Color monTexteScore;
    Color monScore;
    Color montexteTemps;
    Color monTemps;
    Color montexteEnergie;
    Color monEnergie;
    Color monTexteClassement;
    Color monClassement;
    Color monInputText;
    Color monEntrezNom;
    Color montitreClassement;
    Color monNom1;
    Color monScore1;
    Color monNom2;
    Color monScore2;
    Color monNom3;
    Color monScore3;
    Color monNom4;
    Color monScore4;
    Color monNom5;
    Color monScore5;
    Color monNom6;
    Color monScore6;
    Color monNom7;
    Color monScore7;
    Color monNom8;
    Color monScore8;
    Color monNom9;
    Color monScore9;
    Color monNom10;
    Color monScore10;
    float timeFade = 0;
    float tempsFinal = 0;
    bool testUneFois = false;
    int nbJoueur;
    private List<int> maListe = new List<int>();
    int nbIntList = 0;
    int ScoreFinalFinal = 0;
    int numeroCLassement = 0;
    int i = 0;
    int k = 0;
    private inputField objetInputfield;
    private ManagerManette objetManagerMAnette;
    static string monNom;
    static bool entrer = false;


	void Start () {

        objetInputfield = new inputField();
        objetManagerMAnette = new ManagerManette();
        nbJoueur = PlayerPrefs.GetInt("nbJoueur");
        objetScore = new Score();
        objetBarreEnerergie = new BarreEnergie();
        objetManagerManette = new ManagerManette();

        monfondNoir = new Color(fondNoir.GetComponent<RawImage>().color.r, fondNoir.GetComponent<RawImage>().color.g, fondNoir.GetComponent<RawImage>().color.b, 0.97f);
        monTitre = new Color(titre.GetComponent<Text>().color.r, titre.GetComponent<Text>().color.g, titre.GetComponent<Text>().color.b, 1f);
        monTexteScore = new Color(Textescore.GetComponent<Text>().color.r, Textescore.GetComponent<Text>().color.g, Textescore.GetComponent<Text>().color.b, 1f);
        monScore = new Color(Score.GetComponent<Text>().color.r, Score.GetComponent<Text>().color.g, Score.GetComponent<Text>().color.b, 1f);
        montexteTemps = new Color(TexteTemps.GetComponent<Text>().color.r, TexteTemps.GetComponent<Text>().color.g, TexteTemps.GetComponent<Text>().color.b, 1f);
        monTemps = new Color(Temps.GetComponent<Text>().color.r, Temps.GetComponent<Text>().color.g, Temps.GetComponent<Text>().color.b, 1f);
        montexteEnergie = new Color(TexteEnergie.GetComponent<Text>().color.r, TexteEnergie.GetComponent<Text>().color.g, TexteEnergie.GetComponent<Text>().color.b, 1f);
        monEnergie = new Color(Energie.GetComponent<Text>().color.r, Energie.GetComponent<Text>().color.g, Energie.GetComponent<Text>().color.b, 1f);
        monTexteClassement = new Color(TexteClassement.GetComponent<Text>().color.r, TexteClassement.GetComponent<Text>().color.g, TexteClassement.GetComponent<Text>().color.b, 1f);
        monClassement = new Color(Classement.GetComponent<Text>().color.r, Classement.GetComponent<Text>().color.g, Classement.GetComponent<Text>().color.b, 1f);
        monInputText = new Color(inputText.GetComponent<Image>().color.r, inputText.GetComponent<Image>().color.g, inputText.GetComponent<Image>().color.b, 1f);
        monEntrezNom = new Color(entrezNom.GetComponent<Text>().color.r, entrezNom.GetComponent<Text>().color.g, entrezNom.GetComponent<Text>().color.b, 1f);
        montitreClassement = new Color(titreClassement.GetComponent<Text>().color.r, titreClassement.GetComponent<Text>().color.g, titreClassement.GetComponent<Text>().color.b, 1f);
        monNom1 = new Color(nom1.GetComponent<Text>().color.r, nom1.GetComponent<Text>().color.g, nom1.GetComponent<Text>().color.b, 1f);
        monScore1 = new Color(score1.GetComponent<Text>().color.r, score1.GetComponent<Text>().color.g, score1.GetComponent<Text>().color.b, 1f);
        monNom2 = new Color(nom2.GetComponent<Text>().color.r, nom2.GetComponent<Text>().color.g, nom2.GetComponent<Text>().color.b, 1f);
        monScore2 = new Color(score2.GetComponent<Text>().color.r, score2.GetComponent<Text>().color.g, score2.GetComponent<Text>().color.b, 1f);
        monNom3 = new Color(nom3.GetComponent<Text>().color.r, nom3.GetComponent<Text>().color.g, nom3.GetComponent<Text>().color.b, 1f);
        monScore3 = new Color(score3.GetComponent<Text>().color.r, score3.GetComponent<Text>().color.g, score3.GetComponent<Text>().color.b, 1f);
        monNom4 = new Color(nom4.GetComponent<Text>().color.r, nom4.GetComponent<Text>().color.g, nom4.GetComponent<Text>().color.b, 1f);
        monScore4 = new Color(score4.GetComponent<Text>().color.r, score4.GetComponent<Text>().color.g, score4.GetComponent<Text>().color.b, 1f);
        monNom5 = new Color(nom5.GetComponent<Text>().color.r, nom5.GetComponent<Text>().color.g, nom5.GetComponent<Text>().color.b, 1f);
        monScore5 = new Color(score5.GetComponent<Text>().color.r, score5.GetComponent<Text>().color.g, score5.GetComponent<Text>().color.b, 1f);
        monNom6 = new Color(nom6.GetComponent<Text>().color.r, nom6.GetComponent<Text>().color.g, nom6.GetComponent<Text>().color.b, 1f);
        monScore6 = new Color(score6.GetComponent<Text>().color.r, score6.GetComponent<Text>().color.g, score6.GetComponent<Text>().color.b, 1f);
        monNom7 = new Color(nom7.GetComponent<Text>().color.r, nom7.GetComponent<Text>().color.g, nom7.GetComponent<Text>().color.b, 1f);
        monScore7 = new Color(score7.GetComponent<Text>().color.r, score7.GetComponent<Text>().color.g, score7.GetComponent<Text>().color.b, 1f);
        monNom8 = new Color(nom8.GetComponent<Text>().color.r, nom8.GetComponent<Text>().color.g, nom8.GetComponent<Text>().color.b, 1f);
        monScore8 = new Color(score8.GetComponent<Text>().color.r, score8.GetComponent<Text>().color.g, score8.GetComponent<Text>().color.b, 1f);
        monNom9 = new Color(nom9.GetComponent<Text>().color.r, nom9.GetComponent<Text>().color.g, nom9.GetComponent<Text>().color.b, 1f);
        monScore9 = new Color(score9.GetComponent<Text>().color.r, score9.GetComponent<Text>().color.g, score9.GetComponent<Text>().color.b, 1f);
        monNom10 = new Color(nom10.GetComponent<Text>().color.r, nom10.GetComponent<Text>().color.g, nom10.GetComponent<Text>().color.b, 1f);
        monScore10 = new Color(score10.GetComponent<Text>().color.r, score10.GetComponent<Text>().color.g, score10.GetComponent<Text>().color.b, 1f);
	}
	
	// Update is called once per frame
    void Update()
    {
        if (finNiveau == true)
        {

            objetInputfield.activerField();
            objetManagerMAnette.arretEcrire();                   


            //On recupere les valeur dont on a besoin
            monEnergiiiiiiiie = (int) objetBarreEnerergie.retourEnergie();
            Energie.GetComponent<Text>().text = monEnergiiiiiiiie + " %";
            scoreFinal = objetScore.RetourScore();
            Score.GetComponent<Text>().text = scoreFinal + " POINT(S)";
            
            if(testUneFois == false){
                testUneFois = true;
                nbJoueur++;
                PlayerPrefs.SetInt("nbJoueur", nbJoueur);
                tempsFinal = objetManagerManette.getTemps();
            }
            

            ScoreFinalFinal = (scoreFinal + 100) - (int)tempsFinal + (monEnergiiiiiiiie * 2);
             ///*
            //On recupere le nombre de joueur
            nbIntList = PlayerPrefs.GetInt("nbJoueur");

            //On ajoute un joueuravec son score
            PlayerPrefs.SetInt("monScore_" + nbIntList, ScoreFinalFinal);
            PlayerPrefs.SetString("monNom_" + nbIntList, monNom); 

            //Boucle pour tester le classement des joueurs 
            while (i <= nbIntList)
            {
               if (ScoreFinalFinal <= PlayerPrefs.GetInt("monScore_" + (i + 1)))
               {
                   numeroCLassement++;
               }
               i++;
            }

            //Afficher mon classement
            Classement.GetComponent<Text>().text = numeroCLassement + "/" + nbJoueur;

            //*/

            //Remise a 0 du compteur
             
            /*

            PlayerPrefs.SetInt("nbJoueur", 0);
            for (int j = 0; j <= 40; j++ )
            {
                PlayerPrefs.SetInt("myList_" + j, 0);
                PlayerPrefs.SetString("monNom_" + j, ""); 
            }
             
            */

              
            //Timeur de ouf
            if (tempsFinal >= 60)
            {
                Temps.GetComponent<Text>().text = "01 :" + ((int) tempsFinal - 60);
                if (tempsFinal >= 120)
                {
                    Temps.GetComponent<Text>().text = "02 :" + ((int) tempsFinal - 120);
                    if (tempsFinal >= 180)
                    {
                        Temps.GetComponent<Text>().text = "03 :" + ((int) tempsFinal - 180);
                        if (tempsFinal >= 240)
                        {
                            Temps.GetComponent<Text>().text = "04 :" + ((int) tempsFinal - 240);
                        }
                    }
                }
            }
            else
            {
                Temps.GetComponent<Text>().text = "00 :" + (int) tempsFinal;
            }
            

            //Test si on a entrée le nom et appuyé sur entrer
            if(entrer){

                while (k < 10 )
                {
                    if (k == 0)
                    {
                        score1.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("monScore_" + (nbIntList - k));
                        nom1.GetComponent<Text>().text = PlayerPrefs.GetString("monNom_" + (nbIntList - k)); 
                    }
                    if (k == 1)
                    {
                        score2.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("monScore_" + (nbIntList - k));
                        nom2.GetComponent<Text>().text = PlayerPrefs.GetString("monNom_" + (nbIntList - k)); 
                    }
                    if (k == 2)
                    {
                        score3.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("monScore_" + (nbIntList - k));
                        nom3.GetComponent<Text>().text = PlayerPrefs.GetString("monNom_" + (nbIntList - k)); 
                    }
                    if (k == 3)
                    {
                        score4.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("monScore_" + (nbIntList - k));
                        nom4.GetComponent<Text>().text = PlayerPrefs.GetString("monNom_" + (nbIntList - k)); 
                    }
                    if (k == 4)
                    {
                        score5.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("monScore_" + (nbIntList - k));
                        nom5.GetComponent<Text>().text = PlayerPrefs.GetString("monNom_" + (nbIntList - k)); 
                    }
                    if (k == 5)
                    {
                        score6.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("monScore_" + (nbIntList - k));
                        nom6.GetComponent<Text>().text = PlayerPrefs.GetString("monNom_" + (nbIntList - k)); 
                    }
                    if (k == 6)
                    {
                        score7.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("monScore_" + (nbIntList - k));
                        nom7.GetComponent<Text>().text = PlayerPrefs.GetString("monNom_" + (nbIntList - k)); 
                    }
                    if (k == 7)
                    {
                        score8.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("monScore_" + (nbIntList - k));
                        nom8.GetComponent<Text>().text = PlayerPrefs.GetString("monNom_" + (nbIntList - k)); 
                    }
                    if (k == 8)
                    {
                        score9.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("monScore_" + (nbIntList - k));
                        nom9.GetComponent<Text>().text = PlayerPrefs.GetString("monNom_" + (nbIntList - k)); 

                    }
                    if (k == 9)
                    {
                        score10.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("monScore_" + (nbIntList - k));
                        nom10.GetComponent<Text>().text = PlayerPrefs.GetString("monNom_" + (nbIntList - k)); 
                    }
                    k++;
                }


                //fondNoir.GetComponent<RawImage>().color = new Color(fondNoir.GetComponent<RawImage>().color.r, fondNoir.GetComponent<RawImage>().color.g, fondNoir.GetComponent<RawImage>().color.b, 0f);
                titre.GetComponent<Text>().color = new Color(titre.GetComponent<Text>().color.r, titre.GetComponent<Text>().color.g, titre.GetComponent<Text>().color.b, 0f);
                Textescore.GetComponent<Text>().color = new Color(Textescore.GetComponent<Text>().color.r, Textescore.GetComponent<Text>().color.g, Textescore.GetComponent<Text>().color.b, 0f);
                Score.GetComponent<Text>().color = new Color(Score.GetComponent<Text>().color.r, Score.GetComponent<Text>().color.g, Score.GetComponent<Text>().color.b, 0f);
                TexteTemps.GetComponent<Text>().color = new Color(TexteTemps.GetComponent<Text>().color.r, TexteTemps.GetComponent<Text>().color.g, TexteTemps.GetComponent<Text>().color.b, 0f);
                Temps.GetComponent<Text>().color = new Color(Temps.GetComponent<Text>().color.r, Temps.GetComponent<Text>().color.g, Temps.GetComponent<Text>().color.b, 0f);
                TexteEnergie.GetComponent<Text>().color = new Color(TexteEnergie.GetComponent<Text>().color.r, TexteEnergie.GetComponent<Text>().color.g, TexteEnergie.GetComponent<Text>().color.b, 0f);
                Energie.GetComponent<Text>().color = new Color(Energie.GetComponent<Text>().color.r, Energie.GetComponent<Text>().color.g, Energie.GetComponent<Text>().color.b, 0f);
                TexteClassement.GetComponent<Text>().color = new Color(TexteClassement.GetComponent<Text>().color.r, TexteClassement.GetComponent<Text>().color.g, TexteClassement.GetComponent<Text>().color.b, 0f);
                Classement.GetComponent<Text>().color = new Color(Classement.GetComponent<Text>().color.r, Classement.GetComponent<Text>().color.g, Classement.GetComponent<Text>().color.b, 0f);
                entrezNom.GetComponent<Text>().color = new Color(entrezNom.GetComponent<Text>().color.r, entrezNom.GetComponent<Text>().color.g, entrezNom.GetComponent<Text>().color.b, 0f);
                inputText.GetComponent<Image>().color = new Color(inputText.GetComponent<Image>().color.r, inputText.GetComponent<Image>().color.g, inputText.GetComponent<Image>().color.b, 0f);
                titreClassement.GetComponent<Text>().color = Color.Lerp(titreClassement.GetComponent<Text>().color, montitreClassement, timeFade);
                nom1.GetComponent<Text>().color = Color.Lerp(nom1.GetComponent<Text>().color, monNom1, timeFade);
                score1.GetComponent<Text>().color = Color.Lerp(score1.GetComponent<Text>().color, monScore1, timeFade);
                nom2.GetComponent<Text>().color = Color.Lerp(nom2.GetComponent<Text>().color, monNom2, timeFade);
                score2.GetComponent<Text>().color = Color.Lerp(score2.GetComponent<Text>().color, monScore2, timeFade);
                nom3.GetComponent<Text>().color = Color.Lerp(nom3.GetComponent<Text>().color, monNom3, timeFade);
                score3.GetComponent<Text>().color = Color.Lerp(score3.GetComponent<Text>().color, monScore3, timeFade);
                nom4.GetComponent<Text>().color = Color.Lerp(nom4.GetComponent<Text>().color, monNom4, timeFade);
                score4.GetComponent<Text>().color = Color.Lerp(score4.GetComponent<Text>().color, monScore4, timeFade);
                nom5.GetComponent<Text>().color = Color.Lerp(nom5.GetComponent<Text>().color, monNom5, timeFade);
                score5.GetComponent<Text>().color = Color.Lerp(score5.GetComponent<Text>().color, monScore5, timeFade);
                nom6.GetComponent<Text>().color = Color.Lerp(nom6.GetComponent<Text>().color, monNom6, timeFade);
                score6.GetComponent<Text>().color = Color.Lerp(score6.GetComponent<Text>().color, monScore6, timeFade);
                nom7.GetComponent<Text>().color = Color.Lerp(nom7.GetComponent<Text>().color, monNom7, timeFade);
                score7.GetComponent<Text>().color = Color.Lerp(score7.GetComponent<Text>().color, monScore7, timeFade);
                nom8.GetComponent<Text>().color = Color.Lerp(nom8.GetComponent<Text>().color, monNom8, timeFade);
                score8.GetComponent<Text>().color = Color.Lerp(score8.GetComponent<Text>().color, monScore8, timeFade);
                nom9.GetComponent<Text>().color = Color.Lerp(nom9.GetComponent<Text>().color, monNom9, timeFade);
                score9.GetComponent<Text>().color = Color.Lerp(score9.GetComponent<Text>().color, monScore9, timeFade);
                nom10.GetComponent<Text>().color = Color.Lerp(nom10.GetComponent<Text>().color, monNom10, timeFade);
                score10.GetComponent<Text>().color = Color.Lerp(score10.GetComponent<Text>().color, monScore10, timeFade);
            }
            else{
                //Faire apparaitre le menu final
                fondNoir.GetComponent<RawImage>().color = Color.Lerp(fondNoir.GetComponent<RawImage>().color, monfondNoir, timeFade * 6);
                titre.GetComponent<Text>().color = Color.Lerp(titre.GetComponent<Text>().color, monTitre, timeFade);
                Textescore.GetComponent<Text>().color = Color.Lerp(Textescore.GetComponent<Text>().color, monTexteScore, timeFade);
                Score.GetComponent<Text>().color = Color.Lerp(Score.GetComponent<Text>().color, monScore, timeFade);
                TexteTemps.GetComponent<Text>().color = Color.Lerp(TexteTemps.GetComponent<Text>().color, montexteTemps, timeFade);
                Temps.GetComponent<Text>().color = Color.Lerp(Temps.GetComponent<Text>().color, monTemps, timeFade);
                TexteEnergie.GetComponent<Text>().color = Color.Lerp(TexteEnergie.GetComponent<Text>().color, montexteEnergie, timeFade);
                Energie.GetComponent<Text>().color = Color.Lerp(Energie.GetComponent<Text>().color, monEnergie, timeFade);
                TexteClassement.GetComponent<Text>().color = Color.Lerp(TexteClassement.GetComponent<Text>().color, monTexteClassement, timeFade);
                Classement.GetComponent<Text>().color = Color.Lerp(Classement.GetComponent<Text>().color, monClassement, timeFade);
                entrezNom.GetComponent<Text>().color = Color.Lerp(entrezNom.GetComponent<Text>().color, monEntrezNom, timeFade);
                inputText.GetComponent<Image>().color = Color.Lerp(inputText.GetComponent<Image>().color, monInputText, timeFade);

            }
            timeFade = timeFade + 0.001f;
            
        
        }
        else
        {
            fondNoir.GetComponent<RawImage>().color = new Color(fondNoir.GetComponent<RawImage>().color.r, fondNoir.GetComponent<RawImage>().color.g, fondNoir.GetComponent<RawImage>().color.b, 0f);
            titre.GetComponent<Text>().color = new Color(titre.GetComponent<Text>().color.r, titre.GetComponent<Text>().color.g, titre.GetComponent<Text>().color.b, 0f);
            Textescore.GetComponent<Text>().color = new Color(Textescore.GetComponent<Text>().color.r, Textescore.GetComponent<Text>().color.g, Textescore.GetComponent<Text>().color.b, 0f);
            Score.GetComponent<Text>().color = new Color(Score.GetComponent<Text>().color.r, Score.GetComponent<Text>().color.g, Score.GetComponent<Text>().color.b, 0f);
            TexteTemps.GetComponent<Text>().color = new Color(TexteTemps.GetComponent<Text>().color.r, TexteTemps.GetComponent<Text>().color.g, TexteTemps.GetComponent<Text>().color.b, 0f);
            Temps.GetComponent<Text>().color = new Color(Temps.GetComponent<Text>().color.r, Temps.GetComponent<Text>().color.g, Temps.GetComponent<Text>().color.b, 0f);
            TexteEnergie.GetComponent<Text>().color = new Color(TexteEnergie.GetComponent<Text>().color.r, TexteEnergie.GetComponent<Text>().color.g, TexteEnergie.GetComponent<Text>().color.b, 0f);
            Energie.GetComponent<Text>().color = new Color(Energie.GetComponent<Text>().color.r, Energie.GetComponent<Text>().color.g, Energie.GetComponent<Text>().color.b, 0f);
            TexteClassement.GetComponent<Text>().color = new Color(TexteClassement.GetComponent<Text>().color.r, TexteClassement.GetComponent<Text>().color.g, TexteClassement.GetComponent<Text>().color.b, 0f);
            Classement.GetComponent<Text>().color = new Color(Classement.GetComponent<Text>().color.r, Classement.GetComponent<Text>().color.g, Classement.GetComponent<Text>().color.b, 0f);
            entrezNom.GetComponent<Text>().color = new Color(entrezNom.GetComponent<Text>().color.r, entrezNom.GetComponent<Text>().color.g, entrezNom.GetComponent<Text>().color.b, 0f);
            inputText.GetComponent<Image>().color = new Color(inputText.GetComponent<Image>().color.r, inputText.GetComponent<Image>().color.g, inputText.GetComponent<Image>().color.b, 0f);
            titreClassement.GetComponent<Text>().color = new Color(titreClassement.GetComponent<Text>().color.r, titreClassement.GetComponent<Text>().color.g, titreClassement.GetComponent<Text>().color.b, 0f);
            nom1.GetComponent<Text>().color = new Color(nom1.GetComponent<Text>().color.r, nom1.GetComponent<Text>().color.g, nom1.GetComponent<Text>().color.b, 0f);
            score1.GetComponent<Text>().color = new Color(score1.GetComponent<Text>().color.r, score1.GetComponent<Text>().color.g, score1.GetComponent<Text>().color.b, 0f);
            nom2.GetComponent<Text>().color = new Color(nom2.GetComponent<Text>().color.r, nom2.GetComponent<Text>().color.g, nom2.GetComponent<Text>().color.b, 0f);
            score2.GetComponent<Text>().color = new Color(score2.GetComponent<Text>().color.r, score2.GetComponent<Text>().color.g, score2.GetComponent<Text>().color.b, 0f);
            nom3.GetComponent<Text>().color = new Color(nom3.GetComponent<Text>().color.r, nom3.GetComponent<Text>().color.g, nom3.GetComponent<Text>().color.b, 0f);
            score3.GetComponent<Text>().color = new Color(score3.GetComponent<Text>().color.r, score3.GetComponent<Text>().color.g, score3.GetComponent<Text>().color.b, 0f);
            nom4.GetComponent<Text>().color = new Color(nom4.GetComponent<Text>().color.r, nom4.GetComponent<Text>().color.g, nom4.GetComponent<Text>().color.b, 0f);
            score4.GetComponent<Text>().color = new Color(score4.GetComponent<Text>().color.r, score4.GetComponent<Text>().color.g, score4.GetComponent<Text>().color.b, 0f);
            nom5.GetComponent<Text>().color = new Color(nom5.GetComponent<Text>().color.r, nom5.GetComponent<Text>().color.g, nom5.GetComponent<Text>().color.b, 0f);
            score5.GetComponent<Text>().color = new Color(score5.GetComponent<Text>().color.r, score5.GetComponent<Text>().color.g, score5.GetComponent<Text>().color.b, 0f);
            nom6.GetComponent<Text>().color = new Color(nom6.GetComponent<Text>().color.r, nom6.GetComponent<Text>().color.g, nom6.GetComponent<Text>().color.b, 0f);
            score6.GetComponent<Text>().color = new Color(score6.GetComponent<Text>().color.r, score6.GetComponent<Text>().color.g, score6.GetComponent<Text>().color.b, 0f);
            nom7.GetComponent<Text>().color = new Color(nom7.GetComponent<Text>().color.r, nom7.GetComponent<Text>().color.g, nom7.GetComponent<Text>().color.b, 0f);
            score7.GetComponent<Text>().color = new Color(score7.GetComponent<Text>().color.r, score7.GetComponent<Text>().color.g, score7.GetComponent<Text>().color.b, 0f);
            nom8.GetComponent<Text>().color = new Color(nom8.GetComponent<Text>().color.r, nom8.GetComponent<Text>().color.g, nom8.GetComponent<Text>().color.b, 0f);
            score8.GetComponent<Text>().color = new Color(score8.GetComponent<Text>().color.r, score8.GetComponent<Text>().color.g, score8.GetComponent<Text>().color.b, 0f);
            nom9.GetComponent<Text>().color = new Color(nom9.GetComponent<Text>().color.r, nom9.GetComponent<Text>().color.g, nom9.GetComponent<Text>().color.b, 0f);
            score9.GetComponent<Text>().color = new Color(score9.GetComponent<Text>().color.r, score9.GetComponent<Text>().color.g, score9.GetComponent<Text>().color.b, 0f);
            nom10.GetComponent<Text>().color = new Color(nom10.GetComponent<Text>().color.r, nom10.GetComponent<Text>().color.g, nom10.GetComponent<Text>().color.b, 0f);
            score10.GetComponent<Text>().color = new Color(score10.GetComponent<Text>().color.r, score10.GetComponent<Text>().color.g, score10.GetComponent<Text>().color.b, 0f);

        }
    }

    public void finDuJeu()
    {
        finNiveau = true;
    }

    public void envoieDuNom(string nom)
    {
        monNom = nom;
        entrer = true;
    }
}
