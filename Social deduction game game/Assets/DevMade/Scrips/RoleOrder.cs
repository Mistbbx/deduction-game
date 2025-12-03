using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{

    public List<Role> container = new List<Role>();
    public int x;
    public static int playerAmount;
    public static int[] staticDeck = new int[8];


    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        playerAmount = 8;
        
        staticDeck[0] = 1;
        staticDeck[1] = 1;
        staticDeck[2] = 1;
        staticDeck[3] = 1;
        staticDeck[4] = 2;
        staticDeck[5] = 2;
        staticDeck[6] = 3;
        staticDeck[7] = 4;
        /*for (int i = 0; i < playerAmount; i++)
        {
            1 1 1 1 2 2 3 4
            x = Random.Range(1, 4);
            deck[i] = RoleDatabase.roleList[x];
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shuffle()
    {
        for (int i = 0; i < playerAmount; i++)
        {

        }
        return;
    }

}
