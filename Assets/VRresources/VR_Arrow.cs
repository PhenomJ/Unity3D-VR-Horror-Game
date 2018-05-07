using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VR_Arrow : MonoBehaviour
{
    public Renderer[] arrowRenderers;
    public float showAngle = 60.0f;
    public float fadeSpeed = 10.0f;

    Vector3 baseVector = Vector3.forward;
    float currentAlpha = 0.0f;

    void Update()
    {
        Vector3 camForward = VrCameraManager.instance.transform.forward;
        float angle = Vector3.Angle(camForward, baseVector);

        float targetAlpha = angle > showAngle ? 1.0f : 0.0f;
        currentAlpha = Mathf.MoveTowards(currentAlpha, targetAlpha, fadeSpeed * Time.deltaTime);

        for (int i = 0; i < arrowRenderers.Length; i++)
        {
            arrowRenderers[i].material.SetFloat("_Alpha", currentAlpha);
        }
    }

}
