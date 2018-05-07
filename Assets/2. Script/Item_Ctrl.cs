using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Item_Ctrl : MonoBehaviour
{
    public VRLookAtObjectBase lookatbase;
    public Item_Management item;

    public bool Key = false;
    public bool Key1 = false;
    public bool Key2 = false;

    private void Awake()
    {
        lookatbase = GetComponent<VRLookAtObjectBase>();
        item = GameObject.FindWithTag("Manager").GetComponent<Item_Management>();
    }

    private void OnEnable()
    {
        lookatbase.ButtonFillFinish += ButtonFillFinish;
    }

    private void OnDisable()
    {
        lookatbase.ButtonFillFinish -= ButtonFillFinish;
    }

    void ButtonFillFinish()
    {
        if (gameObject.tag == "Key")
        {
            gameObject.SetActive(false);
            Key = true;
        }

        else if (gameObject.tag == "Key1")
        {
            gameObject.SetActive(false);
            Key1 = true;
        }

        else if (gameObject.tag == "Key2")
        {
            gameObject.SetActive(false);
            Key2 = true;
        }

        else if (gameObject.tag == "Last_Key")
        {
            gameObject.SetActive(false);
            item.Last_Key = true;
        }   
    }
}