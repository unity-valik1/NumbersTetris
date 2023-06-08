using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public TMP_Text textScore;
    public TMP_Text textNowScore;

    private void Update()
    {
        textScore.text = score.ToString();
    }
}

