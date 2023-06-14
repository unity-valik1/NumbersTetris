using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBlockGeneration : MonoBehaviour
{
    public GameObject prefab; // Ссылка на префаб
    public GameObject placeOfGeneration;
    public GameObject Generation;
    public GameObject cameraGo;
    public GameObject gun;
    public GameObject gameOver;
    public GameObject bg;
    public bool nextPrefab = false;
    public static int gg = 0;
    public float time = 0f;
    public string tagToCheck = "SlotsLine";

    public float duration = 2f; // Продолжительность перемещения в секундах
    private void Start()
    {
        GameObject instance = Instantiate(prefab);
        instance.transform.position = placeOfGeneration.transform.position;

        nextPrefab = false;
        time = 0f;

        instance.transform.position -= new Vector3(0, 1, 0);
    }
    private void Update()
    {
        time += Time.deltaTime;
        if (Mathf.Floor(time) % 1 == 0)
        {
            //Debug.Log("Time: " + time);
        }
        if (time > 12f)
        {
            nextPrefab = true;
        }
        if (nextPrefab == true)
        {
            time = 0f;
            StartCoroutine(MoveObject());
            gg = 1;
        }
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(tagToCheck);

        // Проверяем, есть ли объекты с заданным тегом
        if (taggedObjects.Length > 0)
        {

        }
        else
        {
            nextPrefab = false;
            time = 0f;
            StartCoroutine(MoveObject());
        }
    }
    private IEnumerator MoveObject()
    {
        GameObject instance = Instantiate(prefab);
        instance.transform.position = placeOfGeneration.transform.position;

        Vector3 startPositionGeneration = instance.transform.position;
        Vector3 targetPosition = startPositionGeneration - new Vector3(0f, 1f, 0f);

        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            float t = elapsedTime / duration;
            instance.transform.position = Vector3.Lerp(startPositionGeneration, targetPosition, t);
            elapsedTime += Time.deltaTime;
            gg = 0;
            nextPrefab = false;
            yield return null;
        }
    }
}
