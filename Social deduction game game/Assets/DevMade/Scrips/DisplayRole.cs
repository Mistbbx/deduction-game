using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.U2D.Aseprite;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DisplayRole : MonoBehaviour
{
    public List<Role> displayRole = new List<Role>();
    public static int displayId;

    public int id;
    public string roleName;
    public int side;
    public bool isExecutioner;
    public string roleDesc;
    public Sprite roleSprite;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descText;
    public Image roleImage;

    public int numberOfRolesInDeck;

    // Start is called before the first frame update
    void Start()
    {
        // numberOfRolesInDeck = PlayerDeck.deckSize;
        //displayRole.Add(RoleDatabase.roleList[0]);
        
        for (int i = 0; i < 5; i++)
        {
            displayRole.Add(RoleDatabase.roleList[i]);
            //displayRole[0] = RoleDatabase.roleList[id];
            Debug.Log(displayRole[i].id);
        }
    }

    // Update is called once per frame
    void Update()
    {
        id = displayRole[displayId].id;
        roleName = displayRole[id].roleName;
        side = displayRole[id].side;
        roleDesc = displayRole[id].roleDesc;
        roleSprite = displayRole[id].roleSprite;
        isExecutioner = displayRole[id].isExecutioner;

        nameText.text = "" + roleName;
        descText.text = "" + roleDesc;
        roleImage.sprite = roleSprite;

    }
}
