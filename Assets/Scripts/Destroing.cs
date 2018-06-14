using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroing : MonoBehaviour, IVRInteractible
{
    public void OnReady()
    {
        if (GetComponent<Monster>() != null)
        {
            GetComponent<Monster>().Die();
        }
        Destroy(gameObject, 1);
    }
}
