using System;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class CounterTick : MonoBehaviour
{
    [ReadOnly]
    [SerializeField] 
    private GameObject[] Emmiters;

    [SerializeField]
    private AudioSource AudioSource;
    
    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private float delay = 10;
    private void Awake()
    {
        Emmiters = GameObject.FindGameObjectsWithTag("SoundEmmiter");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Emmiters);
    }

    // Update is called once per frame
    void Update()
    {
        float closest = 999999f;
        foreach (var emmiter in Emmiters)
        {
            var distance = Vector3.Distance(Player.transform.position, emmiter.transform.position);
            if (closest > distance)
            {
                closest = distance;
            }

            Debug.Log("c"+closest);
            Debug.Log("d"+distance);
        }
    }
}
