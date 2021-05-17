using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject EnnemiePrefab;

    public int EnnemiesToSpawn = 5;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < EnnemiesToSpawn; i++)
        {
            Instantiate(EnnemiePrefab, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}