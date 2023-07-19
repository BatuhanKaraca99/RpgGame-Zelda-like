using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    //we will send info to player
    public Item currentItem;
    public List<Item> items = new List<Item>();
    public int numberOfKeys;

    public void AddItem(Item itemtoAdd)
    {
        //Is the item a key?
        if (itemtoAdd.isKey)
        {
            numberOfKeys++;
        }
        else
        {
            if (!items.Contains(itemtoAdd))
            {
                items.Add(itemtoAdd);
            }
        }
    }
}
