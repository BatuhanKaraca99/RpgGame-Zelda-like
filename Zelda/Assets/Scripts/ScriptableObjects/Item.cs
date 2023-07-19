using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    //which sprite we need to put
    //dialog box
    public Sprite itemSprite;
    public string itemDescription;
    public bool isKey;

}
