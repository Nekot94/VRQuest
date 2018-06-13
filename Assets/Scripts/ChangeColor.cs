using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour, IVRInteractible
{
    public void OnReady()
    {
        GetComponent<Renderer>().material.color = new Color(Random.value,
                     Random.value, Random.value);
    }
}
