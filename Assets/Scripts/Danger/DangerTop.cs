using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerTop : MonoBehaviour
{
    public GameObject[] dangers;
    public GameObject prefabQuestionMark;
    public GameObject prefabDanger;

    private float time3 = 0f;
    public bool dangerIsReady;
    public int foolDangers;

    private void Update()
    {
        time3 += Time.deltaTime;
        if (time3 > 5)
        {
            foolDangers = 0;
            dangerIsReady = true;
        }
        if (dangerIsReady == true)
        {
            int number = Random.Range(0, 7);
            for (int i = 0; i < dangers.Length; i++)
            {
                if (number == i && foolDangers == 0)
                {
                    GameObject questionMark = Instantiate(prefabQuestionMark);
                    questionMark.transform.position = dangers[i].transform.position;
                    GameObject danger = Instantiate(prefabDanger);
                    danger.transform.position = dangers[i].transform.position;
                    time3 = 0;
                    dangerIsReady = false;
                    foolDangers = 1;
                }
            }
        }
    }
}
