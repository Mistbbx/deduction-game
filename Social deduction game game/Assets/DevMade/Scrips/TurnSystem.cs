using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TurnSystem : MonoBehaviour
{

    public static int turnNr;
    public TextMeshProUGUI turnText;
    public bool isBlackScreen;

    public static bool startTurn;
    public GameObject blackScreen;
    public static bool isDay;


    // Start is called before the first frame update
    void Start()
    {

        turnNr = 0;
        isBlackScreen = true;
        blackScreen.SetActive(true);
        startTurn = false;
    }

    // Update is called once per frame
    void Update()
    {
    turnText.text = "Player nr: " + turnNr+ "'s turn";
    
    }

    public void NextTurn()
    {
        if (isBlackScreen)
        {
            if (turnNr == 8){turnNr = 0;}
            turnNr++;
            DisplayRole.displayId = PlayerDeck.staticDeck[turnNr-1];
            blackScreen.SetActive(false);
            isBlackScreen = false;

        }
        else
        {
            blackScreen.SetActive(true);
            isBlackScreen = true;
        }


    }
}
