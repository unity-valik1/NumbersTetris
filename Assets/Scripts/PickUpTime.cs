using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTime : MonoBehaviour
{
    public static bool minusAndPlus = true;
    public static float timeminusAndPlus = 0f;
    public static bool x2Score = false;
    public static float timeX2Score = 0f;

    void Update()
    {
        if (x2Score== true)
        {
            timeX2Score += Time.deltaTime;
            if (timeX2Score > 20)
            {
                x2Score = false;
            }
        }
        if(minusAndPlus == false)
        {
            timeminusAndPlus += Time.deltaTime;
            print(timeminusAndPlus);
            if (timeminusAndPlus > 20)
            {
                minusAndPlus = true;
            }
        }
    }
}
