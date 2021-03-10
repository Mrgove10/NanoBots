using System;
using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;

public class CounterTick : MonoBehaviour
{
    [ReadOnly] [SerializeField] private GameObject[] Emmiters;

    [SerializeField] private AudioSource AudioSource;

    [SerializeField] private GameObject Player;

    [SerializeField] private float delay = 10;

    private void Awake()
    {
        Emmiters = GameObject.FindGameObjectsWithTag("SoundEmmiter");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Emmiters);
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        while (true)
        {
            float closest = 999999f;
            foreach (var emmiter in Emmiters)
            {
                var distance = Vector3.Distance(Player.transform.position, emmiter.transform.position);
                if (closest > distance)
                {
                    closest = distance;
                }

                Debug.Log("c" + closest);
            }

            Debug.Log("tick");
            AudioSource.Play();
            Debug.Log(GetDelay(closest));
            yield return new WaitForSecondsRealtime(GetDelay(closest));
        }
    }

    /// <summary>
    /// Get the delay depending on the distance
    /// </summary>
    /// <param name="distance"></param>
    /// <returns></returns>
    float GetDelay(float distance)
    {
        if (distance < 2)
        {
            return 0.01f;
        }
        else if (distance < 5)
        {
            return 0.25f;
        }
        else if (distance > 10)
        {
            return 0.5f;
        }
        else if (distance < 15)
        {
            return 1;
        }
        else if (distance < 25)
        {
            return 10;
        }

        return 0;
    }
}