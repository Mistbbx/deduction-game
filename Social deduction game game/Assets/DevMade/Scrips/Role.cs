using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
[Serializable]

public class Role
{
    public int id;
    public string roleName;
    public int side;
    public string roleDesc;
    public Sprite roleSprite;
    public bool isExecutioner;

    public Role()
    {

    }

    public Role(int Id, string RoleName, int Side, string RoleDesc, Sprite RoleSprite)
    {
        id = Id;
        roleName = RoleName;
        side = Side;
        roleDesc = RoleDesc;
        roleSprite = RoleSprite;
        isExecutioner = false;
        
    }


}
