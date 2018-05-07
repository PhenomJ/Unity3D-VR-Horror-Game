using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorControl : MonoBehaviour {

    public Item_Ctrl item, item1, item2;
    public Transform doortransform;
    public Item_Management item_management; 
     
    
    private void Awake()
    {
        doortransform = GetComponent<Transform>();
        item = GameObject.FindGameObjectWithTag("Key").GetComponent<Item_Ctrl>();
        item1 = GameObject.FindGameObjectWithTag("Key1").GetComponent<Item_Ctrl>();
        item2 = GameObject.FindGameObjectWithTag("Key2").GetComponent<Item_Ctrl>();
        item_management = GameObject.FindGameObjectWithTag("Manager").GetComponent<Item_Management>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (item.Key == false)
            {
                if (gameObject.tag == "Door1")
                {
                    doortransform.Rotate(doortransform.rotation.x, doortransform.rotation.y + 45, doortransform.rotation.z);     
                }
            }

            if (item.Key == true)
            {
                if (gameObject.tag == "Door2")
                {
                    doortransform.Rotate(doortransform.rotation.x, doortransform.rotation.y+45, doortransform.rotation.z);
                }
            }
            
            if (item1.Key1 == true)
            {
                if (gameObject.tag == "Door3")
                    doortransform.Rotate(doortransform.rotation.x, doortransform.rotation.y - 45, doortransform.rotation.z);
                
            }
            if (item2.Key2 == true)
            {
                if (gameObject.tag == "Door4")
                    Debug.LogWarning("==========");
                    doortransform.Rotate(doortransform.rotation.x, doortransform.rotation.y + 45, doortransform.rotation.z);
            }
            if (item_management.Last_Key == true)
            {
                if (gameObject.tag == "Last_Door")
                    SceneManager.LoadScene("Escape");
            }
            
        }
    }      
}
