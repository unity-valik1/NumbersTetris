using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerIsReady : MonoBehaviour
{
    private float time2 = 0f;
    private void Update()
    {
        time2 += Time.deltaTime;
        if (time2 > 2)
        {
            Destroy(gameObject);
        }
    }
}
