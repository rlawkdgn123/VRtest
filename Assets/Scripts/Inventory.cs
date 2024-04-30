using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.GameFoundation;

public class Inventory : MonoBehaviour
{
    public ItemList Items { get; private set; }
    void Start()
    {
        if(Items == null)
        {
            Items = GameFoundationSdk.inventory.CreateList();
        }
    }
    public void Add(Item item) {
        Items.Add(item.inventoryItem);
        Debug.Log(item.inventoryItem.definition.displayName + " added");
        Destroy(item.gameObject);
    }
}
