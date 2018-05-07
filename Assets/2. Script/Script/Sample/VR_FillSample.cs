using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VR_FillSample : MonoBehaviour
{
    VRLookAtObjectBase vrLookAtObjectBase;

    void Awake()
    {
        vrLookAtObjectBase = GetComponent<VRLookAtObjectBase>();
    }

    void OnEnable()
    {
        vrLookAtObjectBase.ButtonFillFinish += ButtonFillFinish;
    }

    void OnDisable()
    {
        vrLookAtObjectBase.ButtonFillFinish -= ButtonFillFinish;
    }

    void ButtonFillFinish()
    {
        SceneManager.LoadScene("Horror Hospital");
    }


}