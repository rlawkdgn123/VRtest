using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public Inventory inventory { get; private set; }
    private void Awake() {
        Inventory inventory= GetComponent<Inventory>();
    }
}
