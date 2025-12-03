using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleDatabase : MonoBehaviour
{
    public static List<Role> roleList = new List<Role>();

    void Awake()
    {
        Debug.Log("Awaken");
        roleList.Add(new Role(0, "none", -1, "none", Resources.Load<Sprite>("")));
        roleList.Add(new Role(1, "Citizan", 0, "Kill all the cultist", Resources.Load<Sprite>("image12")));
        roleList.Add(new Role(2, "Cultist", 1, "protect 1 each night (not twice in a row), win if 4 remain af the last night", Resources.Load<Sprite>("image11")));
        roleList.Add(new Role(3, "Serial Killer", 2, "If you survive and your 2 targets are dead you win", Resources.Load<Sprite>("image12")));
        roleList.Add(new Role(4, "Parasite", 3, "If you and you target survives you win", Resources.Load<Sprite>("image11")));
    }
}
