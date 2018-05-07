using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Management : MonoBehaviour {
    public int KeyCount;
    Item_Ctrl item;
    public bool Last_Key = false;

    private void Awake()
    {
        item = GetComponent<Item_Ctrl>();
    }
   
    public void GetKeys (int keycount)
    {
        KeyCount = keycount;
    }
}
