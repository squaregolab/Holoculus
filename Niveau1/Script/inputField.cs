using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputField : MonoBehaviour {

    public InputField mainInputField;
    bool testUneFois = true;
    static bool testttt = false;
    string monNom;
    MenuFinal objetMenuFinal;

	void Start () {
        objetMenuFinal = new MenuFinal();
	}

    void Update()
    {

        //Permet de mettre le focus sur la fenetre une fois
        if (testUneFois && testttt)
        {
            testUneFois = false;
            mainInputField.ActivateInputField();
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            monNom = mainInputField.text;
            objetMenuFinal.envoieDuNom(monNom);
            mainInputField.text = "";
        }
    }

    public void activerField()
    {
        testttt = true;
    }
}
