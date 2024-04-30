using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.GameFoundation;

public class Item : MonoBehaviour
{
    [SerializeField] private string definitionkey;
    public InventoryItem inventoryItem { get; private set; }

    private void OnEnable() {
        InventoryItemDefinition itemDefinition =
            GameFoundationSdk.catalog.Find<InventoryItemDefinition>
            (definitionkey);

        inventoryItem = GameFoundationSdk.inventory.CreateItem (itemDefinition);
    }
}
