using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvetoryManager : MonoBehaviour
{

    public List<ItemPickup> inventory = new List<ItemPickup>();

    public void AddItem(ItemPickup item)
    {
        inventory.Add(item);
        Debug.Log(item.name);
    }

}
