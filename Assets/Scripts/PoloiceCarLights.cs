using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoloiceCarLights : MonoBehaviour
{
[SerializeField]
    private Light L1;
[SerializeField]
    private Light L2;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Blink());
    }

    IEnumerator Blink()
        {
            while (true){
                L1.color = Color.blue;
                L2.color = Color.red;
                L1.intensity = 1;
                L2.intensity = 1;
                yield return new WaitForSecondsRealtime(0.5f);
                L1.intensity = 0;
                L2.intensity = 0;
                yield return new WaitForSecondsRealtime(0.25f);
                L1.color = Color.red;
                L2.color = Color.blue;
                L1.intensity = 1;
                L2.intensity = 1;
                yield return new WaitForSecondsRealtime(0.5f);
                L1.intensity = 0;
                L2.intensity = 0;
                yield return new WaitForSecondsRealtime(0.25f);
            }
        }
    }
