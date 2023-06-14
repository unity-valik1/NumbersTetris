using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    public string tagToCheck = "SlotsLine";

    public void BigBoom()
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tagToCheck);
        // Проверяем, есть ли объекты с заданным тегом
        if (taggedObjects.Length > 0)
        {
            for (int i = 0; i < taggedObjects.Length; i++)
            {
                Destroy(taggedObjects[i]);
            }
        }
        else
        {

        }
    }
}
