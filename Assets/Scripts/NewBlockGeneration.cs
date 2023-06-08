using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBlockGeneration : MonoBehaviour
{
    public GameObject prefab; // —сылка на префаб
    public GameObject placeOfGeneration;
    public GameObject Generation;
    public GameObject cameraGo;
    public GameObject gun;
    public GameObject gameOver;
    public GameObject platformDestroyTop;
    public GameObject platformDestroyBot;
    public GameObject bg;
    private bool nextPrefab = false;
    private float time = 0f;
    private void Start()
    {
        GameObject instance = Instantiate(prefab);
        instance.transform.position = placeOfGeneration.transform.position;

        nextPrefab = false;
        time = 0f;
        Generation.transform.position += new Vector3(0, 1, 0);
        cameraGo.transform.position += new Vector3(0, 1, 0);
        gun.transform.position += new Vector3(0, 1, 0);
        gameOver.transform.position += new Vector3(0, 1, 0);
        platformDestroyTop.transform.position += new Vector3(0, 1, 0);
        platformDestroyBot.transform.position += new Vector3(0, 1, 0);
        bg.transform.position += new Vector3(0, 1, 0);
    }
    private void Update()
    {
        time += Time.deltaTime;
        if (Mathf.Floor(time) % 1 == 0)
        {
            //Debug.Log("Time: " + time);
        }
        if (time > 15f)
        {
            nextPrefab = true;
        }
        if (nextPrefab == true)
        {
            GameObject instance = Instantiate(prefab);
            instance.transform.position = placeOfGeneration.transform.position;

            nextPrefab = false;
            time = 0f;
            Generation.transform.position += new Vector3(0, 1, 0);
            cameraGo.transform.position += new Vector3(0, 1, 0);
            gun.transform.position += new Vector3(0, 1, 0);
            gameOver.transform.position += new Vector3(0, 1, 0);
            platformDestroyTop.transform.position += new Vector3(0, 1, 0);
            platformDestroyBot.transform.position += new Vector3(0, 1, 0);
            bg.transform.position += new Vector3(0, 1, 0);
        }
    }
}
