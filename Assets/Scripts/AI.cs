using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    public GameObject Player;

    public NavMeshAgent Agent;

    public int health = 1000;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        Debug.Log(Player);
        Agent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Agent.SetDestination(Player.transform.position);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
