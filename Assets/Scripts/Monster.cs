using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Monster : MonoBehaviour
{
    Transform player;
    NavMeshAgent agent;

	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
	}
	
	void Update ()
    {
        agent.SetDestination(player.position);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameController.instance.Lose();
        }
    }

    public void Die()
    {
        GetComponent<AudioSource>().Play();
    }
}
