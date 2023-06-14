using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    public string tagToCheck = "SlotsLine";

    public void BigLazer()
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tagToCheck);
        // Проверяем, есть ли объекты с заданным тегом
        if (taggedObjects.Length > 0)
        {
            for (int i = 0; i < taggedObjects.Length; i++)
            {
                Destroy(taggedObjects[0]);
            }
        }
        else
        {

        }
    }
}
