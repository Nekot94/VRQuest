using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject spawnObject;
    public float timeToSpawn = 3;

	void Start ()
    {
        StartCoroutine(Spawn());
	}
    
    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeToSpawn);
            Instantiate(spawnObject, transform.position, transform.rotation);
        }        
    }
}
